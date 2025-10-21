using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualWan
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualWanTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualWan.DataAzurermVirtualWanTimeouts")]
    public interface IDataAzurermVirtualWanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#read DataAzurermVirtualWan#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualWanTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualWan.DataAzurermVirtualWanTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualWan.IDataAzurermVirtualWanTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#read DataAzurermVirtualWan#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
