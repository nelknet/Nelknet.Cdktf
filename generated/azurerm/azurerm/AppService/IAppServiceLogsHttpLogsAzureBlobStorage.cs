using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiInterface(nativeType: typeof(IAppServiceLogsHttpLogsAzureBlobStorage), fullyQualifiedName: "azurerm.appService.AppServiceLogsHttpLogsAzureBlobStorage")]
    public interface IAppServiceLogsHttpLogsAzureBlobStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_days AppService#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#sas_url AppService#sas_url}.</summary>
        [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SasUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceLogsHttpLogsAzureBlobStorage), fullyQualifiedName: "azurerm.appService.AppServiceLogsHttpLogsAzureBlobStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppService.IAppServiceLogsHttpLogsAzureBlobStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_days AppService#retention_in_days}.</summary>
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#sas_url AppService#sas_url}.</summary>
            [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SasUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
