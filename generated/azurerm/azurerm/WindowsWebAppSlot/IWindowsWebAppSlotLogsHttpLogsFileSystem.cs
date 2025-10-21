using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem")]
    public interface IWindowsWebAppSlotLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#retention_in_days WindowsWebAppSlot#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#retention_in_mb WindowsWebAppSlot#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInMb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#retention_in_days WindowsWebAppSlot#retention_in_days}.</summary>
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#retention_in_mb WindowsWebAppSlot#retention_in_mb}.</summary>
            [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInMb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
