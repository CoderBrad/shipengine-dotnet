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
/// A track event
/// </summary>
public partial class TrackEvent
{

    /// <summary>
    /// Gets or Sets StatusCode  CLOVUS
    /// </summary>
    [JsonPropertyName("status_code")]
    [JsonRequired]
    public StatusCode StatusCode { get; set; } = new();


    /// <summary>
    /// Timestamp for carrier event
    /// </summary>
    /// <value>Timestamp for carrier event</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("occurred_at")]
    [JsonRequired]
    public DateTime OccurredAt { get; set; }

    /// <summary>
    /// Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.
    /// </summary>
    /// <value>Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("carrier_occurred_at")]
    public DateTime CarrierOccurredAt { get; set; }

    /// <summary>
    /// Event description
    /// </summary>
    /// <value>Event description</value>
    /// <example>
    /// Delivered, In/At Mailbox
    /// </example>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// City locality
    /// </summary>
    /// <value>City locality</value>
    /// <example>
    /// AUSTIN
    /// </example>
    [JsonPropertyName("city_locality")]
    [JsonRequired]
    public string CityLocality { get; set; }

    /// <summary>
    /// State province
    /// </summary>
    /// <value>State province</value>
    /// <example>
    /// TX
    /// </example>
    [JsonPropertyName("state_province")]
    [JsonRequired]
    public string StateProvince { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    /// <example>
    /// 78756
    /// </example>
    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public string PostalCode { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Company Name
    /// </summary>
    /// <value>Company Name</value>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Signer information
    /// </summary>
    /// <value>Signer information</value>
    [JsonPropertyName("signer")]
    public string Signer { get; set; }

    /// <summary>
    /// Event Code
    /// </summary>
    /// <value>Event Code</value>
    [JsonPropertyName("event_code")]
    public string EventCode { get; set; }

    /// <summary>
    /// Carrier detail code
    /// </summary>
    /// <value>Carrier detail code</value>
    /// <example>
    /// OT
    /// </example>
    [JsonPropertyName("carrier_detail_code")]
    [JsonRequired]
    public string CarrierDetailCode { get; set; }

    /// <summary>
    /// Event Status Description
    /// </summary>
    /// <value>Event Status Description</value>
    /// <example>
    /// In Transit
    /// </example>
    [JsonPropertyName("status_description")]
    [JsonRequired]
    public string StatusDescription { get; set; }

    /// <summary>
    /// Carrier status code
    /// </summary>
    /// <value>Carrier status code</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("carrier_status_code")]
    [JsonRequired]
    public string CarrierStatusCode { get; set; }

    /// <summary>
    /// carrier status description
    /// </summary>
    /// <value>carrier status description</value>
    /// <example>
    /// Your item was delivered in or at the mailbox at 9:10 am on March
    /// </example>
    [JsonPropertyName("carrier_status_description")]
    [JsonRequired]
    public string CarrierStatusDescription { get; set; }

    /// <summary>
    /// Latitude coordinate of tracking event.
    /// </summary>
    /// <value>Latitude coordinate of tracking event.</value>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate of tracking event.
    /// </summary>
    /// <value>Longitude coordinate of tracking event.</value>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class TrackEvent {\n");
        sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
        sb.Append("  CarrierOccurredAt: ").Append(CarrierOccurredAt).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CityLocality: ").Append(CityLocality).Append("\n");
        sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  Signer: ").Append(Signer).Append("\n");
        sb.Append("  EventCode: ").Append(EventCode).Append("\n");
        sb.Append("  CarrierDetailCode: ").Append(CarrierDetailCode).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
        sb.Append("  CarrierStatusCode: ").Append(CarrierStatusCode).Append("\n");
        sb.Append("  CarrierStatusDescription: ").Append(CarrierStatusDescription).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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