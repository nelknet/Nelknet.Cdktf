using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappAccount
{
    [JsiiInterface(nativeType: typeof(INetappAccountActiveDirectory), fullyQualifiedName: "azurerm.netappAccount.NetappAccountActiveDirectory")]
    public interface INetappAccountActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#dns_servers NetappAccount#dns_servers}.</summary>
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsServers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#domain NetappAccount#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#password NetappAccount#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#smb_server_name NetappAccount#smb_server_name}.</summary>
        [JsiiProperty(name: "smbServerName", typeJson: "{\"primitive\":\"string\"}")]
        string SmbServerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#username NetappAccount#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>If enabled, AES encryption will be enabled for SMB communication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#aes_encryption_enabled NetappAccount#aes_encryption_enabled}
        /// </remarks>
        [JsiiProperty(name: "aesEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AesEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the active directory machine. This optional parameter is used only while creating kerberos volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#kerberos_ad_name NetappAccount#kerberos_ad_name}
        /// </remarks>
        [JsiiProperty(name: "kerberosAdName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KerberosAdName
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP address of the KDC server (usually same the DC).</summary>
        /// <remarks>
        /// This optional parameter is used only while creating kerberos volume.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#kerberos_kdc_ip NetappAccount#kerberos_kdc_ip}
        /// </remarks>
        [JsiiProperty(name: "kerberosKdcIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KerberosKdcIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether or not the LDAP traffic needs to be secured via TLS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#ldap_over_tls_enabled NetappAccount#ldap_over_tls_enabled}
        /// </remarks>
        [JsiiProperty(name: "ldapOverTlsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LdapOverTlsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether or not the LDAP traffic needs to be signed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#ldap_signing_enabled NetappAccount#ldap_signing_enabled}
        /// </remarks>
        [JsiiProperty(name: "ldapSigningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LdapSigningEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#local_nfs_users_with_ldap_allowed NetappAccount#local_nfs_users_with_ldap_allowed}
        /// </remarks>
        [JsiiProperty(name: "localNfsUsersWithLdapAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LocalNfsUsersWithLdapAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to 'CN=Computers'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#organizational_unit NetappAccount#organizational_unit}
        /// </remarks>
        [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationalUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service's self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#server_root_ca_certificate NetappAccount#server_root_ca_certificate}
        /// </remarks>
        [JsiiProperty(name: "serverRootCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerRootCaCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to 'Default-First-Site-Name'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#site_name NetappAccount#site_name}
        /// </remarks>
        [JsiiProperty(name: "siteName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SiteName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappAccountActiveDirectory), fullyQualifiedName: "azurerm.netappAccount.NetappAccountActiveDirectory")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappAccount.INetappAccountActiveDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#dns_servers NetappAccount#dns_servers}.</summary>
            [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsServers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#domain NetappAccount#domain}.</summary>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#password NetappAccount#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#smb_server_name NetappAccount#smb_server_name}.</summary>
            [JsiiProperty(name: "smbServerName", typeJson: "{\"primitive\":\"string\"}")]
            public string SmbServerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#username NetappAccount#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If enabled, AES encryption will be enabled for SMB communication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#aes_encryption_enabled NetappAccount#aes_encryption_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aesEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AesEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the active directory machine. This optional parameter is used only while creating kerberos volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#kerberos_ad_name NetappAccount#kerberos_ad_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kerberosAdName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KerberosAdName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>IP address of the KDC server (usually same the DC).</summary>
            /// <remarks>
            /// This optional parameter is used only while creating kerberos volume.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#kerberos_kdc_ip NetappAccount#kerberos_kdc_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kerberosKdcIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KerberosKdcIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether or not the LDAP traffic needs to be secured via TLS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#ldap_over_tls_enabled NetappAccount#ldap_over_tls_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ldapOverTlsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LdapOverTlsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies whether or not the LDAP traffic needs to be signed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#ldap_signing_enabled NetappAccount#ldap_signing_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ldapSigningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LdapSigningEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#local_nfs_users_with_ldap_allowed NetappAccount#local_nfs_users_with_ldap_allowed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localNfsUsersWithLdapAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LocalNfsUsersWithLdapAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to 'CN=Computers'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#organizational_unit NetappAccount#organizational_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationalUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service's self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#server_root_ca_certificate NetappAccount#server_root_ca_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverRootCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerRootCaCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to 'Default-First-Site-Name'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#site_name NetappAccount#site_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "siteName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SiteName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
