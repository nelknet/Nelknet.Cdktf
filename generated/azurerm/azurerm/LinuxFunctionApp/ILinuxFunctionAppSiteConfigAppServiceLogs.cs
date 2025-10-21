using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppSiteConfigAppServiceLogs), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigAppServiceLogs")]
    public interface ILinuxFunctionAppSiteConfigAppServiceLogs
    {
        /// <summary>The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#disk_quota_mb LinuxFunctionApp#disk_quota_mb}
        /// </remarks>
        [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskQuotaMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#retention_period_days LinuxFunctionApp#retention_period_days}
        /// </remarks>
        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriodDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppSiteConfigAppServiceLogs), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigAppServiceLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigAppServiceLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#disk_quota_mb LinuxFunctionApp#disk_quota_mb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskQuotaMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#retention_period_days LinuxFunctionApp#retention_period_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
