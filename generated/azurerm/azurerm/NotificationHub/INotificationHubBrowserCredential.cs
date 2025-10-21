using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NotificationHub
{
    [JsiiInterface(nativeType: typeof(INotificationHubBrowserCredential), fullyQualifiedName: "azurerm.notificationHub.NotificationHubBrowserCredential")]
    public interface INotificationHubBrowserCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#subject NotificationHub#subject}.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        string Subject
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#vapid_private_key NotificationHub#vapid_private_key}.</summary>
        [JsiiProperty(name: "vapidPrivateKey", typeJson: "{\"primitive\":\"string\"}")]
        string VapidPrivateKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#vapid_public_key NotificationHub#vapid_public_key}.</summary>
        [JsiiProperty(name: "vapidPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        string VapidPublicKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INotificationHubBrowserCredential), fullyQualifiedName: "azurerm.notificationHub.NotificationHubBrowserCredential")]
        internal sealed class _Proxy : DeputyBase, azurerm.NotificationHub.INotificationHubBrowserCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#subject NotificationHub#subject}.</summary>
            [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
            public string Subject
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#vapid_private_key NotificationHub#vapid_private_key}.</summary>
            [JsiiProperty(name: "vapidPrivateKey", typeJson: "{\"primitive\":\"string\"}")]
            public string VapidPrivateKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#vapid_public_key NotificationHub#vapid_public_key}.</summary>
            [JsiiProperty(name: "vapidPublicKey", typeJson: "{\"primitive\":\"string\"}")]
            public string VapidPublicKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
