using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceDeploymentScriptAzureCli
{
    [JsiiByValue(fqn: "azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainer")]
    public class ResourceDeploymentScriptAzureCliContainer : azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#container_group_name ResourceDeploymentScriptAzureCli#container_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerGroupName
        {
            get;
            set;
        }
    }
}
