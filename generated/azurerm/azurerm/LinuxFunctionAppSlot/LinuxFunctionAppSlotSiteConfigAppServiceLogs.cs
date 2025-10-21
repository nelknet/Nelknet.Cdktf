using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiByValue(fqn: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigAppServiceLogs")]
    public class LinuxFunctionAppSlotSiteConfigAppServiceLogs : azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigAppServiceLogs
    {
        /// <summary>The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#disk_quota_mb LinuxFunctionAppSlot#disk_quota_mb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskQuotaMb
        {
            get;
            set;
        }

        /// <summary>The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#retention_period_days LinuxFunctionAppSlot#retention_period_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriodDays
        {
            get;
            set;
        }
    }
}
