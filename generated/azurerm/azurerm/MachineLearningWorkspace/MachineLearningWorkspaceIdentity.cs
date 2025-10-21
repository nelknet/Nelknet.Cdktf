using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceIdentity")]
    public class MachineLearningWorkspaceIdentity : azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#type MachineLearningWorkspace#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#identity_ids MachineLearningWorkspace#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
