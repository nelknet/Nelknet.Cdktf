using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISentinelAutomationRuleActionPlaybook), fullyQualifiedName: "azurerm.sentinelAutomationRule.SentinelAutomationRuleActionPlaybook")]
    public interface ISentinelAutomationRuleActionPlaybook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#logic_app_id SentinelAutomationRule#logic_app_id}.</summary>
        [JsiiProperty(name: "logicAppId", typeJson: "{\"primitive\":\"string\"}")]
        string LogicAppId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#order SentinelAutomationRule#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        double Order
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#tenant_id SentinelAutomationRule#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAutomationRuleActionPlaybook), fullyQualifiedName: "azurerm.sentinelAutomationRule.SentinelAutomationRuleActionPlaybook")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAutomationRule.ISentinelAutomationRuleActionPlaybook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#logic_app_id SentinelAutomationRule#logic_app_id}.</summary>
            [JsiiProperty(name: "logicAppId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogicAppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#order SentinelAutomationRule#order}.</summary>
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
            public double Order
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#tenant_id SentinelAutomationRule#tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
