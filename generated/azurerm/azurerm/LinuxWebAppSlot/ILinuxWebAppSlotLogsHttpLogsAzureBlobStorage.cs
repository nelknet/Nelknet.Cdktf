using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsAzureBlobStorage")]
    public interface ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#sas_url LinuxWebAppSlot#sas_url}.</summary>
        [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SasUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#retention_in_days LinuxWebAppSlot#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsAzureBlobStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#sas_url LinuxWebAppSlot#sas_url}.</summary>
            [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SasUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#retention_in_days LinuxWebAppSlot#retention_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
