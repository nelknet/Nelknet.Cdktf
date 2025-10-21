using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppSiteConfigAppServiceLogs), fullyQualifiedName: "azurerm.windowsFunctionApp.WindowsFunctionAppSiteConfigAppServiceLogs")]
    public interface IWindowsFunctionAppSiteConfigAppServiceLogs
    {
        /// <summary>The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#disk_quota_mb WindowsFunctionApp#disk_quota_mb}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#retention_period_days WindowsFunctionApp#retention_period_days}
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

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppSiteConfigAppServiceLogs), fullyQualifiedName: "azurerm.windowsFunctionApp.WindowsFunctionAppSiteConfigAppServiceLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionApp.IWindowsFunctionAppSiteConfigAppServiceLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#disk_quota_mb WindowsFunctionApp#disk_quota_mb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskQuotaMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#retention_period_days WindowsFunctionApp#retention_period_days}
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
