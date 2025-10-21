using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermResourceGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermResourceGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermResourceGroup.DataAzurermResourceGroupTimeouts")]
    public interface IDataAzurermResourceGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group#read DataAzurermResourceGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermResourceGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermResourceGroup.DataAzurermResourceGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermResourceGroup.IDataAzurermResourceGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group#read DataAzurermResourceGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
