using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiByValue(fqn: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions")]
    public class CdnFrontdoorRuleConditions : azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions
    {
        private object? _clientPortCondition;

        /// <summary>client_port_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#client_port_condition CdnFrontdoorRule#client_port_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientPortCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClientPortCondition
        {
            get => _clientPortCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPortCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPortCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clientPortCondition = value;
            }
        }

        private object? _cookiesCondition;

        /// <summary>cookies_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#cookies_condition CdnFrontdoorRule#cookies_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsCookiesCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsCookiesCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cookiesCondition = value;
            }
        }

        private object? _hostNameCondition;

        /// <summary>host_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#host_name_condition CdnFrontdoorRule#host_name_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HostNameCondition
        {
            get => _hostNameCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostNameCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostNameCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostNameCondition = value;
            }
        }

        private object? _httpVersionCondition;

        /// <summary>http_version_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#http_version_condition CdnFrontdoorRule#http_version_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersionCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersionCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpVersionCondition = value;
            }
        }

        private object? _isDeviceCondition;

        /// <summary>is_device_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#is_device_condition CdnFrontdoorRule#is_device_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDeviceCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IsDeviceCondition
        {
            get => _isDeviceCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsIsDeviceCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsIsDeviceCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDeviceCondition = value;
            }
        }

        private object? _postArgsCondition;

        /// <summary>post_args_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#post_args_condition CdnFrontdoorRule#post_args_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postArgsCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PostArgsCondition
        {
            get => _postArgsCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgsCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgsCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _postArgsCondition = value;
            }
        }

        private object? _queryStringCondition;

        /// <summary>query_string_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#query_string_condition CdnFrontdoorRule#query_string_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryStringCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryStringCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryStringCondition = value;
            }
        }

        private object? _remoteAddressCondition;

        /// <summary>remote_address_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#remote_address_condition CdnFrontdoorRule#remote_address_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddressCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddressCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _remoteAddressCondition = value;
            }
        }

        private object? _requestBodyCondition;

        /// <summary>request_body_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_body_condition CdnFrontdoorRule#request_body_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBodyCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBodyCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestBodyCondition = value;
            }
        }

        private object? _requestHeaderCondition;

        /// <summary>request_header_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_header_condition CdnFrontdoorRule#request_header_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeaderCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeaderCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestHeaderCondition = value;
            }
        }

        private object? _requestMethodCondition;

        /// <summary>request_method_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_method_condition CdnFrontdoorRule#request_method_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestMethodCondition
        {
            get => _requestMethodCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethodCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethodCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestMethodCondition = value;
            }
        }

        private object? _requestSchemeCondition;

        /// <summary>request_scheme_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_scheme_condition CdnFrontdoorRule#request_scheme_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestSchemeCondition
        {
            get => _requestSchemeCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestSchemeCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestSchemeCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestSchemeCondition = value;
            }
        }

        private object? _requestUriCondition;

        /// <summary>request_uri_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_uri_condition CdnFrontdoorRule#request_uri_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestUriCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUriCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUriCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestUriCondition = value;
            }
        }

        private object? _serverPortCondition;

        /// <summary>server_port_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#server_port_condition CdnFrontdoorRule#server_port_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverPortCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServerPortCondition
        {
            get => _serverPortCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPortCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPortCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serverPortCondition = value;
            }
        }

        private object? _socketAddressCondition;

        /// <summary>socket_address_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#socket_address_condition CdnFrontdoorRule#socket_address_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "socketAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SocketAddressCondition
        {
            get => _socketAddressCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddressCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddressCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _socketAddressCondition = value;
            }
        }

        private object? _sslProtocolCondition;

        /// <summary>ssl_protocol_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#ssl_protocol_condition CdnFrontdoorRule#ssl_protocol_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslProtocolCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SslProtocolCondition
        {
            get => _sslProtocolCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocolCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocolCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sslProtocolCondition = value;
            }
        }

        private object? _urlFileExtensionCondition;

        /// <summary>url_file_extension_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_file_extension_condition CdnFrontdoorRule#url_file_extension_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFileExtensionCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFileExtensionCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlFileExtensionCondition = value;
            }
        }

        private object? _urlFilenameCondition;

        /// <summary>url_filename_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_filename_condition CdnFrontdoorRule#url_filename_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlFilenameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlFilenameCondition
        {
            get => _urlFilenameCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFilenameCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFilenameCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlFilenameCondition = value;
            }
        }

        private object? _urlPathCondition;

        /// <summary>url_path_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_path_condition CdnFrontdoorRule#url_path_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlPathCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlPathCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlPathCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlPathCondition = value;
            }
        }
    }
}
