using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoVirtualNetworkAppliance
{
    [JsiiByValue(fqn: "azurerm.paloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkApplianceTimeouts")]
    public class PaloAltoVirtualNetworkApplianceTimeouts : azurerm.PaloAltoVirtualNetworkAppliance.IPaloAltoVirtualNetworkApplianceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#create PaloAltoVirtualNetworkAppliance#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#delete PaloAltoVirtualNetworkAppliance#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#read PaloAltoVirtualNetworkAppliance#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
