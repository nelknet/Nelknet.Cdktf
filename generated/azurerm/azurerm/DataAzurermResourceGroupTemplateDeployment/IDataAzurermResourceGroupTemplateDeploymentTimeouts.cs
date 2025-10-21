using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermResourceGroupTemplateDeployment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermResourceGroupTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeploymentTimeouts")]
    public interface IDataAzurermResourceGroupTemplateDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#read DataAzurermResourceGroupTemplateDeployment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermResourceGroupTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeploymentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermResourceGroupTemplateDeployment.IDataAzurermResourceGroupTemplateDeploymentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#read DataAzurermResourceGroupTemplateDeployment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
