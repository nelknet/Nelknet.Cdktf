using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkSlice
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkSliceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSliceTimeouts")]
    public interface IDataAzurermMobileNetworkSliceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice#read DataAzurermMobileNetworkSlice#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkSliceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSliceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetworkSlice.IDataAzurermMobileNetworkSliceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice#read DataAzurermMobileNetworkSlice#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
