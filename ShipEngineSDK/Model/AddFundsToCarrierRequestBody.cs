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
/// An add funds to carrier request body
/// </summary>
public partial class AddFundsToCarrierRequestBody
{

    /// <summary>
    /// The currencies that are supported by ShipEngine are the ones that specified by ISO 4217: https://www.iso.org/iso-4217-currency-codes.html 
    /// </summary>
    /// <value>The currencies that are supported by ShipEngine are the ones that specified by ISO 4217: https://www.iso.org/iso-4217-currency-codes.html </value>
    [JsonPropertyName("currency")]
    [JsonRequired]
    public string Currency { get; set; }

    /// <summary>
    /// The monetary amount, in the specified currency.
    /// </summary>
    /// <value>The monetary amount, in the specified currency.</value>
    [JsonPropertyName("amount")]
    [JsonRequired]
    public double Amount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AddFundsToCarrierRequestBody {\n");
        sb.Append("  Currency: ").Append(Currency).Append("\n");
        sb.Append("  Amount: ").Append(Amount).Append("\n");
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