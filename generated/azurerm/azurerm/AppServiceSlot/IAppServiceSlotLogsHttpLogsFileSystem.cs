using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSlotLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem")]
    public interface IAppServiceSlotLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#retention_in_days AppServiceSlot#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#retention_in_mb AppServiceSlot#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInMb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSlotLogsHttpLogsFileSystem), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#retention_in_days AppServiceSlot#retention_in_days}.</summary>
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#retention_in_mb AppServiceSlot#retention_in_mb}.</summary>
            [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInMb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
