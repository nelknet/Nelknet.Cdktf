using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataboxEdgeDevice
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataboxEdgeDeviceTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDeviceTimeouts")]
    public interface IDataAzurermDataboxEdgeDeviceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device#read DataAzurermDataboxEdgeDevice#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataboxEdgeDeviceTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDeviceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataboxEdgeDevice.IDataAzurermDataboxEdgeDeviceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device#read DataAzurermDataboxEdgeDevice#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
