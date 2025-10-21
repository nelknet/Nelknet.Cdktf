using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagementGroupTemplateDeployment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermManagementGroupTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeploymentTimeouts")]
    public interface IDataAzurermManagementGroupTemplateDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment#read DataAzurermManagementGroupTemplateDeployment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermManagementGroupTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeploymentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermManagementGroupTemplateDeployment.IDataAzurermManagementGroupTemplateDeploymentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment#read DataAzurermManagementGroupTemplateDeployment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
