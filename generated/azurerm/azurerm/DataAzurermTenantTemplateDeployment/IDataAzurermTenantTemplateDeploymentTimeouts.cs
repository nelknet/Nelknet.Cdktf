using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermTenantTemplateDeployment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermTenantTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeploymentTimeouts")]
    public interface IDataAzurermTenantTemplateDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/tenant_template_deployment#read DataAzurermTenantTemplateDeployment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermTenantTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeploymentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermTenantTemplateDeployment.IDataAzurermTenantTemplateDeploymentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/tenant_template_deployment#read DataAzurermTenantTemplateDeployment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
