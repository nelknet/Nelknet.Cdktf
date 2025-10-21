using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionIpsecPolicy")]
    public class VirtualNetworkGatewayConnectionIpsecPolicy : azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionIpsecPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#dh_group VirtualNetworkGatewayConnection#dh_group}.</summary>
        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string DhGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#ike_encryption VirtualNetworkGatewayConnection#ike_encryption}.</summary>
        [JsiiProperty(name: "ikeEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public string IkeEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#ike_integrity VirtualNetworkGatewayConnection#ike_integrity}.</summary>
        [JsiiProperty(name: "ikeIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        public string IkeIntegrity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#ipsec_encryption VirtualNetworkGatewayConnection#ipsec_encryption}.</summary>
        [JsiiProperty(name: "ipsecEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public string IpsecEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#ipsec_integrity VirtualNetworkGatewayConnection#ipsec_integrity}.</summary>
        [JsiiProperty(name: "ipsecIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        public string IpsecIntegrity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#pfs_group VirtualNetworkGatewayConnection#pfs_group}.</summary>
        [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string PfsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#sa_datasize VirtualNetworkGatewayConnection#sa_datasize}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saDatasize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SaDatasize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#sa_lifetime VirtualNetworkGatewayConnection#sa_lifetime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SaLifetime
        {
            get;
            set;
        }
    }
}
