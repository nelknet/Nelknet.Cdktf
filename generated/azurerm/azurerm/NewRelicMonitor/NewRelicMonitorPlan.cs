using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.newRelicMonitor.NewRelicMonitorPlan")]
    public class NewRelicMonitorPlan : azurerm.NewRelicMonitor.INewRelicMonitorPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#effective_date NewRelicMonitor#effective_date}.</summary>
        [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"string\"}")]
        public string EffectiveDate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#billing_cycle NewRelicMonitor#billing_cycle}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BillingCycle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#plan_id NewRelicMonitor#plan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#usage_type NewRelicMonitor#usage_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageType
        {
            get;
            set;
        }
    }
}
