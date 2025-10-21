using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppIntegrationAccountBatchConfiguration
{
    [JsiiByValue(fqn: "azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteria")]
    public class LogicAppIntegrationAccountBatchConfigurationReleaseCriteria : azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#batch_size LogicAppIntegrationAccountBatchConfiguration#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#message_count LogicAppIntegrationAccountBatchConfiguration#message_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MessageCount
        {
            get;
            set;
        }

        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#recurrence LogicAppIntegrationAccountBatchConfiguration#recurrence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence\"}", isOptional: true)]
        public azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence? Recurrence
        {
            get;
            set;
        }
    }
}
