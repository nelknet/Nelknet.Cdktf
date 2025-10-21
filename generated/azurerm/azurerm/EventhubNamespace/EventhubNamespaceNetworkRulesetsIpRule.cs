using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventhubNamespace
{
    [JsiiByValue(fqn: "azurerm.eventhubNamespace.EventhubNamespaceNetworkRulesetsIpRule")]
    public class EventhubNamespaceNetworkRulesetsIpRule : azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#action EventhubNamespace#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#ip_mask EventhubNamespace#ip_mask}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpMask
        {
            get;
            set;
        }
    }
}
