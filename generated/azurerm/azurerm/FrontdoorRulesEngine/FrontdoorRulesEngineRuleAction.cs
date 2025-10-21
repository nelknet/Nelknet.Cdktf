using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorRulesEngine
{
    [JsiiByValue(fqn: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction")]
    public class FrontdoorRulesEngineRuleAction : azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction
    {
        private object? _requestHeader;

        /// <summary>request_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#request_header FrontdoorRulesEngine#request_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestHeader
        {
            get => _requestHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionRequestHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionRequestHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestHeader = value;
            }
        }

        private object? _responseHeader;

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#response_header FrontdoorRulesEngine#response_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseHeader
        {
            get => _responseHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionResponseHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionResponseHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseHeader = value;
            }
        }
    }
}
