using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiInterface(nativeType: typeof(IAppServiceLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.appService.AppServiceLogsHttpLogsFileSystem")]
    public interface IAppServiceLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_days AppService#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_mb AppService#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInMb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.appService.AppServiceLogsHttpLogsFileSystem")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppService.IAppServiceLogsHttpLogsFileSystem
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#retention_in_mb AppService#retention_in_mb}.</summary>
            [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInMb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
