using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementProduct
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiManagementProductTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementProduct.DataAzurermApiManagementProductTimeouts")]
    public interface IDataAzurermApiManagementProductTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#read DataAzurermApiManagementProduct#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiManagementProductTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementProduct.DataAzurermApiManagementProductTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiManagementProduct.IDataAzurermApiManagementProductTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#read DataAzurermApiManagementProduct#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
