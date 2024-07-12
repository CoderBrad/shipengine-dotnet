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
    /// Download File Get File
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="subdir"></param>
    /// <param name="filename"></param>
    /// <param name="dir"></param>
    /// <param name="download"> (optional)</param>
    /// <param name="rotation"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
    Task<System.IO.Stream> DownloadFile(string subdir, string filename, string dir, string download, int? rotation, CancellationToken cancellationToken = default);

    /// <summary>
    /// Download File Get File
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="subdir"></param>
    /// <param name="filename"></param>
    /// <param name="dir"></param>
    /// <param name="download"> (optional)</param>
    /// <param name="rotation"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
    Task<System.IO.Stream> DownloadFile(HttpClient methodClient, string subdir, string filename, string dir, string download, int? rotation, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Download File Get File
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="subdir"></param>
    /// <param name="filename"></param>
    /// <param name="dir"></param>
    /// <param name="download"> (optional)</param>
    /// <param name="rotation"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
    public Task<System.IO.Stream> DownloadFile(string subdir, string filename, string dir, string download = default, int? rotation = default, CancellationToken cancellationToken = default)
    {
        return DownloadFile(_client, subdir, filename, dir, download, rotation, cancellationToken);
    }

    /// <summary>
    /// Download File Get File
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="subdir"></param>
    /// <param name="filename"></param>
    /// <param name="dir"></param>
    /// <param name="download"> (optional)</param>
    /// <param name="rotation"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
    public async Task<System.IO.Stream> DownloadFile(HttpClient methodClient, string subdir, string filename, string dir, string download = default, int? rotation = default, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'subdir' is set
        if (subdir == null)
        {
            throw new ArgumentNullException(nameof(subdir));
        }

        // verify the required parameter 'filename' is set
        if (filename == null)
        {
            throw new ArgumentNullException(nameof(filename));
        }

        // verify the required parameter 'dir' is set
        if (dir == null)
        {
            throw new ArgumentNullException(nameof(dir));
        }


        RequestOptions requestOptions = new("/v1/downloads/{dir}/{subdir}/{filename}");

        requestOptions.PathParameters.Add("subdir", ShipEngineSDK.ClientUtils.ParameterToString(subdir)); // path parameter
        requestOptions.PathParameters.Add("filename", ShipEngineSDK.ClientUtils.ParameterToString(filename)); // path parameter
        requestOptions.PathParameters.Add("dir", ShipEngineSDK.ClientUtils.ParameterToString(dir)); // path parameter
        if (download != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "download", download));
        }
        if (rotation != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "rotation", rotation));
        }

        requestOptions.Operation = "DownloadsApi.DownloadFile";

        var result = await SendHttpRequestAsync<System.IO.Stream>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

}