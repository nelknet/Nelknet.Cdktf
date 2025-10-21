using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage")]
    public interface IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#sas_url WindowsWebAppSlot#sas_url}.</summary>
        [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SasUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#retention_in_days WindowsWebAppSlot#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#sas_url WindowsWebAppSlot#sas_url}.</summary>
            [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SasUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#retention_in_days WindowsWebAppSlot#retention_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
