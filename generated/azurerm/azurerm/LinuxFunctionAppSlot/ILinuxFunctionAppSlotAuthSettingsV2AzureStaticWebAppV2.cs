using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2")]
    public interface ILinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2
    {
        /// <summary>The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#client_id LinuxFunctionAppSlot#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#client_id LinuxFunctionAppSlot#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
