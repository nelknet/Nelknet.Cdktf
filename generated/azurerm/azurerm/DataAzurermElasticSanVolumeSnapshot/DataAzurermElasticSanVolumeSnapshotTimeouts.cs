using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermElasticSanVolumeSnapshot
{
    [JsiiByValue(fqn: "azurerm.dataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshotTimeouts")]
    public class DataAzurermElasticSanVolumeSnapshotTimeouts : azurerm.DataAzurermElasticSanVolumeSnapshot.IDataAzurermElasticSanVolumeSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#read DataAzurermElasticSanVolumeSnapshot#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
