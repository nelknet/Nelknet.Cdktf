using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiByValue(fqn: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActions")]
    public class CdnFrontdoorRuleActions : azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions
    {
        private object? _requestHeaderAction;

        /// <summary>request_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#request_header_action CdnFrontdoorRule#request_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestHeaderAction
        {
            get => _requestHeaderAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRequestHeaderAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRequestHeaderAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestHeaderAction = value;
            }
        }

        private object? _responseHeaderAction;

        /// <summary>response_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#response_header_action CdnFrontdoorRule#response_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeaderAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseHeaderAction
        {
            get => _responseHeaderAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsResponseHeaderAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsResponseHeaderAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseHeaderAction = value;
            }
        }

        /// <summary>route_configuration_override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#route_configuration_override_action CdnFrontdoorRule#route_configuration_override_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeConfigurationOverrideAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideAction\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideAction? RouteConfigurationOverrideAction
        {
            get;
            set;
        }

        /// <summary>url_redirect_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_redirect_action CdnFrontdoorRule#url_redirect_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectAction\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction? UrlRedirectAction
        {
            get;
            set;
        }

        /// <summary>url_rewrite_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#url_rewrite_action CdnFrontdoorRule#url_rewrite_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewriteAction\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewriteAction? UrlRewriteAction
        {
            get;
            set;
        }
    }
}
