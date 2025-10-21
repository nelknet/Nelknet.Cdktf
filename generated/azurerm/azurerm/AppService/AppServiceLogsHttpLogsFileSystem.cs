using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appService.AppServiceLogsHttpLogsFileSystem")]
    public class AppServiceLogsHttpLogsFileSystem : azurerm.AppService.IAppServiceLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_days AppService#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_mb AppService#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInMb
        {
            get;
            set;
        }
    }
}
