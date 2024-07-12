/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using ShipEngineSDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ShipEngineSDK;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial interface IShipEngine
{
    /// <summary>
    /// Get Tracking Information Retrieve package tracking information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetTrackingLogResponseBody)</returns>
    Task<GetTrackingLogResponseBody> GetTrackingLog(string carrierCode, string trackingNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Tracking Information Retrieve package tracking information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetTrackingLogResponseBody)</returns>
    Task<GetTrackingLogResponseBody> GetTrackingLog(HttpClient methodClient, string carrierCode, string trackingNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Start Tracking a Package Allows you to subscribe to tracking updates for a package. You specify the carrier_code and tracking_number of the package, and receive notifications via webhooks whenever the shipping status changes. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> StartTracking(string carrierCode, string trackingNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Start Tracking a Package Allows you to subscribe to tracking updates for a package. You specify the carrier_code and tracking_number of the package, and receive notifications via webhooks whenever the shipping status changes. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> StartTracking(HttpClient methodClient, string carrierCode, string trackingNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stop Tracking a Package Unsubscribe from tracking updates for a package.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> StopTracking(string carrierCode, string trackingNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stop Tracking a Package Unsubscribe from tracking updates for a package.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> StopTracking(HttpClient methodClient, string carrierCode, string trackingNumber, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Get Tracking Information Retrieve package tracking information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetTrackingLogResponseBody)</returns>
    public Task<GetTrackingLogResponseBody> GetTrackingLog(string carrierCode = default, string trackingNumber = default, CancellationToken cancellationToken = default)
    {
        return GetTrackingLog(_client, carrierCode, trackingNumber, cancellationToken);
    }

    /// <summary>
    /// Get Tracking Information Retrieve package tracking information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetTrackingLogResponseBody)</returns>
    public async Task<GetTrackingLogResponseBody> GetTrackingLog(HttpClient methodClient, string carrierCode = default, string trackingNumber = default, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/tracking");

        if (carrierCode != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "carrier_code", carrierCode));
        }
        if (trackingNumber != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "tracking_number", trackingNumber));
        }

        requestOptions.Operation = "TrackingApi.GetTrackingLog";

        var result = await SendHttpRequestAsync<GetTrackingLogResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Start Tracking a Package Allows you to subscribe to tracking updates for a package. You specify the carrier_code and tracking_number of the package, and receive notifications via webhooks whenever the shipping status changes. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> StartTracking(string carrierCode = default, string trackingNumber = default, CancellationToken cancellationToken = default)
    {
        return StartTracking(_client, carrierCode, trackingNumber, cancellationToken);
    }

    /// <summary>
    /// Start Tracking a Package Allows you to subscribe to tracking updates for a package. You specify the carrier_code and tracking_number of the package, and receive notifications via webhooks whenever the shipping status changes. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> StartTracking(HttpClient methodClient, string carrierCode = default, string trackingNumber = default, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/tracking/start");

        if (carrierCode != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "carrier_code", carrierCode));
        }
        if (trackingNumber != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "tracking_number", trackingNumber));
        }

        requestOptions.Operation = "TrackingApi.StartTracking";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Post, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Stop Tracking a Package Unsubscribe from tracking updates for a package.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> StopTracking(string carrierCode = default, string trackingNumber = default, CancellationToken cancellationToken = default)
    {
        return StopTracking(_client, carrierCode, trackingNumber, cancellationToken);
    }

    /// <summary>
    /// Stop Tracking a Package Unsubscribe from tracking updates for a package.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierCode">A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  (optional)</param>
    /// <param name="trackingNumber">The tracking number associated with a shipment (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> StopTracking(HttpClient methodClient, string carrierCode = default, string trackingNumber = default, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/tracking/stop");

        if (carrierCode != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "carrier_code", carrierCode));
        }
        if (trackingNumber != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "tracking_number", trackingNumber));
        }

        requestOptions.Operation = "TrackingApi.StopTracking";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Post, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

}