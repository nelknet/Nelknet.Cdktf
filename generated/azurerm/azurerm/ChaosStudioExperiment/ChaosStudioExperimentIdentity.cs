using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ChaosStudioExperiment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.chaosStudioExperiment.ChaosStudioExperimentIdentity")]
    public class ChaosStudioExperimentIdentity : azurerm.ChaosStudioExperiment.IChaosStudioExperimentIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#type ChaosStudioExperiment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#identity_ids ChaosStudioExperiment#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
