using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem")]
    public class AppServiceSlotLogsHttpLogsFileSystem : azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#retention_in_days AppServiceSlot#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#retention_in_mb AppServiceSlot#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInMb
        {
            get;
            set;
        }
    }
}
