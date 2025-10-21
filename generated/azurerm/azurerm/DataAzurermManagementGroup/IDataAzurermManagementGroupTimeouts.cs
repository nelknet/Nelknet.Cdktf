using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagementGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermManagementGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagementGroup.DataAzurermManagementGroupTimeouts")]
    public interface IDataAzurermManagementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group#read DataAzurermManagementGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermManagementGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagementGroup.DataAzurermManagementGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermManagementGroup.IDataAzurermManagementGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group#read DataAzurermManagementGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
