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
/// A list label response body
/// </summary>
public partial class ListLabelsResponseBody
{

    public class ListLabelsResponseBodyItem
    {
        /// <summary>
        /// A string that uniquely identifies the label. This ID is generated by ShipEngine when the label is created. 
        /// </summary>
        /// <value>A string that uniquely identifies the label. This ID is generated by ShipEngine when the label is created. </value>
        /// <example>
        /// se-28529731
        /// </example>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public LabelStatus Status { get; set; }

        /// <summary>
        /// The shipment that this label is for.  ShipEngine can create a shipment for you automatically when you [create a label](https://www.shipengine.com/docs/labels/create-a-label/), or you can [create your own shipment](https://www.shipengine.com/docs/shipping/create-a-shipment/) and then [use it to print a label](https://www.shipengine.com/docs/labels/create-from-shipment/) 
        /// </summary>
        /// <value>The shipment that this label is for.  ShipEngine can create a shipment for you automatically when you [create a label](https://www.shipengine.com/docs/labels/create-a-label/), or you can [create your own shipment](https://www.shipengine.com/docs/shipping/create-a-shipment/) and then [use it to print a label](https://www.shipengine.com/docs/labels/create-from-shipment/) </value>
        /// <example>
        /// se-28529731
        /// </example>
        [JsonPropertyName("shipment_id")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The shipment information used to generate the label
        /// </summary>
        /// <value>The shipment information used to generate the label</value>
        [JsonPropertyName("shipment")]
        public Shipment Shipment { get; set; }

        /// <summary>
        /// The date that the package was (or will be) shippped.  ShipEngine will take the day of week into consideration. For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead. 
        /// </summary>
        /// <value>The date that the package was (or will be) shippped.  ShipEngine will take the day of week into consideration. For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead. </value>
        /// <example>
        /// 2018-09-23T00:00Z
        /// </example>
        [JsonPropertyName("ship_date")]
        public DateTime ShipDate { get; set; }

        /// <summary>
        /// The date and time that the label was created in ShipEngine.
        /// </summary>
        /// <value>The date and time that the label was created in ShipEngine.</value>
        /// <example>
        /// 2018-09-23T15:00Z
        /// </example>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The cost of shipping, delivery confirmation, and other carrier charges.  This amount **does not** include insurance costs. 
        /// </summary>
        /// <value>The cost of shipping, delivery confirmation, and other carrier charges.  This amount **does not** include insurance costs. </value>
        [JsonPropertyName("shipment_cost")]
        public MonetaryValue ShipmentCost { get; set; }

        /// <summary>
        /// The insurance cost for this package.  Add this to the &#x60;shipment_cost&#x60; field to get the total cost. 
        /// </summary>
        /// <value>The insurance cost for this package.  Add this to the &#x60;shipment_cost&#x60; field to get the total cost. </value>
        [JsonPropertyName("insurance_cost")]
        public MonetaryValue InsuranceCost { get; set; }

        /// <summary>
        /// The total shipping cost for the specified comparison_rate_type. 
        /// </summary>
        /// <value>The total shipping cost for the specified comparison_rate_type. </value>
        [JsonPropertyName("requested_comparison_amount")]
        public MonetaryValue RequestedComparisonAmount { get; set; }

        /// <summary>
        /// The tracking number for the package. Tracking number formats vary across carriers.
        /// </summary>
        /// <value>The tracking number for the package. Tracking number formats vary across carriers.</value>
        /// <example>
        /// 782758401696
        /// </example>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Indicates whether this is a return label.  You may also want to set the &#x60;rma_number&#x60; so you know what is being returned. 
        /// </summary>
        /// <value>Indicates whether this is a return label.  You may also want to set the &#x60;rma_number&#x60; so you know what is being returned. </value>
        [JsonPropertyName("is_return_label")]
        public bool IsReturnLabel { get; set; }

        /// <summary>
        /// An optional Return Merchandise Authorization number.  This field is useful for return labels.  You can set it to any string value. 
        /// </summary>
        /// <value>An optional Return Merchandise Authorization number.  This field is useful for return labels.  You can set it to any string value. </value>
        [JsonPropertyName("rma_number")]
        public string? RmaNumber { get; set; }

        /// <summary>
        /// Indicates whether this is an international shipment.  That is, the originating country and destination country are different. 
        /// </summary>
        /// <value>Indicates whether this is an international shipment.  That is, the originating country and destination country are different. </value>
        [JsonPropertyName("is_international")]
        public bool IsInternational { get; set; }

        /// <summary>
        /// If this label was created as part of a [batch](https://www.shipengine.com/docs/labels/bulk/), then this is the unique ID of that batch. 
        /// </summary>
        /// <value>If this label was created as part of a [batch](https://www.shipengine.com/docs/labels/bulk/), then this is the unique ID of that batch. </value>
        /// <example>
        /// se-28529731
        /// </example>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// The unique ID of the [carrier account](https://www.shipengine.com/docs/carriers/setup/) that was used to create this label 
        /// </summary>
        /// <value>The unique ID of the [carrier account](https://www.shipengine.com/docs/carriers/setup/) that was used to create this label </value>
        /// <example>
        /// se-28529731
        /// </example>
        [JsonPropertyName("carrier_id")]
        public string CarrierId { get; set; }

        /// <summary>
        /// The label charge event. 
        /// </summary>
        /// <value>The label charge event. </value>
        [JsonPropertyName("charge_event")]
        public LabelChargeEvent ChargeEvent { get; set; }

        /// <summary>
        /// The &#x60;label_id&#x60; of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers. 
        /// </summary>
        /// <value>The &#x60;label_id&#x60; of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers. </value>
        /// <example>
        /// se-28529731
        /// </example>
        [JsonPropertyName("outbound_label_id")]
        public string OutboundLabelId { get; set; }

        /// <summary>
        /// The [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) used to ship the package, such as &#x60;fedex_ground&#x60;, &#x60;usps_first_class_mail&#x60;, &#x60;flat_rate_envelope&#x60;, etc. 
        /// </summary>
        /// <value>The [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) used to ship the package, such as &#x60;fedex_ground&#x60;, &#x60;usps_first_class_mail&#x60;, &#x60;flat_rate_envelope&#x60;, etc. </value>
        /// <example>
        /// usps_first_class_mail
        /// </example>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Indicate if this label is being used only for testing purposes. If true, then no charge will be added to your account.
        /// </summary>
        /// <value>Indicate if this label is being used only for testing purposes. If true, then no charge will be added to your account.</value>
        [JsonPropertyName("test_label")]
        [Obsolete]
        public bool TestLabel { get; set; }

        /// <summary>
        /// The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. 
        /// </summary>
        /// <value>The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. </value>
        /// <example>
        /// small_flat_rate_box
        /// </example>
        [JsonPropertyName("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// Gets or Sets ValidateAddress
        /// </summary>
        [JsonPropertyName("validate_address")]
        public ValidateAddress ValidateAddress { get; set; }

        /// <summary>
        /// Indicates whether the label has been [voided](https://www.shipengine.com/docs/labels/voiding/) 
        /// </summary>
        /// <value>Indicates whether the label has been [voided](https://www.shipengine.com/docs/labels/voiding/) </value>
        [JsonPropertyName("voided")]
        public bool Voided { get; set; }

        /// <summary>
        /// The date and time that the label was [voided](https://www.shipengine.com/docs/labels/voiding/), or &#x60;null&#x60; if the label has not been voided 
        /// </summary>
        /// <value>The date and time that the label was [voided](https://www.shipengine.com/docs/labels/voiding/), or &#x60;null&#x60; if the label has not been voided </value>
        /// <example>
        /// 2018-09-23T15:00Z
        /// </example>
        [JsonPropertyName("voided_at")]
        public DateTime? VoidedAt { get; set; }

        /// <summary>
        /// Gets or Sets LabelDownloadType
        /// </summary>
        [JsonPropertyName("label_download_type")]
        public LabelDownloadType LabelDownloadType { get; set; }

        /// <summary>
        /// The file format that you want the label to be in.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats. 
        /// </summary>
        /// <value>The file format that you want the label to be in.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats. </value>
        [JsonPropertyName("label_format")]
        public LabelFormat LabelFormat { get; set; }

        /// <summary>
        /// The display format that the label should be shown in.
        /// </summary>
        /// <value>The display format that the label should be shown in.</value>
        [JsonPropertyName("display_scheme")]
        public DisplayScheme DisplayScheme { get; set; }

        /// <summary>
        /// The layout (size) that you want the label to be in.  The &#x60;label_format&#x60; determines which sizes are allowed.  &#x60;4x6&#x60; is supported for all label formats, whereas &#x60;letter&#x60; (8.5\&quot; x 11\&quot;) is only supported for &#x60;pdf&#x60; format. 
        /// </summary>
        /// <value>The layout (size) that you want the label to be in.  The &#x60;label_format&#x60; determines which sizes are allowed.  &#x60;4x6&#x60; is supported for all label formats, whereas &#x60;letter&#x60; (8.5\&quot; x 11\&quot;) is only supported for &#x60;pdf&#x60; format. </value>
        [JsonPropertyName("label_layout")]
        public LabelLayout LabelLayout { get; set; }

        /// <summary>
        /// Indicates whether the shipment is trackable, in which case the &#x60;tracking_status&#x60; field will reflect the current status and each package will have a &#x60;tracking_number&#x60;. 
        /// </summary>
        /// <value>Indicates whether the shipment is trackable, in which case the &#x60;tracking_status&#x60; field will reflect the current status and each package will have a &#x60;tracking_number&#x60;. </value>
        [JsonPropertyName("trackable")]
        public bool Trackable { get; set; }

        /// <summary>
        /// The label image resource that was used to create a custom label image.
        /// </summary>
        /// <value>The label image resource that was used to create a custom label image.</value>
        /// <example>
        /// img_DtBXupDBxREpHnwEXhTfgK
        /// </example>
        [JsonPropertyName("label_image_id")]
        public string? LabelImageId { get; set; }

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
        /// The current status of the package, such as &#x60;in_transit&#x60; or &#x60;delivered&#x60;
        /// </summary>
        /// <value>The current status of the package, such as &#x60;in_transit&#x60; or &#x60;delivered&#x60;</value>
        [JsonPropertyName("tracking_status")]
        public TrackingStatus TrackingStatus { get; set; }

        /// <summary>
        /// Gets or Sets LabelDownload
        /// </summary>
        [JsonPropertyName("label_download")]
        public LabelDownload LabelDownload { get; set; }

        /// <summary>
        /// The link to download the customs form (a.k.a. commercial invoice) for this shipment, if any.  Forms are in PDF format. This field is null if the shipment does not require a customs form, or if the carrier does not support it. 
        /// </summary>
        /// <value>The link to download the customs form (a.k.a. commercial invoice) for this shipment, if any.  Forms are in PDF format. This field is null if the shipment does not require a customs form, or if the carrier does not support it. </value>
        [JsonPropertyName("form_download")]
        public Link? FormDownload { get; set; }

        /// <summary>
        /// The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;. 
        /// </summary>
        /// <value>The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;. </value>
        [JsonPropertyName("paperless_download")]
        public PaperlessDownload? PaperlessDownload { get; set; }

        /// <summary>
        /// The link to submit an insurance claim for the shipment.  This field is null if the shipment is not insured or if the insurance provider does not support online claim submission. 
        /// </summary>
        /// <value>The link to submit an insurance claim for the shipment.  This field is null if the shipment is not insured or if the insurance provider does not support online claim submission. </value>
        [JsonPropertyName("insurance_claim")]
        public Link? InsuranceClaim { get; set; }

        /// <summary>
        /// The label&#39;s package(s).  &gt; **Note:** Some carriers only allow one package per label.  If you attempt to create a multi-package label for a carrier that doesn&#39;t allow it, an error will be returned. 
        /// </summary>
        /// <value>The label&#39;s package(s).  &gt; **Note:** Some carriers only allow one package per label.  If you attempt to create a multi-package label for a carrier that doesn&#39;t allow it, an error will be returned. </value>
        [JsonPropertyName("packages")]
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Additional information some carriers may provide by which to identify a given label in their system.  
        /// </summary>
        /// <value>Additional information some carriers may provide by which to identify a given label in their system.  </value>
        [JsonPropertyName("alternative_identifiers")]
        public List<AlternativeIdentifier>? AlternativeIdentifiers { get; set; }

        /// <summary>
        /// The URL to track the package. This URL is provided by the carrier and is unique to the tracking number. 
        /// </summary>
        /// <value>The URL to track the package. This URL is provided by the carrier and is unique to the tracking number. </value>
        /// <example>
        /// https://www.fedex.com/fedextrack/?action&#x3D;track&amp;trackingnumber&#x3D;1234
        /// </example>
        [JsonPropertyName("tracking_url")]
        public string? TrackingUrl { get; set; }

    }
    /// <summary>
    /// The labels that matched the query criteria.  If no matching labels were found, then this array is empty; otherwise, it contains one page of results.  The last page of results may have fewer labels than the &#x60;page_size&#x60;. 
    /// </summary>
    /// <value>The labels that matched the query criteria.  If no matching labels were found, then this array is empty; otherwise, it contains one page of results.  The last page of results may have fewer labels than the &#x60;page_size&#x60;. </value>
    [JsonPropertyName("labels")]
    [JsonRequired]
    public List<ListLabelsResponseBodyItem> Labels { get; set; }

    /// <summary>
    /// The total number of items across all pages of results
    /// </summary>
    /// <value>The total number of items across all pages of results</value>
    /// <example>
    /// 2750
    /// </example>
    [JsonPropertyName("total")]
    [JsonRequired]
    public int Total { get; set; }

    /// <summary>
    /// The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.
    /// </summary>
    /// <value>The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("page")]
    [JsonRequired]
    public int Page { get; set; }

    /// <summary>
    /// The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero.
    /// </summary>
    /// <value>The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero.</value>
    /// <example>
    /// 4
    /// </example>
    [JsonPropertyName("pages")]
    [JsonRequired]
    public int Pages { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [JsonPropertyName("links")]
    [JsonRequired]
    public PaginationLink Links { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ListLabelsResponseBody {\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
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