using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NotificationHub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.notificationHub.NotificationHubGcmCredential")]
    public class NotificationHubGcmCredential : azurerm.NotificationHub.INotificationHubGcmCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#api_key NotificationHub#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }
    }
}
