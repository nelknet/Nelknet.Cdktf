using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorRulesEngine
{
    [JsiiInterface(nativeType: typeof(IFrontdoorRulesEngineRuleAction), fullyQualifiedName: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction")]
    public interface IFrontdoorRulesEngineRuleAction
    {
        /// <summary>request_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#request_header FrontdoorRulesEngine#request_header}
        /// </remarks>
        [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#response_header FrontdoorRulesEngine#response_header}
        /// </remarks>
        [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResponseHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorRulesEngineRuleAction), fullyQualifiedName: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>request_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#request_header FrontdoorRulesEngine#request_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>response_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#response_header FrontdoorRulesEngine#response_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResponseHeader
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
