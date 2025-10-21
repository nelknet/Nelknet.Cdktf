using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointDeliveryRule), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointDeliveryRule")]
    public interface ICdnEndpointDeliveryRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#name CdnEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#order CdnEndpoint#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        double Order
        {
            get;
        }

        /// <summary>cache_expiration_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_expiration_action CdnEndpoint#cache_expiration_action}
        /// </remarks>
        [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction? CacheExpirationAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache_key_query_string_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_key_query_string_action CdnEndpoint#cache_key_query_string_action}
        /// </remarks>
        [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>cookies_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cookies_condition CdnEndpoint#cookies_condition}
        /// </remarks>
        [JsiiProperty(name: "cookiesCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CookiesCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>device_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#device_condition CdnEndpoint#device_condition}
        /// </remarks>
        [JsiiProperty(name: "deviceCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleDeviceCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition? DeviceCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_version_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#http_version_condition CdnEndpoint#http_version_condition}
        /// </remarks>
        [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpVersionCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>modify_request_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_request_header_action CdnEndpoint#modify_request_header_action}
        /// </remarks>
        [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModifyRequestHeaderAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>modify_response_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_response_header_action CdnEndpoint#modify_response_header_action}
        /// </remarks>
        [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModifyResponseHeaderAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>post_arg_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#post_arg_condition CdnEndpoint#post_arg_condition}
        /// </remarks>
        [JsiiProperty(name: "postArgCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRulePostArgCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostArgCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#query_string_condition CdnEndpoint#query_string_condition}
        /// </remarks>
        [JsiiProperty(name: "queryStringCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryStringCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>remote_address_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#remote_address_condition CdnEndpoint#remote_address_condition}
        /// </remarks>
        [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemoteAddressCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_body_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_body_condition CdnEndpoint#request_body_condition}
        /// </remarks>
        [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestBodyCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_header_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_header_condition CdnEndpoint#request_header_condition}
        /// </remarks>
        [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestHeaderCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_method_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_method_condition CdnEndpoint#request_method_condition}
        /// </remarks>
        [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestMethodCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition? RequestMethodCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_scheme_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_scheme_condition CdnEndpoint#request_scheme_condition}
        /// </remarks>
        [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition? RequestSchemeCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_uri_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_uri_condition CdnEndpoint#request_uri_condition}
        /// </remarks>
        [JsiiProperty(name: "requestUriCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestUriCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_file_extension_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_file_extension_condition CdnEndpoint#url_file_extension_condition}
        /// </remarks>
        [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlFileExtensionCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_file_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_file_name_condition CdnEndpoint#url_file_name_condition}
        /// </remarks>
        [JsiiProperty(name: "urlFileNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlFileNameCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_path_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_path_condition CdnEndpoint#url_path_condition}
        /// </remarks>
        [JsiiProperty(name: "urlPathCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlPathCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_redirect_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_redirect_action CdnEndpoint#url_redirect_action}
        /// </remarks>
        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction? UrlRedirectAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_rewrite_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_rewrite_action CdnEndpoint#url_rewrite_action}
        /// </remarks>
        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction? UrlRewriteAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointDeliveryRule), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointDeliveryRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpoint.ICdnEndpointDeliveryRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#name CdnEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#order CdnEndpoint#order}.</summary>
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
            public double Order
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>cache_expiration_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_expiration_action CdnEndpoint#cache_expiration_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction? CacheExpirationAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction?>();
            }

            /// <summary>cache_key_query_string_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_key_query_string_action CdnEndpoint#cache_key_query_string_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction?>();
            }

            /// <summary>cookies_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cookies_condition CdnEndpoint#cookies_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookiesCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CookiesCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>device_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#device_condition CdnEndpoint#device_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleDeviceCondition\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition? DeviceCondition
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition?>();
            }

            /// <summary>http_version_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#http_version_condition CdnEndpoint#http_version_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpVersionCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>modify_request_header_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_request_header_action CdnEndpoint#modify_request_header_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModifyRequestHeaderAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>modify_response_header_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_response_header_action CdnEndpoint#modify_response_header_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModifyResponseHeaderAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>post_arg_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#post_arg_condition CdnEndpoint#post_arg_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postArgCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRulePostArgCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostArgCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_string_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#query_string_condition CdnEndpoint#query_string_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryStringCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryStringCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>remote_address_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#remote_address_condition CdnEndpoint#remote_address_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RemoteAddressCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_body_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_body_condition CdnEndpoint#request_body_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestBodyCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_header_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_header_condition CdnEndpoint#request_header_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestHeaderCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_method_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_method_condition CdnEndpoint#request_method_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestMethodCondition\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition? RequestMethodCondition
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition?>();
            }

            /// <summary>request_scheme_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_scheme_condition CdnEndpoint#request_scheme_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeCondition\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition? RequestSchemeCondition
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition?>();
            }

            /// <summary>request_uri_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_uri_condition CdnEndpoint#request_uri_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestUriCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestUriCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_file_extension_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_file_extension_condition CdnEndpoint#url_file_extension_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlFileExtensionCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_file_name_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_file_name_condition CdnEndpoint#url_file_name_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlFileNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlFileNameCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_path_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_path_condition CdnEndpoint#url_path_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlPathCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlPathCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_redirect_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_redirect_action CdnEndpoint#url_redirect_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction? UrlRedirectAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction?>();
            }

            /// <summary>url_rewrite_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_rewrite_action CdnEndpoint#url_rewrite_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction? UrlRewriteAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction?>();
            }
        }
    }
}
