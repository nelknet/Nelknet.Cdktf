using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetwork.VirtualNetworkEncryption")]
    public class VirtualNetworkEncryption : azurerm.VirtualNetwork.IVirtualNetworkEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#enforcement VirtualNetwork#enforcement}.</summary>
        [JsiiProperty(name: "enforcement", typeJson: "{\"primitive\":\"string\"}")]
        public string Enforcement
        {
            get;
            set;
        }
    }
}
