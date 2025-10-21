using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNotificationHubNamespace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNotificationHubNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespaceTimeouts")]
    public interface IDataAzurermNotificationHubNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#read DataAzurermNotificationHubNamespace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNotificationHubNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNotificationHubNamespace.IDataAzurermNotificationHubNamespaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#read DataAzurermNotificationHubNamespace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
