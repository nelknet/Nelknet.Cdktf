using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotStorageAccount")]
    public class WindowsFunctionAppSlotStorageAccount : azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotStorageAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#access_key WindowsFunctionAppSlot#access_key}.</summary>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#account_name WindowsFunctionAppSlot#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#name WindowsFunctionAppSlot#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#share_name WindowsFunctionAppSlot#share_name}.</summary>
        [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}")]
        public string ShareName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#type WindowsFunctionAppSlot#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#mount_path WindowsFunctionAppSlot#mount_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPath
        {
            get;
            set;
        }
    }
}
