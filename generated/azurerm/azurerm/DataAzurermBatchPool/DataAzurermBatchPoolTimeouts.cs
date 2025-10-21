using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchPool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTimeouts")]
    public class DataAzurermBatchPoolTimeouts : azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#read DataAzurermBatchPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
