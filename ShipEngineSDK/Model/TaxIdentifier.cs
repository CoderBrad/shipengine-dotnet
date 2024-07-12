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
/// A tax identifier object
/// </summary>
public partial class TaxIdentifier
{

    /// <summary>
    /// Gets or Sets TaxableEntityType  CLOVUS
    /// </summary>
    [JsonPropertyName("taxable_entity_type")]
    [JsonRequired]
    public TaxableEntityType TaxableEntityType { get; set; } = new();


    /// <summary>
    /// Gets or Sets IdentifierType  CLOVUS
    /// </summary>
    [JsonPropertyName("identifier_type")]
    [JsonRequired]
    public IdentifierType IdentifierType { get; set; } = new();


    /// <summary>
    /// The authority that issued this tax. This must be a valid 2 character ISO 3166 Alpha 2 country code.
    /// </summary>
    /// <value>The authority that issued this tax. This must be a valid 2 character ISO 3166 Alpha 2 country code.</value>
    [JsonPropertyName("issuing_authority")]
    [JsonRequired]
    public string IssuingAuthority { get; set; }

    /// <summary>
    /// The value of the identifier
    /// </summary>
    /// <value>The value of the identifier</value>
    [JsonPropertyName("value")]
    [JsonRequired]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class TaxIdentifier {\n");
        sb.Append("  TaxableEntityType: ").Append(TaxableEntityType).Append("\n");
        sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
        sb.Append("  IssuingAuthority: ").Append(IssuingAuthority).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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