using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NotificationHub
{
    [JsiiInterface(nativeType: typeof(INotificationHubApnsCredential), fullyQualifiedName: "azurerm.notificationHub.NotificationHubApnsCredential")]
    public interface INotificationHubApnsCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#application_mode NotificationHub#application_mode}.</summary>
        [JsiiProperty(name: "applicationMode", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#bundle_id NotificationHub#bundle_id}.</summary>
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        string BundleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#key_id NotificationHub#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#team_id NotificationHub#team_id}.</summary>
        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}")]
        string TeamId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#token NotificationHub#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INotificationHubApnsCredential), fullyQualifiedName: "azurerm.notificationHub.NotificationHubApnsCredential")]
        internal sealed class _Proxy : DeputyBase, azurerm.NotificationHub.INotificationHubApnsCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#application_mode NotificationHub#application_mode}.</summary>
            [JsiiProperty(name: "applicationMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#bundle_id NotificationHub#bundle_id}.</summary>
            [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
            public string BundleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#key_id NotificationHub#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#team_id NotificationHub#team_id}.</summary>
            [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}")]
            public string TeamId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#token NotificationHub#token}.</summary>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
