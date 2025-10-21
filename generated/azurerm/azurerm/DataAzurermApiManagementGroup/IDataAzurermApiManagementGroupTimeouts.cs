using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiManagementGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementGroup.DataAzurermApiManagementGroupTimeouts")]
    public interface IDataAzurermApiManagementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#read DataAzurermApiManagementGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiManagementGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementGroup.DataAzurermApiManagementGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiManagementGroup.IDataAzurermApiManagementGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#read DataAzurermApiManagementGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
