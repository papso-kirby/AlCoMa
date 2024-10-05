namespace AlCoMa.Types
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Stats
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("hydra:totalItems")]
        public long HydraTotalItems { get; set; }

        [JsonProperty("hydra:member")]
        public HydraMember[] HydraMember { get; set; }

        [JsonProperty("hydra:view")]
        public HydraView HydraView { get; set; }

        [JsonProperty("hydra:search")]
        public HydraSearch HydraSearch { get; set; }
    }

    public partial class HydraMember
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public HydraMemberType Type { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("inMyTradelist")]
        public int InMyTradelist { get; set; }

        [JsonProperty("inMyCollection")]
        public int InMyCollection { get; set; }

        [JsonProperty("inMyWantlist")]
        public bool InMyWantlist { get; set; }

        [JsonProperty("foiled")]
        public bool Foiled { get; set; }
    }

    public partial class HydraSearch
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("hydra:template")]
        public string HydraTemplate { get; set; }

        [JsonProperty("hydra:variableRepresentation")]
        public string HydraVariableRepresentation { get; set; }

        [JsonProperty("hydra:mapping")]
        public HydraMapping[] HydraMapping { get; set; }
    }

    public partial class HydraMapping
    {
        [JsonProperty("@type")]
        public HydraMappingType Type { get; set; }

        [JsonProperty("variable")]
        public string Variable { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }

        [JsonProperty("required")]
        public bool HydraMappingRequired { get; set; }
    }

    public partial class HydraView
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("hydra:first")]
        public string HydraFirst { get; set; }

        [JsonProperty("hydra:last")]
        public string HydraLast { get; set; }

        [JsonProperty("hydra:next")]
        public string HydraNext { get; set; }
    }

    public enum HydraMemberType { Card };

    public enum HydraMappingType { IriTemplateMapping };

    public partial class Stats
    {
        public static Stats FromJson(string json) => JsonConvert.DeserializeObject<Stats>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Stats self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                HydraMemberTypeConverter.Singleton,
                HydraMappingTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class HydraMemberTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HydraMemberType) || t == typeof(HydraMemberType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Card")
            {
                return HydraMemberType.Card;
            }
            throw new Exception("Cannot unmarshal type HydraMemberType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HydraMemberType)untypedValue;
            if (value == HydraMemberType.Card)
            {
                serializer.Serialize(writer, "Card");
                return;
            }
            throw new Exception("Cannot marshal type HydraMemberType");
        }

        public static readonly HydraMemberTypeConverter Singleton = new HydraMemberTypeConverter();
    }

    internal class HydraMappingTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HydraMappingType) || t == typeof(HydraMappingType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "IriTemplateMapping")
            {
                return HydraMappingType.IriTemplateMapping;
            }
            throw new Exception("Cannot unmarshal type HydraMappingType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HydraMappingType)untypedValue;
            if (value == HydraMappingType.IriTemplateMapping)
            {
                serializer.Serialize(writer, "IriTemplateMapping");
                return;
            }
            throw new Exception("Cannot marshal type HydraMappingType");
        }

        public static readonly HydraMappingTypeConverter Singleton = new HydraMappingTypeConverter();
    }
}
