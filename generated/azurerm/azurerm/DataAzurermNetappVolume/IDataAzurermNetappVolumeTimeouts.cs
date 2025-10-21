using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolume
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappVolumeTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolume.DataAzurermNetappVolumeTimeouts")]
    public interface IDataAzurermNetappVolumeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#read DataAzurermNetappVolume#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappVolumeTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolume.DataAzurermNetappVolumeTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappVolume.IDataAzurermNetappVolumeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#read DataAzurermNetappVolume#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
