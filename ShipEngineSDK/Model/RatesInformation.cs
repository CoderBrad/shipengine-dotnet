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
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// A rates information resource
/// </summary>
public partial class RatesInformation
{

    /// <summary>
    /// Gets or Sets Status  CLOVUS
    /// </summary>
    [JsonPropertyName("status")]
    public RateResponseStatus? Status { get; set; }
    /// <summary>
    /// An array of shipment rates
    /// </summary>
    /// <value>An array of shipment rates</value>
    [JsonPropertyName("rates")]
    public List<Rate> Rates { get; set; }

    /// <summary>
    /// An array of invalid shipment rates
    /// </summary>
    /// <value>An array of invalid shipment rates</value>
    [JsonPropertyName("invalid_rates")]
    public List<Rate> InvalidRates { get; set; }

    /// <summary>
    /// A string that uniquely identifies the rate request
    /// </summary>
    /// <value>A string that uniquely identifies the rate request</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("rate_request_id")]
    public string RateRequestId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the shipment
    /// </summary>
    /// <value>A string that uniquely identifies the shipment</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipment_id")]
    public string ShipmentId { get; set; }

    /// <summary>
    /// When the rate was created
    /// </summary>
    /// <value>When the rate was created</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [JsonPropertyName("errors")]
    public List<Error> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class RatesInformation {\n");
        sb.Append("  Rates: ").Append(Rates).Append("\n");
        sb.Append("  InvalidRates: ").Append(InvalidRates).Append("\n");
        sb.Append("  RateRequestId: ").Append(RateRequestId).Append("\n");
        sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }

}