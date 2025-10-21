using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorRulesEngine
{
    [JsiiByValue(fqn: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeader")]
    public class FrontdoorRulesEngineRuleActionRequestHeader : azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionRequestHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#header_action_type FrontdoorRulesEngine#header_action_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerActionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderActionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#header_name FrontdoorRulesEngine#header_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#value FrontdoorRulesEngine#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
