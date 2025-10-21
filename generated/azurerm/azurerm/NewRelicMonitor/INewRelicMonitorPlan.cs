using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    [JsiiInterface(nativeType: typeof(INewRelicMonitorPlan), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorPlan")]
    public interface INewRelicMonitorPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#effective_date NewRelicMonitor#effective_date}.</summary>
        [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"string\"}")]
        string EffectiveDate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#billing_cycle NewRelicMonitor#billing_cycle}.</summary>
        [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingCycle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#plan_id NewRelicMonitor#plan_id}.</summary>
        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlanId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#usage_type NewRelicMonitor#usage_type}.</summary>
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INewRelicMonitorPlan), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorPlan")]
        internal sealed class _Proxy : DeputyBase, azurerm.NewRelicMonitor.INewRelicMonitorPlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#effective_date NewRelicMonitor#effective_date}.</summary>
            [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"string\"}")]
            public string EffectiveDate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#billing_cycle NewRelicMonitor#billing_cycle}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingCycle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#plan_id NewRelicMonitor#plan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlanId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#usage_type NewRelicMonitor#usage_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
