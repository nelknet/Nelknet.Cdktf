using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppIntegrationAccountBatchConfiguration
{
    [JsiiInterface(nativeType: typeof(ILogicAppIntegrationAccountBatchConfigurationReleaseCriteria), fullyQualifiedName: "azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteria")]
    public interface ILogicAppIntegrationAccountBatchConfigurationReleaseCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#batch_size LogicAppIntegrationAccountBatchConfiguration#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#message_count LogicAppIntegrationAccountBatchConfiguration#message_count}.</summary>
        [JsiiProperty(name: "messageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessageCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#recurrence LogicAppIntegrationAccountBatchConfiguration#recurrence}
        /// </remarks>
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence? Recurrence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppIntegrationAccountBatchConfigurationReleaseCriteria), fullyQualifiedName: "azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteria")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#batch_size LogicAppIntegrationAccountBatchConfiguration#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#message_count LogicAppIntegrationAccountBatchConfiguration#message_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessageCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>recurrence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#recurrence LogicAppIntegrationAccountBatchConfiguration#recurrence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence\"}", isOptional: true)]
            public azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence? Recurrence
            {
                get => GetInstanceProperty<azurerm.LogicAppIntegrationAccountBatchConfiguration.ILogicAppIntegrationAccountBatchConfigurationReleaseCriteriaRecurrence?>();
            }
        }
    }
}
