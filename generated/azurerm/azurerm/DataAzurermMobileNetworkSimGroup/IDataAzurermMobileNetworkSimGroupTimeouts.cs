using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkSimGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkSimGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroupTimeouts")]
    public interface IDataAzurermMobileNetworkSimGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group#read DataAzurermMobileNetworkSimGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkSimGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetworkSimGroup.IDataAzurermMobileNetworkSimGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group#read DataAzurermMobileNetworkSimGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
