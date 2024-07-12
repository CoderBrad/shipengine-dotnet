/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// A rate estimate request body
/// </summary>
[JsonConverter(typeof(EstimateRatesRequestBodyJsonConverter))]
//[DataContract(Name = "estimate_rates_request_body")]
public partial class EstimateRatesRequestBody : AbstractOpenAPISchema
{

    /// <summary>
    /// Gets or Sets Confirmation
    /// </summary>
    [JsonPropertyName("confirmation")]
    public DeliveryConfirmation? Confirmation { get; set; }
    /// <summary>
    /// Gets or Sets AddressResidentialIndicator
    /// </summary>
    [JsonPropertyName("address_residential_indicator")]
    public AddressResidentialIndicator? AddressResidentialIndicator { get; set; }
    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("from_country_code")]
    [JsonRequired]
    public string FromCountryCode { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("from_postal_code")]
    [JsonRequired]
    public string FromPostalCode { get; set; }

    /// <summary>
    /// from postal code
    /// </summary>
    /// <value>from postal code</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("from_city_locality")]
    [JsonRequired]
    public string FromCityLocality { get; set; }

    /// <summary>
    /// From state province
    /// </summary>
    /// <value>From state province</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("from_state_province")]
    [JsonRequired]
    public string FromStateProvince { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("to_country_code")]
    [JsonRequired]
    public string ToCountryCode { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("to_postal_code")]
    [JsonRequired]
    public string ToPostalCode { get; set; }

    /// <summary>
    /// The city locality the package is being shipped to
    /// </summary>
    /// <value>The city locality the package is being shipped to</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("to_city_locality")]
    [JsonRequired]
    public string ToCityLocality { get; set; }

    /// <summary>
    /// To state province
    /// </summary>
    /// <value>To state province</value>
    /// <example>
    /// Houston
    /// </example>
    [JsonPropertyName("to_state_province")]
    [JsonRequired]
    public string ToStateProvince { get; set; }

    /// <summary>
    /// The weight of the package
    /// </summary>
    /// <value>The weight of the package</value>
    [JsonPropertyName("weight")]
    [JsonRequired]
    public Weight Weight { get; set; }

    /// <summary>
    /// The dimensions of the package
    /// </summary>
    /// <value>The dimensions of the package</value>
    [JsonPropertyName("dimensions")]
    public Dimensions Dimensions { get; set; }

    /// <summary>
    /// ship date
    /// </summary>
    /// <value>ship date</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    [JsonRequired]
    public DateTime ShipDate { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateRatesRequestBody" /> class
    /// with the <see cref="RateEstimateByCarrierId" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of RateEstimateByCarrierId.</param>
    public EstimateRatesRequestBody(RateEstimateByCarrierId actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType = "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateRatesRequestBody" /> class
    /// with the <see cref="RateEstimateByCarrierIds" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of RateEstimateByCarrierIds.</param>
    public EstimateRatesRequestBody(RateEstimateByCarrierIds actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType = "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }


    private Object _actualInstance;

    /// <summary>
    /// Gets or Sets ActualInstance
    /// </summary>
    public override Object ActualInstance
    {
        get
        {
            return _actualInstance;
        }
        set
        {
            if (value.GetType() == typeof(RateEstimateByCarrierId))
            {
                this._actualInstance = value;
            }
            else if (value.GetType() == typeof(RateEstimateByCarrierIds))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: RateEstimateByCarrierId, RateEstimateByCarrierIds");
            }
        }
    }

    /// <summary>
    /// Get the actual instance of `RateEstimateByCarrierId`. If the actual instance is not `RateEstimateByCarrierId`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of RateEstimateByCarrierId</returns>
    public RateEstimateByCarrierId GetRateEstimateByCarrierId()
    {
        return (RateEstimateByCarrierId)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `RateEstimateByCarrierIds`. If the actual instance is not `RateEstimateByCarrierIds`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of RateEstimateByCarrierIds</returns>
    public RateEstimateByCarrierIds GetRateEstimateByCarrierIds()
    {
        return (RateEstimateByCarrierIds)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstimateRatesRequestBody {\n");
        sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");

        sb.Append("  FromCountryCode: ").Append(this.FromCountryCode).Append("\n");
        sb.Append("  FromPostalCode: ").Append(this.FromPostalCode).Append("\n");
        sb.Append("  FromCityLocality: ").Append(this.FromCityLocality).Append("\n");
        sb.Append("  FromStateProvince: ").Append(this.FromStateProvince).Append("\n");
        sb.Append("  ToCountryCode: ").Append(this.ToCountryCode).Append("\n");
        sb.Append("  ToPostalCode: ").Append(this.ToPostalCode).Append("\n");
        sb.Append("  ToCityLocality: ").Append(this.ToCityLocality).Append("\n");
        sb.Append("  ToStateProvince: ").Append(this.ToStateProvince).Append("\n");
        sb.Append("  Weight: ").Append(this.Weight).Append("\n");
        sb.Append("  Dimensions: ").Append(this.Dimensions).Append("\n");
        sb.Append("  Confirmation: ").Append(this.Confirmation).Append("\n");
        sb.Append("  AddressResidentialIndicator: ").Append(this.AddressResidentialIndicator).Append("\n");
        sb.Append("  ShipDate: ").Append(this.ShipDate).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public override string ToJson()
    {
        return JsonSerializer.Serialize(this.ActualInstance, EstimateRatesRequestBody.SerializerSettings);
    }

}

/// <summary>
/// Custom JSON converter for EstimateRatesRequestBody
/// </summary>
public class EstimateRatesRequestBodyJsonConverter : JsonConverter<EstimateRatesRequestBody>
{
    private static HashSet<Type> OneOfTypes = [typeof(RateEstimateByCarrierId), typeof(RateEstimateByCarrierIds)];
    private static HashSet<string> MandatoryFields = ["FromCityLocality", "FromCountryCode", "FromPostalCode", "FromStateProvince", "ShipDate", "ToCityLocality", "ToCountryCode", "ToPostalCode", "ToStateProvince", "Weight"];
    private static JsonSerializerOptions DeserializingOptions = new(AbstractOpenAPISchema.SerializerSettings)
    {
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers =
            {
                static typeInfo =>
                {
                    if (typeInfo.Kind != JsonTypeInfoKind.Object)
                        return;

                    foreach (JsonPropertyInfo propertyInfo in typeInfo.Properties)
                    {
                        // Strip IsRequired constraint from every property except those which define the underlying type
                        if (OneOfTypes.Contains(typeInfo.Type))
                        {
                            var underlyingPropertyName = (propertyInfo.AttributeProvider as MemberInfo)?.Name;
                            propertyInfo.IsRequired = underlyingPropertyName != null && MandatoryFields.Contains(underlyingPropertyName);
                        }
                        else
                        {
                            propertyInfo.IsRequired = false;
                        }
                    }
                }
            }
        }
    };

    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="options">Serializer options</param>
    public override void Write(Utf8JsonWriter writer, EstimateRatesRequestBody value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("from_country_code");
        JsonSerializer.Serialize(writer, value.FromCountryCode, options);
        writer.WritePropertyName("from_postal_code");
        JsonSerializer.Serialize(writer, value.FromPostalCode, options);
        writer.WritePropertyName("from_city_locality");
        JsonSerializer.Serialize(writer, value.FromCityLocality, options);
        writer.WritePropertyName("from_state_province");
        JsonSerializer.Serialize(writer, value.FromStateProvince, options);
        writer.WritePropertyName("to_country_code");
        JsonSerializer.Serialize(writer, value.ToCountryCode, options);
        writer.WritePropertyName("to_postal_code");
        JsonSerializer.Serialize(writer, value.ToPostalCode, options);
        writer.WritePropertyName("to_city_locality");
        JsonSerializer.Serialize(writer, value.ToCityLocality, options);
        writer.WritePropertyName("to_state_province");
        JsonSerializer.Serialize(writer, value.ToStateProvince, options);
        writer.WritePropertyName("weight");
        JsonSerializer.Serialize(writer, value.Weight, options);
        writer.WritePropertyName("dimensions");
        JsonSerializer.Serialize(writer, value.Dimensions, options);
        writer.WritePropertyName("confirmation");
        JsonSerializer.Serialize(writer, value.Confirmation, options);
        writer.WritePropertyName("address_residential_indicator");
        JsonSerializer.Serialize(writer, value.AddressResidentialIndicator, options);
        writer.WritePropertyName("ship_date");
        JsonSerializer.Serialize(writer, value.ShipDate, options);

        var node = JsonSerializer.SerializeToNode(value.ActualInstance, options);
        foreach (var prop in node?.AsObject() ?? [])
        {
            if (prop.Value != null)
            {
                writer.WritePropertyName(prop.Key);
                prop.Value.WriteTo(writer, options);
            }
        }

        writer.WriteEndObject();
    }

    /// <summary>
    /// To convert a JSON string into an object
    /// </summary>
    /// <param name="reader">JSON reader</param>
    /// <param name="typeToConvert">Object type to convert</param>
    /// <param name="options">Serializer options</param>
    /// <returns>The object converted from the JSON string</returns>
    public override EstimateRatesRequestBody Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var jsonDoc = JsonDocument.ParseValue(ref reader);
        EstimateRatesRequestBody newEstimateRatesRequestBody = null;

        int match = 0;
        var matchedTypes = new List<string>();

        try
        {
            newEstimateRatesRequestBody = new EstimateRatesRequestBody(JsonSerializer.Deserialize<RateEstimateByCarrierId>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("RateEstimateByCarrierId");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RateEstimateByCarrierId: {1}", jsonDoc, exception.ToString()));
        }

        try
        {
            newEstimateRatesRequestBody = new EstimateRatesRequestBody(JsonSerializer.Deserialize<RateEstimateByCarrierIds>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("RateEstimateByCarrierIds");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RateEstimateByCarrierIds: {1}", jsonDoc, exception.ToString()));
        }

        if (match == 0)
        {
            throw new InvalidDataException("The JSON string `" + jsonDoc + "` cannot be deserialized into any schema defined.");
        }

        if (match > 1)
        {
            throw new InvalidDataException("The JSON string `" + jsonDoc + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
        }

        newEstimateRatesRequestBody.FromCountryCode = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("from_country_code"), DeserializingOptions);
        newEstimateRatesRequestBody.FromPostalCode = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("from_postal_code"), DeserializingOptions);
        newEstimateRatesRequestBody.FromCityLocality = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("from_city_locality"), DeserializingOptions);
        newEstimateRatesRequestBody.FromStateProvince = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("from_state_province"), DeserializingOptions);
        newEstimateRatesRequestBody.ToCountryCode = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("to_country_code"), DeserializingOptions);
        newEstimateRatesRequestBody.ToPostalCode = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("to_postal_code"), DeserializingOptions);
        newEstimateRatesRequestBody.ToCityLocality = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("to_city_locality"), DeserializingOptions);
        newEstimateRatesRequestBody.ToStateProvince = JsonSerializer.Deserialize<string>(jsonDoc.RootElement.GetProperty("to_state_province"), DeserializingOptions);
        newEstimateRatesRequestBody.Weight = JsonSerializer.Deserialize<Weight>(jsonDoc.RootElement.GetProperty("weight"), DeserializingOptions);
        newEstimateRatesRequestBody.Dimensions = JsonSerializer.Deserialize<Dimensions>(jsonDoc.RootElement.GetProperty("dimensions"), DeserializingOptions);
        newEstimateRatesRequestBody.Confirmation = JsonSerializer.Deserialize<DeliveryConfirmation>(jsonDoc.RootElement.GetProperty("confirmation"), DeserializingOptions);
        newEstimateRatesRequestBody.AddressResidentialIndicator = JsonSerializer.Deserialize<AddressResidentialIndicator>(jsonDoc.RootElement.GetProperty("address_residential_indicator"), DeserializingOptions);
        newEstimateRatesRequestBody.ShipDate = JsonSerializer.Deserialize<DateTime>(jsonDoc.RootElement.GetProperty("ship_date"), DeserializingOptions);

        // deserialization is considered successful at this point if no exception has been thrown.
        return newEstimateRatesRequestBody;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return typeof(EstimateRatesRequestBody).IsAssignableFrom(objectType);
    }
}