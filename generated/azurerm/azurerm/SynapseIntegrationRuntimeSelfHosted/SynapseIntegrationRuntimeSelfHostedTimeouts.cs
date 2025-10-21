using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseIntegrationRuntimeSelfHosted
{
    [JsiiByValue(fqn: "azurerm.synapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHostedTimeouts")]
    public class SynapseIntegrationRuntimeSelfHostedTimeouts : azurerm.SynapseIntegrationRuntimeSelfHosted.ISynapseIntegrationRuntimeSelfHostedTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#create SynapseIntegrationRuntimeSelfHosted#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#delete SynapseIntegrationRuntimeSelfHosted#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#read SynapseIntegrationRuntimeSelfHosted#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#update SynapseIntegrationRuntimeSelfHosted#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
