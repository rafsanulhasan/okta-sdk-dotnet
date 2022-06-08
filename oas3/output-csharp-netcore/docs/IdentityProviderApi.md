# Okta.Sdk.Api.IdentityProviderApi

All URIs are relative to *https://your-subdomain.okta.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateIdentityProvider**](IdentityProviderApi.md#activateidentityprovider) | **POST** /api/v1/idps/{idpId}/lifecycle/activate | Activate Identity Provider
[**CloneIdentityProviderKey**](IdentityProviderApi.md#cloneidentityproviderkey) | **POST** /api/v1/idps/{idpId}/credentials/keys/{keyId}/clone | Clone Signing Key Credential for IdP
[**CreateIdentityProvider**](IdentityProviderApi.md#createidentityprovider) | **POST** /api/v1/idps | Add Identity Provider
[**CreateIdentityProviderKey**](IdentityProviderApi.md#createidentityproviderkey) | **POST** /api/v1/idps/credentials/keys | Add X.509 Certificate Public Key for Identity Providers
[**DeactivateIdentityProvider**](IdentityProviderApi.md#deactivateidentityprovider) | **POST** /api/v1/idps/{idpId}/lifecycle/deactivate | Deactivate Identity Provider
[**DeleteIdentityProvider**](IdentityProviderApi.md#deleteidentityprovider) | **DELETE** /api/v1/idps/{idpId} | Delete Identity Provider
[**DeleteIdentityProviderKey**](IdentityProviderApi.md#deleteidentityproviderkey) | **DELETE** /api/v1/idps/credentials/keys/{keyId} | Delete Key
[**GenerateCsrForIdentityProvider**](IdentityProviderApi.md#generatecsrforidentityprovider) | **POST** /api/v1/idps/{idpId}/credentials/csrs | Generate Certificate Signing Request for IdP
[**GenerateIdentityProviderSigningKey**](IdentityProviderApi.md#generateidentityprovidersigningkey) | **POST** /api/v1/idps/{idpId}/credentials/keys/generate | Generate New IdP Signing Key Credential
[**GetCsrForIdentityProvider**](IdentityProviderApi.md#getcsrforidentityprovider) | **GET** /api/v1/idps/{idpId}/credentials/csrs/{csrId} | Get Csr for Identity Provider
[**GetIdentityProvider**](IdentityProviderApi.md#getidentityprovider) | **GET** /api/v1/idps/{idpId} | Get Identity Provider
[**GetIdentityProviderApplicationUser**](IdentityProviderApi.md#getidentityproviderapplicationuser) | **GET** /api/v1/idps/{idpId}/users/{userId} | Get Identity Provider Application User
[**GetIdentityProviderKey**](IdentityProviderApi.md#getidentityproviderkey) | **GET** /api/v1/idps/credentials/keys/{keyId} | Get Identity Provider Key
[**GetIdentityProviderSigningKey**](IdentityProviderApi.md#getidentityprovidersigningkey) | **GET** /api/v1/idps/{idpId}/credentials/keys/{keyId} | Get Signing Key Credential for IdP
[**LinkUserToIdentityProvider**](IdentityProviderApi.md#linkusertoidentityprovider) | **POST** /api/v1/idps/{idpId}/users/{userId} | Link a user to a Social IdP without a transaction
[**ListCsrsForIdentityProvider**](IdentityProviderApi.md#listcsrsforidentityprovider) | **GET** /api/v1/idps/{idpId}/credentials/csrs | List Certificate Signing Requests for IdP
[**ListIdentityProviderApplicationUsers**](IdentityProviderApi.md#listidentityproviderapplicationusers) | **GET** /api/v1/idps/{idpId}/users | Find Users
[**ListIdentityProviderKeys**](IdentityProviderApi.md#listidentityproviderkeys) | **GET** /api/v1/idps/credentials/keys | List Identity Provider Keys
[**ListIdentityProviderSigningKeys**](IdentityProviderApi.md#listidentityprovidersigningkeys) | **GET** /api/v1/idps/{idpId}/credentials/keys | List Signing Key Credentials for IdP
[**ListIdentityProviders**](IdentityProviderApi.md#listidentityproviders) | **GET** /api/v1/idps | List Identity Providers
[**ListSocialAuthTokens**](IdentityProviderApi.md#listsocialauthtokens) | **GET** /api/v1/idps/{idpId}/users/{userId}/credentials/tokens | Social Authentication Token Operation
[**PublishCsrForIdentityProvider**](IdentityProviderApi.md#publishcsrforidentityprovider) | **POST** /api/v1/idps/{idpId}/credentials/csrs/{csrId}/lifecycle/publish | Publish Csr for Identity Provider
[**RevokeCsrForIdentityProvider**](IdentityProviderApi.md#revokecsrforidentityprovider) | **DELETE** /api/v1/idps/{idpId}/credentials/csrs/{csrId} | Revoke Csr for Identity Provider
[**UnlinkUserFromIdentityProvider**](IdentityProviderApi.md#unlinkuserfromidentityprovider) | **DELETE** /api/v1/idps/{idpId}/users/{userId} | Unlink User from IdP
[**UpdateIdentityProvider**](IdentityProviderApi.md#updateidentityprovider) | **PUT** /api/v1/idps/{idpId} | Update Identity Provider


<a name="activateidentityprovider"></a>
# **ActivateIdentityProvider**
> IdentityProvider ActivateIdentityProvider (string idpId)

Activate Identity Provider

Activates an inactive IdP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // Activate Identity Provider
                IdentityProvider result = apiInstance.ActivateIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ActivateIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloneidentityproviderkey"></a>
# **CloneIdentityProviderKey**
> JsonWebKey CloneIdentityProviderKey (string idpId, string keyId, string targetIdpId)

Clone Signing Key Credential for IdP

Clones a X.509 certificate for an IdP signing key credential from a source IdP to target IdP

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CloneIdentityProviderKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var keyId = "keyId_example";  // string | 
            var targetIdpId = "targetIdpId_example";  // string | 

            try
            {
                // Clone Signing Key Credential for IdP
                JsonWebKey result = apiInstance.CloneIdentityProviderKey(idpId, keyId, targetIdpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.CloneIdentityProviderKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **keyId** | **string**|  | 
 **targetIdpId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createidentityprovider"></a>
# **CreateIdentityProvider**
> IdentityProvider CreateIdentityProvider (IdentityProvider identityProvider)

Add Identity Provider

Adds a new IdP to your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var identityProvider = new IdentityProvider(); // IdentityProvider | 

            try
            {
                // Add Identity Provider
                IdentityProvider result = apiInstance.CreateIdentityProvider(identityProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.CreateIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityProvider** | [**IdentityProvider**](IdentityProvider.md)|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createidentityproviderkey"></a>
# **CreateIdentityProviderKey**
> JsonWebKey CreateIdentityProviderKey (JsonWebKey jsonWebKey)

Add X.509 Certificate Public Key for Identity Providers

Adds a new X.509 certificate credential to the IdP key store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateIdentityProviderKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var jsonWebKey = new JsonWebKey(); // JsonWebKey | 

            try
            {
                // Add X.509 Certificate Public Key for Identity Providers
                JsonWebKey result = apiInstance.CreateIdentityProviderKey(jsonWebKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.CreateIdentityProviderKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jsonWebKey** | [**JsonWebKey**](JsonWebKey.md)|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deactivateidentityprovider"></a>
# **DeactivateIdentityProvider**
> IdentityProvider DeactivateIdentityProvider (string idpId)

Deactivate Identity Provider

Deactivates an active IdP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // Deactivate Identity Provider
                IdentityProvider result = apiInstance.DeactivateIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeactivateIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteidentityprovider"></a>
# **DeleteIdentityProvider**
> void DeleteIdentityProvider (string idpId)

Delete Identity Provider

Removes an IdP from your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // Delete Identity Provider
                apiInstance.DeleteIdentityProvider(idpId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteidentityproviderkey"></a>
# **DeleteIdentityProviderKey**
> void DeleteIdentityProviderKey (string keyId)

Delete Key

Deletes a specific IdP Key Credential by `kid` if it is not currently being used by an Active or Inactive IdP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteIdentityProviderKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var keyId = "keyId_example";  // string | 

            try
            {
                // Delete Key
                apiInstance.DeleteIdentityProviderKey(keyId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityProviderKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatecsrforidentityprovider"></a>
# **GenerateCsrForIdentityProvider**
> Csr GenerateCsrForIdentityProvider (string idpId, CsrMetadata metadata)

Generate Certificate Signing Request for IdP

Generates a new key pair and returns a Certificate Signing Request for it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GenerateCsrForIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var metadata = new CsrMetadata(); // CsrMetadata | 

            try
            {
                // Generate Certificate Signing Request for IdP
                Csr result = apiInstance.GenerateCsrForIdentityProvider(idpId, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GenerateCsrForIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **metadata** | [**CsrMetadata**](CsrMetadata.md)|  | 

### Return type

[**Csr**](Csr.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateidentityprovidersigningkey"></a>
# **GenerateIdentityProviderSigningKey**
> JsonWebKey GenerateIdentityProviderSigningKey (string idpId, int validityYears)

Generate New IdP Signing Key Credential

Generates a new X.509 certificate for an IdP signing key credential to be used for signing assertions sent to the IdP

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GenerateIdentityProviderSigningKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var validityYears = 56;  // int | expiry of the IdP Key Credential

            try
            {
                // Generate New IdP Signing Key Credential
                JsonWebKey result = apiInstance.GenerateIdentityProviderSigningKey(idpId, validityYears);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GenerateIdentityProviderSigningKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **validityYears** | **int**| expiry of the IdP Key Credential | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcsrforidentityprovider"></a>
# **GetCsrForIdentityProvider**
> Csr GetCsrForIdentityProvider (string idpId, string csrId)

Get Csr for Identity Provider

Gets a specific Certificate Signing Request model by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetCsrForIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var csrId = "csrId_example";  // string | 

            try
            {
                // Get Csr for Identity Provider
                Csr result = apiInstance.GetCsrForIdentityProvider(idpId, csrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetCsrForIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

[**Csr**](Csr.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentityprovider"></a>
# **GetIdentityProvider**
> IdentityProvider GetIdentityProvider (string idpId)

Get Identity Provider

Fetches an IdP by `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // Get Identity Provider
                IdentityProvider result = apiInstance.GetIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentityproviderapplicationuser"></a>
# **GetIdentityProviderApplicationUser**
> IdentityProviderApplicationUser GetIdentityProviderApplicationUser (string idpId, string userId)

Get Identity Provider Application User

Fetches a linked IdP user by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderApplicationUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Get Identity Provider Application User
                IdentityProviderApplicationUser result = apiInstance.GetIdentityProviderApplicationUser(idpId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProviderApplicationUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**IdentityProviderApplicationUser**](IdentityProviderApplicationUser.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentityproviderkey"></a>
# **GetIdentityProviderKey**
> JsonWebKey GetIdentityProviderKey (string keyId)

Get Identity Provider Key

Gets a specific IdP Key Credential by `kid`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var keyId = "keyId_example";  // string | 

            try
            {
                // Get Identity Provider Key
                JsonWebKey result = apiInstance.GetIdentityProviderKey(keyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProviderKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentityprovidersigningkey"></a>
# **GetIdentityProviderSigningKey**
> JsonWebKey GetIdentityProviderSigningKey (string idpId, string keyId)

Get Signing Key Credential for IdP

Gets a specific IdP Key Credential by `kid`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderSigningKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var keyId = "keyId_example";  // string | 

            try
            {
                // Get Signing Key Credential for IdP
                JsonWebKey result = apiInstance.GetIdentityProviderSigningKey(idpId, keyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProviderSigningKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **keyId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkusertoidentityprovider"></a>
# **LinkUserToIdentityProvider**
> IdentityProviderApplicationUser LinkUserToIdentityProvider (string idpId, string userId, UserIdentityProviderLinkRequest userIdentityProviderLinkRequest)

Link a user to a Social IdP without a transaction

Links an Okta user to an existing Social Identity Provider. This does not support the SAML2 Identity Provider Type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class LinkUserToIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var userId = "userId_example";  // string | 
            var userIdentityProviderLinkRequest = new UserIdentityProviderLinkRequest(); // UserIdentityProviderLinkRequest | 

            try
            {
                // Link a user to a Social IdP without a transaction
                IdentityProviderApplicationUser result = apiInstance.LinkUserToIdentityProvider(idpId, userId, userIdentityProviderLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.LinkUserToIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 
 **userIdentityProviderLinkRequest** | [**UserIdentityProviderLinkRequest**](UserIdentityProviderLinkRequest.md)|  | 

### Return type

[**IdentityProviderApplicationUser**](IdentityProviderApplicationUser.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcsrsforidentityprovider"></a>
# **ListCsrsForIdentityProvider**
> List&lt;Csr&gt; ListCsrsForIdentityProvider (string idpId)

List Certificate Signing Requests for IdP

Enumerates Certificate Signing Requests for an IdP

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListCsrsForIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // List Certificate Signing Requests for IdP
                List<Csr> result = apiInstance.ListCsrsForIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListCsrsForIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**List&lt;Csr&gt;**](Csr.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listidentityproviderapplicationusers"></a>
# **ListIdentityProviderApplicationUsers**
> List&lt;IdentityProviderApplicationUser&gt; ListIdentityProviderApplicationUsers (string idpId)

Find Users

Find all the users linked to an identity provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProviderApplicationUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // Find Users
                List<IdentityProviderApplicationUser> result = apiInstance.ListIdentityProviderApplicationUsers(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviderApplicationUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**List&lt;IdentityProviderApplicationUser&gt;**](IdentityProviderApplicationUser.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listidentityproviderkeys"></a>
# **ListIdentityProviderKeys**
> List&lt;JsonWebKey&gt; ListIdentityProviderKeys (string after = null, int? limit = null)

List Identity Provider Keys

Enumerates IdP key credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProviderKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var after = "after_example";  // string | Specifies the pagination cursor for the next page of keys (optional) 
            var limit = 20;  // int? | Specifies the number of key results in a page (optional)  (default to 20)

            try
            {
                // List Identity Provider Keys
                List<JsonWebKey> result = apiInstance.ListIdentityProviderKeys(after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviderKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **string**| Specifies the pagination cursor for the next page of keys | [optional] 
 **limit** | **int?**| Specifies the number of key results in a page | [optional] [default to 20]

### Return type

[**List&lt;JsonWebKey&gt;**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listidentityprovidersigningkeys"></a>
# **ListIdentityProviderSigningKeys**
> List&lt;JsonWebKey&gt; ListIdentityProviderSigningKeys (string idpId)

List Signing Key Credentials for IdP

Enumerates signing key credentials for an IdP

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProviderSigningKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 

            try
            {
                // List Signing Key Credentials for IdP
                List<JsonWebKey> result = apiInstance.ListIdentityProviderSigningKeys(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviderSigningKeys: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**List&lt;JsonWebKey&gt;**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listidentityproviders"></a>
# **ListIdentityProviders**
> List&lt;IdentityProvider&gt; ListIdentityProviders (string q = null, string after = null, int? limit = null, string type = null)

List Identity Providers

Enumerates IdPs in your organization with pagination. A subset of IdPs can be returned that match a supported filter expression or query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var q = "q_example";  // string | Searches the name property of IdPs for matching value (optional) 
            var after = "after_example";  // string | Specifies the pagination cursor for the next page of IdPs (optional) 
            var limit = 20;  // int? | Specifies the number of IdP results in a page (optional)  (default to 20)
            var type = "type_example";  // string | Filters IdPs by type (optional) 

            try
            {
                // List Identity Providers
                List<IdentityProvider> result = apiInstance.ListIdentityProviders(q, after, limit, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Searches the name property of IdPs for matching value | [optional] 
 **after** | **string**| Specifies the pagination cursor for the next page of IdPs | [optional] 
 **limit** | **int?**| Specifies the number of IdP results in a page | [optional] [default to 20]
 **type** | **string**| Filters IdPs by type | [optional] 

### Return type

[**List&lt;IdentityProvider&gt;**](IdentityProvider.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsocialauthtokens"></a>
# **ListSocialAuthTokens**
> List&lt;SocialAuthToken&gt; ListSocialAuthTokens (string idpId, string userId)

Social Authentication Token Operation

Fetches the tokens minted by the Social Authentication Provider when the user authenticates with Okta via Social Auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListSocialAuthTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Social Authentication Token Operation
                List<SocialAuthToken> result = apiInstance.ListSocialAuthTokens(idpId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListSocialAuthTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**List&lt;SocialAuthToken&gt;**](SocialAuthToken.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishcsrforidentityprovider"></a>
# **PublishCsrForIdentityProvider**
> JsonWebKey PublishCsrForIdentityProvider (string idpId, string csrId, System.IO.Stream body)

Publish Csr for Identity Provider

Update the Certificate Signing Request with a signed X.509 certificate and add it into the signing key credentials for the IdP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PublishCsrForIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var csrId = "csrId_example";  // string | 
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Publish Csr for Identity Provider
                JsonWebKey result = apiInstance.PublishCsrForIdentityProvider(idpId, csrId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PublishCsrForIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **csrId** | **string**|  | 
 **body** | **System.IO.Stream****System.IO.Stream**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: application/x-x509-ca-cert, application/pkix-cert, application/x-pem-file
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokecsrforidentityprovider"></a>
# **RevokeCsrForIdentityProvider**
> void RevokeCsrForIdentityProvider (string idpId, string csrId)

Revoke Csr for Identity Provider

Revoke a Certificate Signing Request and delete the key pair from the IdP

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeCsrForIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var csrId = "csrId_example";  // string | 

            try
            {
                // Revoke Csr for Identity Provider
                apiInstance.RevokeCsrForIdentityProvider(idpId, csrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.RevokeCsrForIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlinkuserfromidentityprovider"></a>
# **UnlinkUserFromIdentityProvider**
> void UnlinkUserFromIdentityProvider (string idpId, string userId)

Unlink User from IdP

Removes the link between the Okta user and the IdP user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnlinkUserFromIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Unlink User from IdP
                apiInstance.UnlinkUserFromIdentityProvider(idpId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.UnlinkUserFromIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateidentityprovider"></a>
# **UpdateIdentityProvider**
> IdentityProvider UpdateIdentityProvider (string idpId, IdentityProvider identityProvider)

Update Identity Provider

Updates the configuration for an IdP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-subdomain.okta.com";
            // Configure API key authorization: API Token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: OAuth 2.0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var idpId = "idpId_example";  // string | 
            var identityProvider = new IdentityProvider(); // IdentityProvider | 

            try
            {
                // Update Identity Provider
                IdentityProvider result = apiInstance.UpdateIdentityProvider(idpId, identityProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.UpdateIdentityProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **identityProvider** | [**IdentityProvider**](IdentityProvider.md)|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[API Token](../README.md#API Token), [OAuth 2.0](../README.md#OAuth 2.0)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
