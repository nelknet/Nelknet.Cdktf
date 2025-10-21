using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnEndpoint.CdnEndpointDeliveryRule")]
    public class CdnEndpointDeliveryRule : azurerm.CdnEndpoint.ICdnEndpointDeliveryRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#name CdnEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#order CdnEndpoint#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public double Order
        {
            get;
            set;
        }

        /// <summary>cache_expiration_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_expiration_action CdnEndpoint#cache_expiration_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction? CacheExpirationAction
        {
            get;
            set;
        }

        /// <summary>cache_key_query_string_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_key_query_string_action CdnEndpoint#cache_key_query_string_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction
        {
            get;
            set;
        }

        private object? _cookiesCondition;

        /// <summary>cookies_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cookies_condition CdnEndpoint#cookies_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CookiesCondition
        {
            get => _cookiesCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCookiesCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCookiesCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cookiesCondition = value;
            }
        }

        /// <summary>device_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#device_condition CdnEndpoint#device_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleDeviceCondition\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition? DeviceCondition
        {
            get;
            set;
        }

        private object? _httpVersionCondition;

        /// <summary>http_version_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#http_version_condition CdnEndpoint#http_version_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpVersionCondition
        {
            get => _httpVersionCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleHttpVersionCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleHttpVersionCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpVersionCondition = value;
            }
        }

        private object? _modifyRequestHeaderAction;

        /// <summary>modify_request_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_request_header_action CdnEndpoint#modify_request_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModifyRequestHeaderAction
        {
            get => _modifyRequestHeaderAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyRequestHeaderAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyRequestHeaderAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modifyRequestHeaderAction = value;
            }
        }

        private object? _modifyResponseHeaderAction;

        /// <summary>modify_response_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_response_header_action CdnEndpoint#modify_response_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModifyResponseHeaderAction
        {
            get => _modifyResponseHeaderAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyResponseHeaderAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyResponseHeaderAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modifyResponseHeaderAction = value;
            }
        }

        private object? _postArgCondition;

        /// <summary>post_arg_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#post_arg_condition CdnEndpoint#post_arg_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postArgCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRulePostArgCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PostArgCondition
        {
            get => _postArgCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRulePostArgCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRulePostArgCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _postArgCondition = value;
            }
        }

        private object? _queryStringCondition;

        /// <summary>query_string_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#query_string_condition CdnEndpoint#query_string_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryStringCondition
        {
            get => _queryStringCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleQueryStringCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleQueryStringCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryStringCondition = value;
            }
        }

        private object? _remoteAddressCondition;

        /// <summary>remote_address_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#remote_address_condition CdnEndpoint#remote_address_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RemoteAddressCondition
        {
            get => _remoteAddressCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRemoteAddressCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRemoteAddressCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _remoteAddressCondition = value;
            }
        }

        private object? _requestBodyCondition;

        /// <summary>request_body_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_body_condition CdnEndpoint#request_body_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestBodyCondition
        {
            get => _requestBodyCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestBodyCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestBodyCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestBodyCondition = value;
            }
        }

        private object? _requestHeaderCondition;

        /// <summary>request_header_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_header_condition CdnEndpoint#request_header_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestHeaderCondition
        {
            get => _requestHeaderCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestHeaderCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestHeaderCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestHeaderCondition = value;
            }
        }

        /// <summary>request_method_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_method_condition CdnEndpoint#request_method_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestMethodCondition\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition? RequestMethodCondition
        {
            get;
            set;
        }

        /// <summary>request_scheme_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_scheme_condition CdnEndpoint#request_scheme_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeCondition\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition? RequestSchemeCondition
        {
            get;
            set;
        }

        private object? _requestUriCondition;

        /// <summary>request_uri_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#request_uri_condition CdnEndpoint#request_uri_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestUriCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestUriCondition
        {
            get => _requestUriCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestUriCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestUriCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestUriCondition = value;
            }
        }

        private object? _urlFileExtensionCondition;

        /// <summary>url_file_extension_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_file_extension_condition CdnEndpoint#url_file_extension_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlFileExtensionCondition
        {
            get => _urlFileExtensionCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileExtensionCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileExtensionCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlFileExtensionCondition = value;
            }
        }

        private object? _urlFileNameCondition;

        /// <summary>url_file_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_file_name_condition CdnEndpoint#url_file_name_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlFileNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlFileNameCondition
        {
            get => _urlFileNameCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileNameCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileNameCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlFileNameCondition = value;
            }
        }

        private object? _urlPathCondition;

        /// <summary>url_path_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_path_condition CdnEndpoint#url_path_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlPathCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlPathCondition
        {
            get => _urlPathCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlPathCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlPathCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlPathCondition = value;
            }
        }

        /// <summary>url_redirect_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_redirect_action CdnEndpoint#url_redirect_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction? UrlRedirectAction
        {
            get;
            set;
        }

        /// <summary>url_rewrite_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_rewrite_action CdnEndpoint#url_rewrite_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction? UrlRewriteAction
        {
            get;
            set;
        }
    }
}
