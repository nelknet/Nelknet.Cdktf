using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath")]
    public interface IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#count WindowsWebAppSlot#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#interval WindowsWebAppSlot#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#time_taken WindowsWebAppSlot#time_taken}.</summary>
        [JsiiProperty(name: "timeTaken", typeJson: "{\"primitive\":\"string\"}")]
        string TimeTaken
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#path WindowsWebAppSlot#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#count WindowsWebAppSlot#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#interval WindowsWebAppSlot#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#time_taken WindowsWebAppSlot#time_taken}.</summary>
            [JsiiProperty(name: "timeTaken", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeTaken
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#path WindowsWebAppSlot#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
