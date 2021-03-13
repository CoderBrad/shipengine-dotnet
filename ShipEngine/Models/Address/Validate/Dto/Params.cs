// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Models;
//
//    var addressValidationParams = AddressValidationParams.FromJson(jsonString);

namespace ShipEngine.Models.Address.Dto
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The params to validate an address.
    /// </summary>
    public class AddressValidationParams
    {
        [JsonProperty("city_locality", NullValueHandling = NullValueHandling.Ignore)]
        public string CityLocality { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }


        [JsonProperty("state_province", NullValueHandling = NullValueHandling.Ignore)]
        public string StateProvince { get; set; }

        [JsonProperty("street")]
        public IEnumerable<string> Street { get; set; }
    }

    public class AddressValidationParamsConvert
    {
        public static AddressValidationParams FromJson(string json) => JsonConvert.DeserializeObject<AddressValidationParams>(json, Models.Converter.Settings);
    }

    public static class SerializeAddressValidationParams
    {
        public static string ToJson(this AddressValidationParams self) => JsonConvert.SerializeObject(self, Models.Converter.Settings);
    }
}
