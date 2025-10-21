using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAutomationRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sentinelAutomationRule.SentinelAutomationRuleActionIncident")]
    public class SentinelAutomationRuleActionIncident : azurerm.SentinelAutomationRule.ISentinelAutomationRuleActionIncident
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#order SentinelAutomationRule#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public double Order
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#classification SentinelAutomationRule#classification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Classification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#classification_comment SentinelAutomationRule#classification_comment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classificationComment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClassificationComment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#labels SentinelAutomationRule#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#owner_id SentinelAutomationRule#owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OwnerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#severity SentinelAutomationRule#severity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Severity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#status SentinelAutomationRule#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
