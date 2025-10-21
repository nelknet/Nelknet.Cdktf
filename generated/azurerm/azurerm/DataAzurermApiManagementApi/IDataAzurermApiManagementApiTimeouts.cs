using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiManagementApiTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementApi.DataAzurermApiManagementApiTimeouts")]
    public interface IDataAzurermApiManagementApiTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#read DataAzurermApiManagementApi#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiManagementApiTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementApi.DataAzurermApiManagementApiTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiManagementApi.IDataAzurermApiManagementApiTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#read DataAzurermApiManagementApi#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
