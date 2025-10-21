using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNotificationHub
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNotificationHubTimeouts), fullyQualifiedName: "azurerm.dataAzurermNotificationHub.DataAzurermNotificationHubTimeouts")]
    public interface IDataAzurermNotificationHubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#read DataAzurermNotificationHub#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNotificationHubTimeouts), fullyQualifiedName: "azurerm.dataAzurermNotificationHub.DataAzurermNotificationHubTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNotificationHub.IDataAzurermNotificationHubTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#read DataAzurermNotificationHub#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
