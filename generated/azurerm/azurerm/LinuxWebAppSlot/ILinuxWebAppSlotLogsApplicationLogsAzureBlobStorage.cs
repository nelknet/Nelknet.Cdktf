using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSlotLogsApplicationLogsAzureBlobStorage), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogsAzureBlobStorage")]
    public interface ILinuxWebAppSlotLogsApplicationLogsAzureBlobStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#level LinuxWebAppSlot#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        string Level
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#retention_in_days LinuxWebAppSlot#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#sas_url LinuxWebAppSlot#sas_url}.</summary>
        [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SasUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSlotLogsApplicationLogsAzureBlobStorage), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogsAzureBlobStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogsAzureBlobStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#level LinuxWebAppSlot#level}.</summary>
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
            public string Level
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#retention_in_days LinuxWebAppSlot#retention_in_days}.</summary>
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#sas_url LinuxWebAppSlot#sas_url}.</summary>
            [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SasUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
