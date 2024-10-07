using CSharpFunctionalExtensions;
using AlCoMa.types;
using AlCoMa.Types;
using CsvHelper;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using static AlCoMa.DataSet1;

namespace AlCoMa
{
    public class StorageManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private DataSet1 internalData = new();
        private DataView internalDataView = new DataView();

        private bool mergeKS = true;
        private bool includeRare = true;
        private bool includeCommon;
        private bool includeYzmir = true;
        private bool includeOrdis = true;
        private bool includeMuna = true;
        private bool includeBravos = true;
        private bool includeLyra = true;
        private bool includeAxiom = true;
        private string? filterText;
        private int totalCardsInCollection;
        private int cardsShown;
        private bool includeCharacter = true;
        private bool includePermanent = true;
        private bool includeSpell = true;
        private bool includeTokenCharacter = true;
        private bool includeHero = true;
        private bool includeKS = true;
        private bool includeBTG = true;
        private bool surplus;

        public bool MergeKS { get => mergeKS; set { SetField(ref mergeKS, value); FilterData(); } }
        public bool IncludeRare { get => includeRare; set { SetField(ref includeRare, value); FilterData(); } }
        public bool IncludeCommon { get => includeCommon; set { SetField(ref includeCommon, value); FilterData(); } }
        public bool IncludeYzmir { get => includeYzmir; set { SetField(ref includeYzmir, value); FilterData(); } }
        public bool IncludeOrdis { get => includeOrdis; set { SetField(ref includeOrdis, value); FilterData(); } }
        public bool IncludeMuna { get => includeMuna; set { SetField(ref includeMuna, value); FilterData(); } }
        public bool IncludeBravos { get => includeBravos; set { SetField(ref includeBravos, value); FilterData(); } }
        public bool IncludeLyra { get => includeLyra; set { SetField(ref includeLyra, value); FilterData(); } }
        public bool IncludeAxiom { get => includeAxiom; set { SetField(ref includeAxiom, value); FilterData(); } }
        public String? FilterText { get => filterText; set { SetField(ref filterText, value); FilterData(); } }
        public DataView Data { get => internalDataView; }
        public DataView Givelist { get => internalData.Givelist.DefaultView; }
        public int TotalCardsInCollection { get => totalCardsInCollection; set { SetField(ref totalCardsInCollection, value); } }
        public int CardsShown { get => cardsShown; set { SetField(ref cardsShown, value); } }
        public bool IncludeCharacter { get => includeCharacter; set { SetField(ref includeCharacter, value); FilterData(); } }
        public bool IncludePermanent { get => includePermanent; set { SetField(ref includePermanent, value); FilterData(); } }
        public bool IncludeSpell { get => includeSpell; set { SetField(ref includeSpell, value); FilterData(); } }
        public bool IncludeTokenCharacter { get => includeTokenCharacter; set { SetField(ref includeTokenCharacter, value); FilterData(); } }
        public bool IncludeHero { get => includeHero; set { SetField(ref includeHero, value); FilterData(); } }
        public bool IncludeKS { get => includeKS; set { SetField(ref includeKS, value); FilterData(); } }
        public bool IncludeBTG { get => includeBTG; set { SetField(ref includeBTG, value); FilterData(); } }
        public bool Surplus { get => surplus; set { SetField(ref surplus, value); FilterData(); } }

