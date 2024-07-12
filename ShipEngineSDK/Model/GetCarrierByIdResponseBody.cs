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
/// A get carrier by id response body
/// </summary>
public partial class GetCarrierByIdResponseBody
{

    /// <summary>
    /// A string that uniquely identifies the carrier.
    /// </summary>
    /// <value>A string that uniquely identifies the carrier.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    public string CarrierId { get; set; }

    /// <summary>
    /// The [shipping carrier](https://www.shipengine.com/docs/carriers/setup/) who will ship the package, such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. 
    /// </summary>
    /// <value>The [shipping carrier](https://www.shipengine.com/docs/carriers/setup/) who will ship the package, such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. </value>
    /// <example>
    /// dhl_express
    /// </example>
    [JsonPropertyName("carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// The account number that the carrier is connected to.
    /// </summary>
    /// <value>The account number that the carrier is connected to.</value>
    /// <example>
    /// account_570827
    /// </example>
    [JsonPropertyName("account_number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Indicates whether the carrier requires funding to use its services
    /// </summary>
    /// <value>Indicates whether the carrier requires funding to use its services</value>
    [JsonPropertyName("requires_funded_amount")]
    public bool RequiresFundedAmount { get; set; }

    /// <summary>
    /// Current available balance
    /// </summary>
    /// <value>Current available balance</value>
    /// <example>
    /// 3799.52
    /// </example>
    [JsonPropertyName("balance")]
    public double Balance { get; set; }

    /// <summary>
    /// Nickname given to the account when initially setting up the carrier.
    /// </summary>
    /// <value>Nickname given to the account when initially setting up the carrier.</value>
    /// <example>
    /// ShipEngine Account - Stamps.com
    /// </example>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Screen readable name
    /// </summary>
    /// <value>Screen readable name</value>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("friendly_name")]
    public string FriendlyName { get; set; }

    /// <summary>
    /// Is this the primary carrier that is used by default when no carrier is specified in label/shipment creation
    /// </summary>
    /// <value>Is this the primary carrier that is used by default when no carrier is specified in label/shipment creation</value>
    [JsonPropertyName("primary")]
    public bool Primary { get; set; }

    /// <summary>
    /// Carrier supports multiple packages per shipment
    /// </summary>
    /// <value>Carrier supports multiple packages per shipment</value>
    [JsonPropertyName("has_multi_package_supporting_services")]
    public bool HasMultiPackageSupportingServices { get; set; }

    /// <summary>
    /// The carrier supports adding custom label messages to an order.
    /// </summary>
    /// <value>The carrier supports adding custom label messages to an order.</value>
    [JsonPropertyName("supports_label_messages")]
    public bool SupportsLabelMessages { get; set; }

    /// <summary>
    /// The carrier is disabled by the current ShipEngine account&#39;s billing plan.
    /// </summary>
    /// <value>The carrier is disabled by the current ShipEngine account&#39;s billing plan.</value>
    [JsonPropertyName("disabled_by_billing_plan")]
    public bool DisabledByBillingPlan { get; set; }

    /// <summary>
    /// A list of services that are offered by the carrier
    /// </summary>
    /// <value>A list of services that are offered by the carrier</value>
    [JsonPropertyName("services")]
    public List<Service> Services { get; set; }

    /// <summary>
    /// A list of package types that are supported by the carrier
    /// </summary>
    /// <value>A list of package types that are supported by the carrier</value>
    [JsonPropertyName("packages")]
    public List<PackageType> Packages { get; set; }

    /// <summary>
    /// A list of options that are available to that carrier
    /// </summary>
    /// <value>A list of options that are available to that carrier</value>
    [JsonPropertyName("options")]
    public List<CarrierAdvancedOption> Options { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GetCarrierByIdResponseBody {\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  RequiresFundedAmount: ").Append(RequiresFundedAmount).Append("\n");
        sb.Append("  Balance: ").Append(Balance).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  HasMultiPackageSupportingServices: ").Append(HasMultiPackageSupportingServices).Append("\n");
        sb.Append("  SupportsLabelMessages: ").Append(SupportsLabelMessages).Append("\n");
        sb.Append("  DisabledByBillingPlan: ").Append(DisabledByBillingPlan).Append("\n");
        sb.Append("  Services: ").Append(Services).Append("\n");
        sb.Append("  Packages: ").Append(Packages).Append("\n");
        sb.Append("  Options: ").Append(Options).Append("\n");
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