using AlCoMa.Types;
using CSharpFunctionalExtensions;

namespace AlCoMa
{
    public static class WebClient
    {
        static string url = "https://api.altered.gg/cards/stats?collection=true&itemsPerPage=%ITEMS%&page=%PAGE%&locale=en-us";

        private async static Task<Result<HttpResponseMessage>> Get(string token, int page = 1, int itemsPerPage = 36)
        {
            try
            {
                using HttpClient client = new();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Trim());
                var response = await client.GetAsync(url.Replace("%PAGE%", page.ToString()).Replace("%ITEMS%", itemsPerPage.ToString()));
                return Result.Success(response);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
                return Result.Failure<HttpResponseMessage>(ex.ToString());
            }
        }

        public async static Task<bool> CheckToken(string token) => (await Get(token)).Ensure(r => r.IsSuccessStatusCode, "no success").IsSuccess;

        public async static Task<Result<List<HydraMember>>> GetCollection(string token)
        {
            int i = 1;
            List<HydraMember> collection = new();
            List<HydraMember> currentData = new();
            string error = null;
            do
            {
                var response = await Get(token, i);
                await response.Ensure(r => r.IsSuccessStatusCode, r => r.StatusCode.ToString())
                    .Tap(async r =>
                    {
                        // Read the JSON response
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
    }
}
