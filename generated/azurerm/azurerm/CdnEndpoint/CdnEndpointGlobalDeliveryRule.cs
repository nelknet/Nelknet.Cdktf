using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiByValue(fqn: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRule")]
    public class CdnEndpointGlobalDeliveryRule : azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRule
    {
        /// <summary>cache_expiration_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_expiration_action CdnEndpoint#cache_expiration_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction? CacheExpirationAction
        {
            get;
            set;
        }

        /// <summary>cache_key_query_string_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#cache_key_query_string_action CdnEndpoint#cache_key_query_string_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction
        {
            get;
            set;
        }

        private object? _modifyRequestHeaderAction;

        /// <summary>modify_request_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#modify_request_header_action CdnEndpoint#modify_request_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
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
        [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modifyResponseHeaderAction = value;
            }
        }

        /// <summary>url_redirect_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_redirect_action CdnEndpoint#url_redirect_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction? UrlRedirectAction
        {
            get;
            set;
        }

        /// <summary>url_rewrite_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#url_rewrite_action CdnEndpoint#url_rewrite_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
        public azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction? UrlRewriteAction
        {
            get;
            set;
        }
    }
}
