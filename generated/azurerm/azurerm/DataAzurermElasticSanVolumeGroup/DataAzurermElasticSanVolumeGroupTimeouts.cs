using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermElasticSanVolumeGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroupTimeouts")]
    public class DataAzurermElasticSanVolumeGroupTimeouts : azurerm.DataAzurermElasticSanVolumeGroup.IDataAzurermElasticSanVolumeGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_group#read DataAzurermElasticSanVolumeGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
