using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevTestVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevTestVirtualNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeouts")]
    public interface IDataAzurermDevTestVirtualNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#read DataAzurermDevTestVirtualNetwork#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevTestVirtualNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevTestVirtualNetwork.IDataAzurermDevTestVirtualNetworkTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#read DataAzurermDevTestVirtualNetwork#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
