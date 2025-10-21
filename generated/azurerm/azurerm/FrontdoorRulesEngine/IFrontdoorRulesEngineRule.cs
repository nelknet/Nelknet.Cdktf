using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorRulesEngine
{
    [JsiiInterface(nativeType: typeof(IFrontdoorRulesEngineRule), fullyQualifiedName: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRule")]
    public interface IFrontdoorRulesEngineRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#name FrontdoorRulesEngine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#priority FrontdoorRulesEngine#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#action FrontdoorRulesEngine#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>match_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#match_condition FrontdoorRulesEngine#match_condition}
        /// </remarks>
        [JsiiProperty(name: "matchCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleMatchCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorRulesEngineRule), fullyQualifiedName: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#name FrontdoorRulesEngine#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#priority FrontdoorRulesEngine#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#action FrontdoorRulesEngine#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction\"}", isOptional: true)]
            public azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction? Action
            {
                get => GetInstanceProperty<azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction?>();
            }

            /// <summary>match_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#match_condition FrontdoorRulesEngine#match_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleMatchCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchCondition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
