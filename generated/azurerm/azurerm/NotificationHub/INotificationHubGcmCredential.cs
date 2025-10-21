using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NotificationHub
{
    [JsiiInterface(nativeType: typeof(INotificationHubGcmCredential), fullyQualifiedName: "azurerm.notificationHub.NotificationHubGcmCredential")]
    public interface INotificationHubGcmCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#api_key NotificationHub#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INotificationHubGcmCredential), fullyQualifiedName: "azurerm.notificationHub.NotificationHubGcmCredential")]
        internal sealed class _Proxy : DeputyBase, azurerm.NotificationHub.INotificationHubGcmCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#api_key NotificationHub#api_key}.</summary>
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
