using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleConditions), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions")]
    public interface ICdnFrontdoorRuleConditions
    {
        /// <summary>client_port_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#client_port_condition CdnFrontdoorRule#client_port_condition}
        /// </remarks>
        [JsiiProperty(name: "clientPortCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientPortCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>cookies_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#cookies_condition CdnFrontdoorRule#cookies_condition}
        /// </remarks>
        [JsiiProperty(name: "cookiesCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CookiesCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>host_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#host_name_condition CdnFrontdoorRule#host_name_condition}
        /// </remarks>
        [JsiiProperty(name: "hostNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostNameCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_version_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#http_version_condition CdnFrontdoorRule#http_version_condition}
        /// </remarks>
        [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpVersionCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>is_device_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#is_device_condition CdnFrontdoorRule#is_device_condition}
        /// </remarks>
        [JsiiProperty(name: "isDeviceCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDeviceCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>post_args_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#post_args_condition CdnFrontdoorRule#post_args_condition}
        /// </remarks>
        [JsiiProperty(name: "postArgsCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostArgsCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#query_string_condition CdnFrontdoorRule#query_string_condition}
        /// </remarks>
        [JsiiProperty(name: "queryStringCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#remote_address_condition CdnFrontdoorRule#remote_address_condition}
        /// </remarks>
        [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_body_condition CdnFrontdoorRule#request_body_condition}
        /// </remarks>
        [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_header_condition CdnFrontdoorRule#request_header_condition}
        /// </remarks>
        [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_method_condition CdnFrontdoorRule#request_method_condition}
        /// </remarks>
        [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestMethodCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_scheme_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_scheme_condition CdnFrontdoorRule#request_scheme_condition}
        /// </remarks>
        [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestSchemeCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_uri_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_uri_condition CdnFrontdoorRule#request_uri_condition}
        /// </remarks>
        [JsiiProperty(name: "requestUriCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestUriCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_port_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#server_port_condition CdnFrontdoorRule#server_port_condition}
        /// </remarks>
        [JsiiProperty(name: "serverPortCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServerPortCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>socket_address_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#socket_address_condition CdnFrontdoorRule#socket_address_condition}
        /// </remarks>
        [JsiiProperty(name: "socketAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SocketAddressCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_protocol_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#ssl_protocol_condition CdnFrontdoorRule#ssl_protocol_condition}
        /// </remarks>
        [JsiiProperty(name: "sslProtocolCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslProtocolCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_file_extension_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_file_extension_condition CdnFrontdoorRule#url_file_extension_condition}
        /// </remarks>
        [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlFileExtensionCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_filename_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_filename_condition CdnFrontdoorRule#url_filename_condition}
        /// </remarks>
        [JsiiProperty(name: "urlFilenameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlFilenameCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_path_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_path_condition CdnFrontdoorRule#url_path_condition}
        /// </remarks>
        [JsiiProperty(name: "urlPathCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlPathCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleConditions), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_port_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#client_port_condition CdnFrontdoorRule#client_port_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientPortCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClientPortCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cookies_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#cookies_condition CdnFrontdoorRule#cookies_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookiesCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CookiesCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>host_name_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#host_name_condition CdnFrontdoorRule#host_name_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostNameCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_version_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#http_version_condition CdnFrontdoorRule#http_version_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpVersionCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>is_device_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#is_device_condition CdnFrontdoorRule#is_device_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDeviceCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IsDeviceCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>post_args_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#post_args_condition CdnFrontdoorRule#post_args_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postArgsCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostArgsCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_string_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#query_string_condition CdnFrontdoorRule#query_string_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryStringCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryStringCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>remote_address_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#remote_address_condition CdnFrontdoorRule#remote_address_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RemoteAddressCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_body_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_body_condition CdnFrontdoorRule#request_body_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestBodyCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_header_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_header_condition CdnFrontdoorRule#request_header_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestHeaderCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_method_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_method_condition CdnFrontdoorRule#request_method_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestMethodCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_scheme_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_scheme_condition CdnFrontdoorRule#request_scheme_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestSchemeCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_uri_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_uri_condition CdnFrontdoorRule#request_uri_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestUriCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestUriCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>server_port_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#server_port_condition CdnFrontdoorRule#server_port_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverPortCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServerPortCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>socket_address_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#socket_address_condition CdnFrontdoorRule#socket_address_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socketAddressCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SocketAddressCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssl_protocol_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#ssl_protocol_condition CdnFrontdoorRule#ssl_protocol_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslProtocolCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SslProtocolCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_file_extension_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_file_extension_condition CdnFrontdoorRule#url_file_extension_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlFileExtensionCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_filename_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_filename_condition CdnFrontdoorRule#url_filename_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlFilenameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlFilenameCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_path_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_path_condition CdnFrontdoorRule#url_path_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlPathCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlPathCondition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
