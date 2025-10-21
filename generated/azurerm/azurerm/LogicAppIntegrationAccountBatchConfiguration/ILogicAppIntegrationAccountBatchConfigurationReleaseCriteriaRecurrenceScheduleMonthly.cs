using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppIntegrationAccountBatchConfiguration
{
    [JsiiInterface(nativeType: typeof(ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly), fullyQualifiedName: "azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly")]
    public interface ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#week LogicAppIntegrationAccountBatchConfiguration#week}.</summary>
        [JsiiProperty(name: "week", typeJson: "{\"primitive\":\"number\"}")]
        double Week
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#weekday LogicAppIntegrationAccountBatchConfiguration#weekday}.</summary>
        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
        string Weekday
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly), fullyQualifiedName: "azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#week LogicAppIntegrationAccountBatchConfiguration#week}.</summary>
            [JsiiProperty(name: "week", typeJson: "{\"primitive\":\"number\"}")]
            public double Week
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#weekday LogicAppIntegrationAccountBatchConfiguration#weekday}.</summary>
            [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
            public string Weekday
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
