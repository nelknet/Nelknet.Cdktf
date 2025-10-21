using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventhubConsumerGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroupTimeouts")]
    public class DataAzurermEventhubConsumerGroupTimeouts : azurerm.DataAzurermEventhubConsumerGroup.IDataAzurermEventhubConsumerGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#read DataAzurermEventhubConsumerGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
