using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventhubCluster
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventhubCluster.DataAzurermEventhubClusterTimeouts")]
    public class DataAzurermEventhubClusterTimeouts : azurerm.DataAzurermEventhubCluster.IDataAzurermEventhubClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#read DataAzurermEventhubCluster#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
