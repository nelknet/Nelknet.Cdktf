using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNotificationHubNamespace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespaceTimeouts")]
    public class DataAzurermNotificationHubNamespaceTimeouts : azurerm.DataAzurermNotificationHubNamespace.IDataAzurermNotificationHubNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#read DataAzurermNotificationHubNamespace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
