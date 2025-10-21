using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermElasticSanVolumeSnapshot
{
    [JsiiInterface(nativeType: typeof(IDataAzurermElasticSanVolumeSnapshotTimeouts), fullyQualifiedName: "azurerm.dataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshotTimeouts")]
    public interface IDataAzurermElasticSanVolumeSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#read DataAzurermElasticSanVolumeSnapshot#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermElasticSanVolumeSnapshotTimeouts), fullyQualifiedName: "azurerm.dataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermElasticSanVolumeSnapshot.IDataAzurermElasticSanVolumeSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#read DataAzurermElasticSanVolumeSnapshot#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
