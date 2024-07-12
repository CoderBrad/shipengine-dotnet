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
/// The parsed shipment, as well as a confidence score and a list of all the shipping entities that were recognized in the text. 
/// </summary>
public partial class ParseShipmentResponseBody
{

    /// <summary>
    /// A confidence score between zero and one that indicates how certain the API is that it understood the text. 
    /// </summary>
    /// <value>A confidence score between zero and one that indicates how certain the API is that it understood the text. </value>
    [JsonPropertyName("score")]
    [JsonRequired]
    public double Score { get; set; }

    /// <summary>
    /// The parsed shipment.  This shipment may not be complete, depending on how much information was included in the text and how confident the API is about each recognized entity.  &gt; **Note:** The shipment-recognition API does not currently perform any validation of the parsed addresses, so we recommend that you use the [address-validation API](https://www.shipengine.com/docs/addresses/validation/) to ensure that the addresses are correct. 
    /// </summary>
    /// <value>The parsed shipment.  This shipment may not be complete, depending on how much information was included in the text and how confident the API is about each recognized entity.  &gt; **Note:** The shipment-recognition API does not currently perform any validation of the parsed addresses, so we recommend that you use the [address-validation API](https://www.shipengine.com/docs/addresses/validation/) to ensure that the addresses are correct. </value>
    [JsonPropertyName("shipment")]
    [JsonRequired]
    public PartialShipment Shipment { get; set; }

    /// <summary>
    /// All of the entities that were recognized in the text. An \&quot;entity\&quot; is a single piece of data, such as a city, a postal code, a carrier name, or a package weight.  Each entity includes the original text and the parsed value. 
    /// </summary>
    /// <value>All of the entities that were recognized in the text. An \&quot;entity\&quot; is a single piece of data, such as a city, a postal code, a carrier name, or a package weight.  Each entity includes the original text and the parsed value. </value>
    [JsonPropertyName("entities")]
    [JsonRequired]
    public List<RecognizedEntity> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ParseShipmentResponseBody {\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  Shipment: ").Append(Shipment).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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