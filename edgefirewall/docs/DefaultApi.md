# edgefirewall.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeFirewallGet**](DefaultApi.md#edgefirewallget) | **GET** /edge_firewall | List all user edge firewall |
| [**EdgeFirewallPost**](DefaultApi.md#edgefirewallpost) | **POST** /edge_firewall | Create a edge firewall |
| [**EdgeFirewallUuidDelete**](DefaultApi.md#edgefirewalluuiddelete) | **DELETE** /edge_firewall/{uuid} | Delete an edge firewall by uuid |
| [**EdgeFirewallUuidGet**](DefaultApi.md#edgefirewalluuidget) | **GET** /edge_firewall/{uuid} | Retrieve an edge firewall set by uuid |
| [**EdgeFirewallUuidPatch**](DefaultApi.md#edgefirewalluuidpatch) | **PATCH** /edge_firewall/{uuid} | Update some edge firewall attributes, like \&quot;active\&quot; |
| [**EdgeFirewallUuidPut**](DefaultApi.md#edgefirewalluuidput) | **PUT** /edge_firewall/{uuid} | Overwrite some edge firewall attributes, like \&quot;active\&quot; |

<a id="edgefirewallget"></a>
# **EdgeFirewallGet**
> ListEdgeFirewallResponse EdgeFirewallGet (int? page = null, int? pageSize = null, string sort = null, string orderBy = null)

List all user edge firewall

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 

            try
            {
                // List all user edge firewall
                ListEdgeFirewallResponse result = apiInstance.EdgeFirewallGet(page, pageSize, sort, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all user edge firewall
    ApiResponse<ListEdgeFirewallResponse> response = apiInstance.EdgeFirewallGetWithHttpInfo(page, pageSize, sort, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |

### Return type

[**ListEdgeFirewallResponse**](ListEdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of edge firewalls |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewallpost"></a>
# **EdgeFirewallPost**
> void EdgeFirewallPost (CreateEdgeFirewallRequest createEdgeFirewallRequest)

Create a edge firewall

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createEdgeFirewallRequest = new CreateEdgeFirewallRequest(); // CreateEdgeFirewallRequest | 

            try
            {
                // Create a edge firewall
                apiInstance.EdgeFirewallPost(createEdgeFirewallRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a edge firewall
    apiInstance.EdgeFirewallPostWithHttpInfo(createEdgeFirewallRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEdgeFirewallRequest** | [**CreateEdgeFirewallRequest**](CreateEdgeFirewallRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Edge firewall created |  -  |
| **400** | Internal Server Error |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuiddelete"></a>
# **EdgeFirewallUuidDelete**
> void EdgeFirewallUuidDelete (string uuid)

Delete an edge firewall by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // Delete an edge firewall by uuid
                apiInstance.EdgeFirewallUuidDelete(uuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an edge firewall by uuid
    apiInstance.EdgeFirewallUuidDeleteWithHttpInfo(uuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully deleted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuidget"></a>
# **EdgeFirewallUuidGet**
> EdgeFirewallResponse EdgeFirewallUuidGet (string uuid)

Retrieve an edge firewall set by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // Retrieve an edge firewall set by uuid
                EdgeFirewallResponse result = apiInstance.EdgeFirewallUuidGet(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an edge firewall set by uuid
    ApiResponse<EdgeFirewallResponse> response = apiInstance.EdgeFirewallUuidGetWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

### Return type

[**EdgeFirewallResponse**](EdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An edge firewall object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuidpatch"></a>
# **EdgeFirewallUuidPatch**
> ListEdgeFirewallResponse EdgeFirewallUuidPatch (string uuid, ListEdgeFirewallResponse body)

Update some edge firewall attributes, like \"active\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 
            var body = new ListEdgeFirewallResponse();  // ListEdgeFirewallResponse | 

            try
            {
                // Update some edge firewall attributes, like \"active\"
                ListEdgeFirewallResponse result = apiInstance.EdgeFirewallUuidPatch(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update some edge firewall attributes, like \"active\"
    ApiResponse<ListEdgeFirewallResponse> response = apiInstance.EdgeFirewallUuidPatchWithHttpInfo(uuid, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
| **body** | **ListEdgeFirewallResponse** |  |  |

### Return type

[**ListEdgeFirewallResponse**](ListEdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuidput"></a>
# **EdgeFirewallUuidPut**
> ListEdgeFirewallResponse EdgeFirewallUuidPut (string uuid, ListEdgeFirewallResponse body)

Overwrite some edge firewall attributes, like \"active\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 
            var body = new ListEdgeFirewallResponse();  // ListEdgeFirewallResponse | 

            try
            {
                // Overwrite some edge firewall attributes, like \"active\"
                ListEdgeFirewallResponse result = apiInstance.EdgeFirewallUuidPut(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite some edge firewall attributes, like \"active\"
    ApiResponse<ListEdgeFirewallResponse> response = apiInstance.EdgeFirewallUuidPutWithHttpInfo(uuid, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
| **body** | **ListEdgeFirewallResponse** |  |  |

### Return type

[**ListEdgeFirewallResponse**](ListEdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

