using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpnServerConfigurationIpsecPolicy), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicy")]
    public interface IVpnServerConfigurationIpsecPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#dh_group VpnServerConfiguration#dh_group}.</summary>
        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        string DhGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ike_encryption VpnServerConfiguration#ike_encryption}.</summary>
        [JsiiProperty(name: "ikeEncryption", typeJson: "{\"primitive\":\"string\"}")]
        string IkeEncryption
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ike_integrity VpnServerConfiguration#ike_integrity}.</summary>
        [JsiiProperty(name: "ikeIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        string IkeIntegrity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ipsec_encryption VpnServerConfiguration#ipsec_encryption}.</summary>
        [JsiiProperty(name: "ipsecEncryption", typeJson: "{\"primitive\":\"string\"}")]
        string IpsecEncryption
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ipsec_integrity VpnServerConfiguration#ipsec_integrity}.</summary>
        [JsiiProperty(name: "ipsecIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        string IpsecIntegrity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#pfs_group VpnServerConfiguration#pfs_group}.</summary>
        [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
        string PfsGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#sa_data_size_kilobytes VpnServerConfiguration#sa_data_size_kilobytes}.</summary>
        [JsiiProperty(name: "saDataSizeKilobytes", typeJson: "{\"primitive\":\"number\"}")]
        double SaDataSizeKilobytes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#sa_lifetime_seconds VpnServerConfiguration#sa_lifetime_seconds}.</summary>
        [JsiiProperty(name: "saLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double SaLifetimeSeconds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnServerConfigurationIpsecPolicy), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#dh_group VpnServerConfiguration#dh_group}.</summary>
            [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string DhGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ike_encryption VpnServerConfiguration#ike_encryption}.</summary>
            [JsiiProperty(name: "ikeEncryption", typeJson: "{\"primitive\":\"string\"}")]
            public string IkeEncryption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ike_integrity VpnServerConfiguration#ike_integrity}.</summary>
            [JsiiProperty(name: "ikeIntegrity", typeJson: "{\"primitive\":\"string\"}")]
            public string IkeIntegrity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ipsec_encryption VpnServerConfiguration#ipsec_encryption}.</summary>
            [JsiiProperty(name: "ipsecEncryption", typeJson: "{\"primitive\":\"string\"}")]
            public string IpsecEncryption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ipsec_integrity VpnServerConfiguration#ipsec_integrity}.</summary>
            [JsiiProperty(name: "ipsecIntegrity", typeJson: "{\"primitive\":\"string\"}")]
            public string IpsecIntegrity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#pfs_group VpnServerConfiguration#pfs_group}.</summary>
            [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string PfsGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#sa_data_size_kilobytes VpnServerConfiguration#sa_data_size_kilobytes}.</summary>
            [JsiiProperty(name: "saDataSizeKilobytes", typeJson: "{\"primitive\":\"number\"}")]
            public double SaDataSizeKilobytes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#sa_lifetime_seconds VpnServerConfiguration#sa_lifetime_seconds}.</summary>
            [JsiiProperty(name: "saLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double SaLifetimeSeconds
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
