using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlotVirtualNetworkSwiftConnection
{
    [JsiiByValue(fqn: "azurerm.appServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeouts")]
    public class AppServiceSlotVirtualNetworkSwiftConnectionTimeouts : azurerm.AppServiceSlotVirtualNetworkSwiftConnection.IAppServiceSlotVirtualNetworkSwiftConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#create AppServiceSlotVirtualNetworkSwiftConnection#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#delete AppServiceSlotVirtualNetworkSwiftConnection#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#read AppServiceSlotVirtualNetworkSwiftConnection#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#update AppServiceSlotVirtualNetworkSwiftConnection#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
