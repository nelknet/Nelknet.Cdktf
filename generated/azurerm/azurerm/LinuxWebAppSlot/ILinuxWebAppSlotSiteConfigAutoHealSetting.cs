using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSlotSiteConfigAutoHealSetting), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSetting")]
    public interface ILinuxWebAppSlotSiteConfigAutoHealSetting
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#action LinuxWebAppSlot#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#trigger LinuxWebAppSlot#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTrigger? Trigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSlotSiteConfigAutoHealSetting), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSetting")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#action LinuxWebAppSlot#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingAction\"}", isOptional: true)]
            public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingAction? Action
            {
                get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingAction?>();
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#trigger LinuxWebAppSlot#trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
            public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTrigger? Trigger
            {
                get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTrigger?>();
            }
        }
    }
}
