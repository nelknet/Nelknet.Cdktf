using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkProfile.NetworkProfileContainerNetworkInterfaceIpConfiguration")]
    public class NetworkProfileContainerNetworkInterfaceIpConfiguration : azurerm.NetworkProfile.INetworkProfileContainerNetworkInterfaceIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#name NetworkProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#subnet_id NetworkProfile#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
