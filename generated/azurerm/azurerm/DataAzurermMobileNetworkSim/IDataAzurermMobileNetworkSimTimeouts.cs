using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkSim
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkSimTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSim.DataAzurermMobileNetworkSimTimeouts")]
    public interface IDataAzurermMobileNetworkSimTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim#read DataAzurermMobileNetworkSim#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkSimTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSim.DataAzurermMobileNetworkSimTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetworkSim.IDataAzurermMobileNetworkSimTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim#read DataAzurermMobileNetworkSim#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
