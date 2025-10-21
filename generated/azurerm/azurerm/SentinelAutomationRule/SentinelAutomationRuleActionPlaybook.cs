using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAutomationRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sentinelAutomationRule.SentinelAutomationRuleActionPlaybook")]
    public class SentinelAutomationRuleActionPlaybook : azurerm.SentinelAutomationRule.ISentinelAutomationRuleActionPlaybook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#logic_app_id SentinelAutomationRule#logic_app_id}.</summary>
        [JsiiProperty(name: "logicAppId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogicAppId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#order SentinelAutomationRule#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public double Order
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#tenant_id SentinelAutomationRule#tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantId
        {
            get;
            set;
        }
    }
}
