using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotAuthSettingsV2AzureStaticWebAppV2), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2AzureStaticWebAppV2")]
    public interface IWindowsWebAppSlotAuthSettingsV2AzureStaticWebAppV2
    {
        /// <summary>The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_id WindowsWebAppSlot#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotAuthSettingsV2AzureStaticWebAppV2), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2AzureStaticWebAppV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2AzureStaticWebAppV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_id WindowsWebAppSlot#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
