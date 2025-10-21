using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointGlobalDeliveryRule), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRule")]
    public interface ICdnEndpointGlobalDeliveryRule
    {
        /// <summary>cache_expiration_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_expiration_action CdnEndpoint#cache_expiration_action}
        /// </remarks>
        [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction? CacheExpirationAction
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
        [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction
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
        [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModifyResponseHeaderAction
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
        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction? UrlRedirectAction
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
        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction? UrlRewriteAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointGlobalDeliveryRule), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cache_expiration_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_expiration_action CdnEndpoint#cache_expiration_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction? CacheExpirationAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction?>();
            }

            /// <summary>cache_key_query_string_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_key_query_string_action CdnEndpoint#cache_key_query_string_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction?>();
            }

            /// <summary>modify_request_header_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_request_header_action CdnEndpoint#modify_request_header_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModifyRequestHeaderAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>modify_response_header_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_response_header_action CdnEndpoint#modify_response_header_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModifyResponseHeaderAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_redirect_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_redirect_action CdnEndpoint#url_redirect_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction? UrlRedirectAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction?>();
            }

            /// <summary>url_rewrite_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_rewrite_action CdnEndpoint#url_rewrite_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
            public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction? UrlRewriteAction
            {
                get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction?>();
            }
        }
    }
}
