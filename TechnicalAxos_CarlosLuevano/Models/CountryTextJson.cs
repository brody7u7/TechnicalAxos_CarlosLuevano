using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TechnicalAxos_CarlosLuevano.Models.TextJson
{
    /*
     * Holds country information 
     */
    public partial class CountryTextJson
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tld")]
        public string[] Tld { get; set; }

        [JsonPropertyName("cca2")]
        public string Cca2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ccn3")]
        public string Ccn3 { get; set; }

        [JsonPropertyName("cca3")]
        public string Cca3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("independent")]
        public bool? Independent { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("unMember")]
        public bool UnMember { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("currencies")]
        public Dictionary<string, Currency> Currencies { get; set; }

        [JsonPropertyName("idd")]
        public Idd Idd { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("capital")]
        public string[] Capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public string[] AltSpellings { get; set; }

        [JsonPropertyName("region")]
        public Region Region { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("languages")]
        public Dictionary<string, string> Languages { get; set; }

        [JsonPropertyName("translations")]
        public Dictionary<string, Translation> Translations { get; set; }

        [JsonPropertyName("latlng")]
        public double[] Latlng { get; set; }

        [JsonPropertyName("landlocked")]
        public bool Landlocked { get; set; }

        [JsonPropertyName("area")]
        public double Area { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("demonyms")]
        public Demonyms Demonyms { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("maps")]
        public Maps Maps { get; set; }

        [JsonPropertyName("population")]
        public long Population { get; set; }

        [JsonPropertyName("car")]
        public Car Car { get; set; }

        [JsonPropertyName("timezones")]
        public string[] Timezones { get; set; }

        [JsonPropertyName("continents")]
        public Continent[] Continents { get; set; }

        [JsonPropertyName("flags")]
        public Flags Flags { get; set; }

        [JsonPropertyName("coatOfArms")]
        public CoatOfArms CoatOfArms { get; set; }

        [JsonPropertyName("startOfWeek")]
        public StartOfWeek StartOfWeek { get; set; }

        [JsonPropertyName("capitalInfo")]
        public CapitalInfo CapitalInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("cioc")]
        public string Cioc { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fifa")]
        public string Fifa { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("borders")]
        public string[] Borders { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("gini")]
        public Dictionary<string, double> Gini { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("postalCode")]
        public PostalCode PostalCode { get; set; }
    }

    public partial class CapitalInfo
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("latlng")]
        public double[] Latlng { get; set; }
    }

    public partial class Car
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("signs")]
        public string[] Signs { get; set; }

        [JsonPropertyName("side")]
        public Side Side { get; set; }
    }

    public partial class CoatOfArms
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("png")]
        public Uri Png { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("svg")]
        public Uri Svg { get; set; }
    }

    public partial class Currency
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }

    public partial class Demonyms
    {
        [JsonPropertyName("eng")]
        public Eng Eng { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fra")]
        public Eng Fra { get; set; }
    }

    public partial class Eng
    {
        [JsonPropertyName("f")]
        public string F { get; set; }

        [JsonPropertyName("m")]
        public string M { get; set; }
    }

    public partial class Flags
    {
        [JsonPropertyName("png")]
        public Uri Png { get; set; }

        [JsonPropertyName("svg")]
        public Uri Svg { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("alt")]
        public string Alt { get; set; }
    }

    public partial class Idd
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("root")]
        public string Root { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("suffixes")]
        public string[] Suffixes { get; set; }
    }

    public partial class Maps
    {
        [JsonPropertyName("googleMaps")]
        public Uri GoogleMaps { get; set; }

        [JsonPropertyName("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

    public partial class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("nativeName")]
        public Dictionary<string, Translation> NativeName { get; set; }
    }

    public partial class Translation
    {
        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }
    }

    public partial class PostalCode
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("regex")]
        public string Regex { get; set; }
    }

    public enum Side { Left, Right };

    public enum Continent { Africa, Antarctica, Asia, Europe, NorthAmerica, Oceania, SouthAmerica };

    public enum Region { Africa, Americas, Antarctic, Asia, Europe, Oceania };

    public enum StartOfWeek { Monday, Saturday, Sunday };

    public enum Status { OfficiallyAssigned, UserAssigned };

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                SideConverter.Singleton,
                ContinentConverter.Singleton,
                RegionConverter.Singleton,
                StartOfWeekConverter.Singleton,
                StatusConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class SideConverter : JsonConverter<Side>
    {
        public override bool CanConvert(Type t) => t == typeof(Side);

        public override Side Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "left":
                    return Side.Left;
                case "right":
                    return Side.Right;
            }
            throw new Exception("Cannot unmarshal type Side");
        }

        public override void Write(Utf8JsonWriter writer, Side value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Side.Left:
                    JsonSerializer.Serialize(writer, "left", options);
                    return;
                case Side.Right:
                    JsonSerializer.Serialize(writer, "right", options);
                    return;
            }
            throw new Exception("Cannot marshal type Side");
        }

        public static readonly SideConverter Singleton = new SideConverter();
    }

    internal class ContinentConverter : JsonConverter<Continent>
    {
        public override bool CanConvert(Type t) => t == typeof(Continent);

        public override Continent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Africa":
                    return Continent.Africa;
                case "Antarctica":
                    return Continent.Antarctica;
                case "Asia":
                    return Continent.Asia;
                case "Europe":
                    return Continent.Europe;
                case "North America":
                    return Continent.NorthAmerica;
                case "Oceania":
                    return Continent.Oceania;
                case "South America":
                    return Continent.SouthAmerica;
            }
            throw new Exception("Cannot unmarshal type Continent");
        }

        public override void Write(Utf8JsonWriter writer, Continent value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Continent.Africa:
                    JsonSerializer.Serialize(writer, "Africa", options);
                    return;
                case Continent.Antarctica:
                    JsonSerializer.Serialize(writer, "Antarctica", options);
                    return;
                case Continent.Asia:
                    JsonSerializer.Serialize(writer, "Asia", options);
                    return;
                case Continent.Europe:
                    JsonSerializer.Serialize(writer, "Europe", options);
                    return;
                case Continent.NorthAmerica:
                    JsonSerializer.Serialize(writer, "North America", options);
                    return;
                case Continent.Oceania:
                    JsonSerializer.Serialize(writer, "Oceania", options);
                    return;
                case Continent.SouthAmerica:
                    JsonSerializer.Serialize(writer, "South America", options);
                    return;
            }
            throw new Exception("Cannot marshal type Continent");
        }

        public static readonly ContinentConverter Singleton = new ContinentConverter();
    }

    internal class RegionConverter : JsonConverter<Region>
    {
        public override bool CanConvert(Type t) => t == typeof(Region);

        public override Region Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Africa":
                    return Region.Africa;
                case "Americas":
                    return Region.Americas;
                case "Antarctic":
                    return Region.Antarctic;
                case "Asia":
                    return Region.Asia;
                case "Europe":
                    return Region.Europe;
                case "Oceania":
                    return Region.Oceania;
            }
            throw new Exception("Cannot unmarshal type Region");
        }

        public override void Write(Utf8JsonWriter writer, Region value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Region.Africa:
                    JsonSerializer.Serialize(writer, "Africa", options);
                    return;
                case Region.Americas:
                    JsonSerializer.Serialize(writer, "Americas", options);
                    return;
                case Region.Antarctic:
                    JsonSerializer.Serialize(writer, "Antarctic", options);
                    return;
                case Region.Asia:
                    JsonSerializer.Serialize(writer, "Asia", options);
                    return;
                case Region.Europe:
                    JsonSerializer.Serialize(writer, "Europe", options);
                    return;
                case Region.Oceania:
                    JsonSerializer.Serialize(writer, "Oceania", options);
                    return;
            }
            throw new Exception("Cannot marshal type Region");
        }

        public static readonly RegionConverter Singleton = new RegionConverter();
    }

    internal class StartOfWeekConverter : JsonConverter<StartOfWeek>
    {
        public override bool CanConvert(Type t) => t == typeof(StartOfWeek);

        public override StartOfWeek Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "monday":
                    return StartOfWeek.Monday;
                case "saturday":
                    return StartOfWeek.Saturday;
                case "sunday":
                    return StartOfWeek.Sunday;
            }
            throw new Exception("Cannot unmarshal type StartOfWeek");
        }

        public override void Write(Utf8JsonWriter writer, StartOfWeek value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case StartOfWeek.Monday:
                    JsonSerializer.Serialize(writer, "monday", options);
                    return;
                case StartOfWeek.Saturday:
                    JsonSerializer.Serialize(writer, "saturday", options);
                    return;
                case StartOfWeek.Sunday:
                    JsonSerializer.Serialize(writer, "sunday", options);
                    return;
            }
            throw new Exception("Cannot marshal type StartOfWeek");
        }

        public static readonly StartOfWeekConverter Singleton = new StartOfWeekConverter();
    }

    internal class StatusConverter : JsonConverter<Status>
    {
        public override bool CanConvert(Type t) => t == typeof(Status);

        public override Status Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "officially-assigned":
                    return Status.OfficiallyAssigned;
                case "user-assigned":
                    return Status.UserAssigned;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Status.OfficiallyAssigned:
                    JsonSerializer.Serialize(writer, "officially-assigned", options);
                    return;
                case Status.UserAssigned:
                    JsonSerializer.Serialize(writer, "user-assigned", options);
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}

