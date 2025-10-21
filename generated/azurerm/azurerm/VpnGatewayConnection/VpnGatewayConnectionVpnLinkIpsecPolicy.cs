using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGatewayConnection.VpnGatewayConnectionVpnLinkIpsecPolicy")]
    public class VpnGatewayConnectionVpnLinkIpsecPolicy : azurerm.VpnGatewayConnection.IVpnGatewayConnectionVpnLinkIpsecPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#dh_group VpnGatewayConnection#dh_group}.</summary>
        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string DhGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#encryption_algorithm VpnGatewayConnection#encryption_algorithm}.</summary>
        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ike_encryption_algorithm VpnGatewayConnection#ike_encryption_algorithm}.</summary>
        [JsiiProperty(name: "ikeEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string IkeEncryptionAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ike_integrity_algorithm VpnGatewayConnection#ike_integrity_algorithm}.</summary>
        [JsiiProperty(name: "ikeIntegrityAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string IkeIntegrityAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#integrity_algorithm VpnGatewayConnection#integrity_algorithm}.</summary>
        [JsiiProperty(name: "integrityAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string IntegrityAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#pfs_group VpnGatewayConnection#pfs_group}.</summary>
        [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string PfsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#sa_data_size_kb VpnGatewayConnection#sa_data_size_kb}.</summary>
        [JsiiProperty(name: "saDataSizeKb", typeJson: "{\"primitive\":\"number\"}")]
        public double SaDataSizeKb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#sa_lifetime_sec VpnGatewayConnection#sa_lifetime_sec}.</summary>
        [JsiiProperty(name: "saLifetimeSec", typeJson: "{\"primitive\":\"number\"}")]
        public double SaLifetimeSec
        {
            get;
            set;
        }
    }
}
