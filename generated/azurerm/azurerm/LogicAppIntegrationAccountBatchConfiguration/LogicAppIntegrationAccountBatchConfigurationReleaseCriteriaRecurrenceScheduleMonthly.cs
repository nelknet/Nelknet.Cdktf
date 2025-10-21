using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppIntegrationAccountBatchConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly")]
    public class LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly : azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrenceScheduleMonthly
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#week LogicAppIntegrationAccountBatchConfiguration#week}.</summary>
        [JsiiProperty(name: "week", typeJson: "{\"primitive\":\"number\"}")]
        public double Week
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#weekday LogicAppIntegrationAccountBatchConfiguration#weekday}.</summary>
        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
        public string Weekday
        {
            get;
            set;
        }
    }
}
