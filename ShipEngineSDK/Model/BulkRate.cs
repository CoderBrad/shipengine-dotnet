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
/// A bulk rate
/// </summary>
public partial class BulkRate
{

    /// <summary>
    /// Gets or Sets Status  CLOVUS
    /// </summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public RateResponseStatus Status { get; set; } = new();


    /// <summary>
    /// A string that uniquely identifies the rate request
    /// </summary>
    /// <value>A string that uniquely identifies the rate request</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("rate_request_id")]
    [JsonRequired]
    public string RateRequestId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the shipment
    /// </summary>
    /// <value>A string that uniquely identifies the shipment</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipment_id")]
    [JsonRequired]
    public string ShipmentId { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at")]
    [JsonRequired]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// An array of errors that were returned while retrieving the bulk rate
    /// </summary>
    /// <value>An array of errors that were returned while retrieving the bulk rate</value>
    [JsonPropertyName("errors")]
    [JsonRequired]
    public List<Error> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BulkRate {\n");
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