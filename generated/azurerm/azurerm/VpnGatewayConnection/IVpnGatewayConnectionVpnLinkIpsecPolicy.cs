using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayConnectionVpnLinkIpsecPolicy), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionVpnLinkIpsecPolicy")]
    public interface IVpnGatewayConnectionVpnLinkIpsecPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#dh_group VpnGatewayConnection#dh_group}.</summary>
        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        string DhGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#encryption_algorithm VpnGatewayConnection#encryption_algorithm}.</summary>
        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string EncryptionAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ike_encryption_algorithm VpnGatewayConnection#ike_encryption_algorithm}.</summary>
        [JsiiProperty(name: "ikeEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string IkeEncryptionAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ike_integrity_algorithm VpnGatewayConnection#ike_integrity_algorithm}.</summary>
        [JsiiProperty(name: "ikeIntegrityAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string IkeIntegrityAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#integrity_algorithm VpnGatewayConnection#integrity_algorithm}.</summary>
        [JsiiProperty(name: "integrityAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string IntegrityAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#pfs_group VpnGatewayConnection#pfs_group}.</summary>
        [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
        string PfsGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#sa_data_size_kb VpnGatewayConnection#sa_data_size_kb}.</summary>
        [JsiiProperty(name: "saDataSizeKb", typeJson: "{\"primitive\":\"number\"}")]
        double SaDataSizeKb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#sa_lifetime_sec VpnGatewayConnection#sa_lifetime_sec}.</summary>
        [JsiiProperty(name: "saLifetimeSec", typeJson: "{\"primitive\":\"number\"}")]
        double SaLifetimeSec
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayConnectionVpnLinkIpsecPolicy), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionVpnLinkIpsecPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGatewayConnection.IVpnGatewayConnectionVpnLinkIpsecPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#dh_group VpnGatewayConnection#dh_group}.</summary>
            [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string DhGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#encryption_algorithm VpnGatewayConnection#encryption_algorithm}.</summary>
            [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string EncryptionAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ike_encryption_algorithm VpnGatewayConnection#ike_encryption_algorithm}.</summary>
            [JsiiProperty(name: "ikeEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string IkeEncryptionAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ike_integrity_algorithm VpnGatewayConnection#ike_integrity_algorithm}.</summary>
            [JsiiProperty(name: "ikeIntegrityAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string IkeIntegrityAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#integrity_algorithm VpnGatewayConnection#integrity_algorithm}.</summary>
            [JsiiProperty(name: "integrityAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string IntegrityAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#pfs_group VpnGatewayConnection#pfs_group}.</summary>
            [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string PfsGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#sa_data_size_kb VpnGatewayConnection#sa_data_size_kb}.</summary>
            [JsiiProperty(name: "saDataSizeKb", typeJson: "{\"primitive\":\"number\"}")]
            public double SaDataSizeKb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#sa_lifetime_sec VpnGatewayConnection#sa_lifetime_sec}.</summary>
            [JsiiProperty(name: "saLifetimeSec", typeJson: "{\"primitive\":\"number\"}")]
            public double SaLifetimeSec
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
