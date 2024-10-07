using AlCoMa.types;
using AlCoMa.Types;
using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Text;

namespace AlCoMa
{
    public static class WebClient
    {
        internal const string STATS_URL = "https://api.altered.gg/cards/stats?collection=true&itemsPerPage=%ITEMS%&page=%PAGE%&locale=en-us";
        internal const string FRIENDS_ULR = "https://api.altered.gg/user_friendships?itemsPerPage=200&page=1";
        internal const string GIVE_URL = "https://api.altered.gg/owners/give";

        private async static Task<Result<HttpResponseMessage>> Get(string URL, string token, int page = 1, int itemsPerPage = 36)
        {
            try
            {
                using HttpClient client = new();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Trim());
                var response = await client.GetAsync(URL.Replace("%PAGE%", page.ToString()).Replace("%ITEMS%", itemsPerPage.ToString()));
                return Result.Success(response);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
                return Result.Failure<HttpResponseMessage>(ex.ToString());
            }
        }

        public async static Task<bool> CheckToken(string token) => (await Get(STATS_URL, token)).Ensure(r => r.IsSuccessStatusCode, "no success").IsSuccess;

        public async static Task<Result<List<Friend>>> GetFriends(string token)
        {
            int i = 1;
            List<Friend> collection = new();
            List<Friend> currentData = new();
            string? error = null;
            do
            {
                var response = await Get(FRIENDS_ULR, token, i);
                await response.Ensure(r => r.IsSuccessStatusCode, r => r.StatusCode.ToString())
                    .Tap(async r =>
                    {
                        var jsonResponse = await r.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject<dynamic>(jsonResponse)!;
                        Logger.Log($"Response JSON: {jsonResponse[..20]}...");
                        dynamic members = data["hydra:member"];
                        foreach (dynamic member in members)
                        {
                            dynamic userFriend = member["userFriend"];
                            dynamic uniqueId = userFriend["uniqueId"];
                            dynamic id = userFriend["@id"];
                            collection.Add(new Friend(uniqueId.ToString(), id.ToString()));
                        }
                        i++;
                    })
                    .TapError(r =>
                    {
                        Logger.Log($"Error: {r}");
                        error = r;
                    }
                    );
            }
            while (error == null && currentData.Any());
            return Result.Success(collection);
        }

        public async static Task<Result<List<HydraMember>>> GetCollection(string token)
        {
            int i = 1;
            List<HydraMember> collection = new();
            List<HydraMember> currentData = new();
            string? error = null;
            do
            {
                var response = await Get(STATS_URL, token, i);
                await response.Ensure(r => r.IsSuccessStatusCode, r => r.StatusCode.ToString())
                    .Tap(async r =>
                    {
                        var jsonResponse = await r.Content.ReadAsStringAsync();
                        Logger.Log($"Response JSON: {jsonResponse[..20]}...");
                        currentData = Stats.FromJson(jsonResponse).HydraMember.ToList();
                        collection.AddRange(currentData);
                        i++;
                    })
                    .TapError(r =>
                    {
                        Logger.Log($"Error: {r}");
                        error = r;
                    }
                    );
            }
            while (error == null && currentData.Any());
            return Result.Success(collection);
        }

        public async static Task<Result<int>> GiveCards(string token, Friend friend, List<string> cards)
        {
            //{ "quantity":1,"user":"/users/01J8596WQJXPP14DKTZSV7XC8T","cards":[{ "reference":"ALT_COREKS_B_YZ_16_C","quantity":1}]}
            try
            {
                using HttpClient client = new();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Trim());

                foreach (var card in cards)
                {
                    var requestBody = new
                    {
                        quantity = 1,
                        user = friend.ID,
                        cards = new[]
                        {
                            new { reference = card, quantity = 1 }
                        }
                    };
                    string json = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://api.altered.gg/owners/give", content);
                    if (!response.IsSuccessStatusCode)
                    {
                        return Result.Failure<int>(response.StatusCode.ToString());
                    }
                }
               
                return Result.Success(1);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
                return Result.Failure<int>(ex.ToString());
            }
        }
    }
}
