# personal_tokens - the C# library for the Personal Tokens - OpenAPI

The Personal Tokens API allows you to manage your existing personal tokens.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using personal_tokens.Api;
using personal_tokens.Client;
using personal_tokens.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using personal_tokens.Api;
using personal_tokens.Client;
using personal_tokens.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PersonalTokenApi(config);
            var createPersonalTokenRequest = new CreatePersonalTokenRequest(); // CreatePersonalTokenRequest | 

            try
            {
                // Create a new personal token
                CreatePersonalTokenResponse result = apiInstance.CreatePersonalToken(createPersonalTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PersonalTokenApi.CreatePersonalToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.azionapi.net*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PersonalTokenApi* | [**CreatePersonalToken**](docs/PersonalTokenApi.md#createpersonaltoken) | **POST** /iam/personal_tokens | Create a new personal token
*PersonalTokenApi* | [**DeletePersonalToken**](docs/PersonalTokenApi.md#deletepersonaltoken) | **DELETE** /iam/personal_tokens/{personalTokenId} | Delete a personal token by id
*PersonalTokenApi* | [**GetPersonalToken**](docs/PersonalTokenApi.md#getpersonaltoken) | **GET** /iam/personal_tokens/{personalTokenId} | Get a personal token info
*PersonalTokenApi* | [**ListPersonalToken**](docs/PersonalTokenApi.md#listpersonaltoken) | **GET** /iam/personal_tokens | List all existing personal token


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.CreatePersonalTokenRequest](docs/CreatePersonalTokenRequest.md)
 - [Model.CreatePersonalTokenResponse](docs/CreatePersonalTokenResponse.md)
 - [Model.PersonalTokenResponseGet](docs/PersonalTokenResponseGet.md)
 - [Model.PersonalTokenResponseWithResults](docs/PersonalTokenResponseWithResults.md)
 - [Model.PersonalTokenResponseWithResultsLinks](docs/PersonalTokenResponseWithResultsLinks.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="tokenAuth"></a>
### tokenAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