        private void FilterData()
        {
            DataSet1.MasterdataDataTable copy = new();

            if (MergeKS)
            {
                var grouped = internalData.Masterdata.Copy().AsEnumerable()
                    .GroupBy(c => c["Number"])
                    .Select(grp =>
                    {
                        var row = grp.First();
                        row["InMyCollection"] = grp.Sum(x => (int)x["InMyCollection"]);
                        row["Set"] = "KS/BTG";
                        return row;
                    });
                copy.Clear();
                foreach (MasterdataRow group in grouped)
                {
                    copy.ImportRow(group);
                }
            }
            else
            {
                foreach (MasterdataRow group in internalData.Masterdata)
                {
                    copy.ImportRow(group);
                }
            }

            var rarityFilter = new List<string>();
            if (IncludeRare) rarityFilter.Add("[Rarity] = 'Rare'");
            if (IncludeCommon) rarityFilter.Add("[Rarity] = 'Common'");
            var rarity = String.Join(" or ", rarityFilter);

            var factionFilter = new List<string>();
            if (IncludeAxiom) factionFilter.Add("[Faction] = 'Axiom'");
            if (IncludeMuna) factionFilter.Add("[Faction] = 'Muna'");
            if (IncludeOrdis) factionFilter.Add("[Faction] = 'Ordis'");
            if (IncludeYzmir) factionFilter.Add("[Faction] = 'Yzmir'");
            if (IncludeLyra) factionFilter.Add("[Faction] = 'Lyra'");
            if (IncludeBravos) factionFilter.Add("[Faction] = 'Bravos'");
            var faction = String.Join(" or ", factionFilter);

            var text = !String.IsNullOrWhiteSpace(FilterText?.Trim())
                ? $"[Name] LIKE '%{FilterText?.Trim()}%' OR [Abilities] LIKE '%{FilterText?.Trim()}%' OR [SupportAbility] LIKE '%{FilterText?.Trim()}%'"
                : null;

            var typeFilter = new List<string>();
            if (IncludeCharacter) typeFilter.Add("[Type] = 'Character'");
            if (IncludeSpell) typeFilter.Add("[Type] = 'Spell'");
            if (IncludePermanent) typeFilter.Add("[Type] = 'Permanent'");
            if (IncludeTokenCharacter) typeFilter.Add("[Type] = 'Token Character'");
            if (IncludeHero) typeFilter.Add("[Type] = 'Hero'");
            var type = String.Join(" or ", typeFilter);

            var setFilter = new List<string>();
            if (IncludeKS) setFilter.Add("[Set] = 'KS'");
            if (IncludeBTG) setFilter.Add("[Set] = 'BTG'");
            if (MergeKS) setFilter.Add("[Set] = 'KS/BTG'");
            var set = String.Join(" or ", setFilter);

            var surplus = Surplus
                ? "[InMyCollection] > 3"
                : null;

            var filters = new List<string?>() { rarity, faction, text, type, set, surplus };

            internalDataView.Table = copy;
            internalDataView.RowFilter = String.Join(" and ", filters.Where(f => !String.IsNullOrWhiteSpace(f)).Select(f => $"({f})"));

            OnPropertyChanged("Data");
            CardsShown = SumColumn(Data, "InMyCollection");
            TotalCardsInCollection = SumColumn(internalData.Masterdata.DefaultView, "InMyCollection");
        }

        static int SumColumn(DataView dataView, string columnName)
        {
            int sum = 0;
            foreach (DataRowView rowView in dataView)
            {
                if (rowView[columnName] != DBNull.Value)
                {
                    sum += Convert.ToInt32(rowView[columnName]);
                }
            }
            return sum;
        }

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        internal void Load()
        {
            Logger.Log("Loading Data");
            try
            {
                var data = new Dictionary<string, HydraMember>();

                UserFiles.Collection.Load()
                    .Map(JsonConvert.DeserializeObject<List<HydraMember>>)
                    .TapIf(c => c != null, collectionData =>
                    {
                        data = collectionData!.ToDictionary(c => c.Reference, c => c);
                    });

                this.internalData.Masterdata.Clear();
                using (var reader = Masterdata.Cards.GetReader())
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<CardMasterdata>();
                    foreach (var x in records)
                    {
                        this.internalData.Masterdata.Rows.Add(
                                x.name_en,
                                x.collectorNumber,
                                x.faction,
                                x.rarity,
                                x.type,
                                x.forestPower,
                                x.mountainPower,
                                x.waterPower,
                                x.handCost,
                                x.reserveCost,
                                x.abilities_en,
                                x.supportAbility_en,
                                x.imagePath,
                                x.id,
                                data.GetValueOrDefault(x.id)?.InMyCollection ?? 0,
                                x.id.Contains("COREKS") ? "KS" : "BTG"
                            );
                    }
                    FilterData();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
            }
        }

        internal void AddCardToGiveList(DataRow row)
        {
            this.internalData.Givelist.AddGivelistRow(
               row["Name"].ToString(),
               row["Number"].ToString(),
               row["Faction"].ToString(),
               row["Rarity"].ToString(),
               row["Type"].ToString(),
               row["ID"].ToString()
           );
        }

        internal void ClearGivelist() => internalData.Givelist.Clear();
    }
}
