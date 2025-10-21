using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusQueue
{
    [JsiiByValue(fqn: "azurerm.dataAzurermServicebusQueue.DataAzurermServicebusQueueTimeouts")]
    public class DataAzurermServicebusQueueTimeouts : azurerm.DataAzurermServicebusQueue.IDataAzurermServicebusQueueTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#read DataAzurermServicebusQueue#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
