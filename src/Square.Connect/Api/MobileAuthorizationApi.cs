/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Square.Connect.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMobileAuthorizationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// CreateMobileAuthorizationCode
        /// </summary>
        /// <remarks>
        /// Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>CreateMobileAuthorizationCodeResponse</returns>
        CreateMobileAuthorizationCodeResponse CreateMobileAuthorizationCode (CreateMobileAuthorizationCodeRequest body);

        /// <summary>
        /// CreateMobileAuthorizationCode
        /// </summary>
        /// <remarks>
        /// Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateMobileAuthorizationCodeResponse</returns>
        ApiResponse<CreateMobileAuthorizationCodeResponse> CreateMobileAuthorizationCodeWithHttpInfo (CreateMobileAuthorizationCodeRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// CreateMobileAuthorizationCode
        /// </summary>
        /// <remarks>
        /// Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of CreateMobileAuthorizationCodeResponse</returns>
        System.Threading.Tasks.Task<CreateMobileAuthorizationCodeResponse> CreateMobileAuthorizationCodeAsync (CreateMobileAuthorizationCodeRequest body);

        /// <summary>
        /// CreateMobileAuthorizationCode
        /// </summary>
        /// <remarks>
        /// Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateMobileAuthorizationCodeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateMobileAuthorizationCodeResponse>> CreateMobileAuthorizationCodeAsyncWithHttpInfo (CreateMobileAuthorizationCodeRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MobileAuthorizationApi : IMobileAuthorizationApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MobileAuthorizationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MobileAuthorizationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Square.Connect.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// CreateMobileAuthorizationCode Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>CreateMobileAuthorizationCodeResponse</returns>
        public CreateMobileAuthorizationCodeResponse CreateMobileAuthorizationCode (CreateMobileAuthorizationCodeRequest body)
        {
             ApiResponse<CreateMobileAuthorizationCodeResponse> localVarResponse = CreateMobileAuthorizationCodeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CreateMobileAuthorizationCode Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateMobileAuthorizationCodeResponse</returns>
        public ApiResponse< CreateMobileAuthorizationCodeResponse > CreateMobileAuthorizationCodeWithHttpInfo (CreateMobileAuthorizationCodeRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobileAuthorizationApi->CreateMobileAuthorizationCode");

            var localVarPath = "/mobile/authorization-code";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2018-09-18");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateMobileAuthorizationCode", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateMobileAuthorizationCodeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateMobileAuthorizationCodeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateMobileAuthorizationCodeResponse)));
            
        }

        /// <summary>
        /// CreateMobileAuthorizationCode Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of CreateMobileAuthorizationCodeResponse</returns>
        public async System.Threading.Tasks.Task<CreateMobileAuthorizationCodeResponse> CreateMobileAuthorizationCodeAsync (CreateMobileAuthorizationCodeRequest body)
        {
             ApiResponse<CreateMobileAuthorizationCodeResponse> localVarResponse = await CreateMobileAuthorizationCodeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CreateMobileAuthorizationCode Generates code to authorize a mobile application to connect to a Square card reader  Authorization codes are one-time-use and expire __60 minutes__ after being issued.  __Important:__ The &#x60;Authorization&#x60; header you provide to this endpoint must have the following format:  &#x60;&#x60;&#x60; Authorization: Bearer ACCESS_TOKEN &#x60;&#x60;&#x60;  Replace &#x60;ACCESS_TOKEN&#x60; with a [valid production authorization credential](https://docs.connect.squareup.com/get-started#step-4-understand-the-different-application-credentials).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateMobileAuthorizationCodeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateMobileAuthorizationCodeResponse>> CreateMobileAuthorizationCodeAsyncWithHttpInfo (CreateMobileAuthorizationCodeRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobileAuthorizationApi->CreateMobileAuthorizationCode");

            var localVarPath = "/mobile/authorization-code";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateMobileAuthorizationCode", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateMobileAuthorizationCodeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateMobileAuthorizationCodeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateMobileAuthorizationCodeResponse)));
            
        }

    }
}
