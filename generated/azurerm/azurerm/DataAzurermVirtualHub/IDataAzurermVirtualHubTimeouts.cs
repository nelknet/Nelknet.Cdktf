using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualHub
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualHubTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualHub.DataAzurermVirtualHubTimeouts")]
    public interface IDataAzurermVirtualHubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub#read DataAzurermVirtualHub#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualHubTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualHub.DataAzurermVirtualHubTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualHub.IDataAzurermVirtualHubTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub#read DataAzurermVirtualHub#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
