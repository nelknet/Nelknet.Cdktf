using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystem")]
    public interface ILinuxWebAppLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#retention_in_days LinuxWebApp#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#retention_in_mb LinuxWebApp#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInMb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystem")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#retention_in_days LinuxWebApp#retention_in_days}.</summary>
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#retention_in_mb LinuxWebApp#retention_in_mb}.</summary>
            [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInMb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
