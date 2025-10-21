using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceDeploymentScriptAzureCli
{
    [JsiiInterface(nativeType: typeof(IResourceDeploymentScriptAzureCliContainer), fullyQualifiedName: "azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainer")]
    public interface IResourceDeploymentScriptAzureCliContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#container_group_name ResourceDeploymentScriptAzureCli#container_group_name}.</summary>
        [JsiiProperty(name: "containerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerGroupName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceDeploymentScriptAzureCliContainer), fullyQualifiedName: "azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainer")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#container_group_name ResourceDeploymentScriptAzureCli#container_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerGroupName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
