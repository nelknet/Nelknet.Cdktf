using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode")]
    public interface IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#status_code_range WindowsWebAppSlot#status_code_range}.</summary>
        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"primitive\":\"string\"}")]
        string StatusCodeRange
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#sub_status WindowsWebAppSlot#sub_status}.</summary>
        [JsiiProperty(name: "subStatus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SubStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#win32_status_code WindowsWebAppSlot#win32_status_code}.</summary>
        [JsiiProperty(name: "win32StatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Win32StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#status_code_range WindowsWebAppSlot#status_code_range}.</summary>
            [JsiiProperty(name: "statusCodeRange", typeJson: "{\"primitive\":\"string\"}")]
            public string StatusCodeRange
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#sub_status WindowsWebAppSlot#sub_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subStatus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SubStatus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#win32_status_code WindowsWebAppSlot#win32_status_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "win32StatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Win32StatusCode
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
