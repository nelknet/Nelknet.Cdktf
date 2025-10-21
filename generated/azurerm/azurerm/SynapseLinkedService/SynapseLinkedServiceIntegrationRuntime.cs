using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseLinkedService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseLinkedService.SynapseLinkedServiceIntegrationRuntime")]
    public class SynapseLinkedServiceIntegrationRuntime : azurerm.SynapseLinkedService.ISynapseLinkedServiceIntegrationRuntime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#name SynapseLinkedService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#parameters SynapseLinkedService#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }
    }
}
