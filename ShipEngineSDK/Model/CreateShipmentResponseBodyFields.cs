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
/// CreateShipmentResponseBodyFields
/// </summary>
public partial class CreateShipmentResponseBodyFields
{

    /// <summary>
    /// An array of errors that occurred while creating shipment.
    /// </summary>
    /// <value>An array of errors that occurred while creating shipment.</value>
    [JsonPropertyName("errors")]
    [Obsolete]
    public List<string> Errors { get; set; }

    /// <summary>
    /// The address validation
    /// </summary>
    /// <value>The address validation</value>
    [JsonPropertyName("address_validation")]
    public AddressValidationResult AddressValidation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateShipmentResponseBodyFields {\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  AddressValidation: ").Append(AddressValidation).Append("\n");
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