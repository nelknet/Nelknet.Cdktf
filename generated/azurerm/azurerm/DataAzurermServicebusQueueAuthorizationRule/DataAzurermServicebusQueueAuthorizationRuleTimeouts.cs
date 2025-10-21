using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusQueueAuthorizationRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRuleTimeouts")]
    public class DataAzurermServicebusQueueAuthorizationRuleTimeouts : azurerm.DataAzurermServicebusQueueAuthorizationRule.IDataAzurermServicebusQueueAuthorizationRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#read DataAzurermServicebusQueueAuthorizationRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
