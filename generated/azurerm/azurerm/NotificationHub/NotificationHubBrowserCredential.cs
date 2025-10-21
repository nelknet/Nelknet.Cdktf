using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NotificationHub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.notificationHub.NotificationHubBrowserCredential")]
    public class NotificationHubBrowserCredential : azurerm.NotificationHub.INotificationHubBrowserCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#subject NotificationHub#subject}.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public string Subject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#vapid_private_key NotificationHub#vapid_private_key}.</summary>
        [JsiiProperty(name: "vapidPrivateKey", typeJson: "{\"primitive\":\"string\"}")]
        public string VapidPrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#vapid_public_key NotificationHub#vapid_public_key}.</summary>
        [JsiiProperty(name: "vapidPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public string VapidPublicKey
        {
            get;
            set;
        }
    }
}
