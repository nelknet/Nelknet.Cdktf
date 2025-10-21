using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusSubscription
{
    [JsiiByValue(fqn: "azurerm.dataAzurermServicebusSubscription.DataAzurermServicebusSubscriptionTimeouts")]
    public class DataAzurermServicebusSubscriptionTimeouts : azurerm.DataAzurermServicebusSubscription.IDataAzurermServicebusSubscriptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#read DataAzurermServicebusSubscription#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
