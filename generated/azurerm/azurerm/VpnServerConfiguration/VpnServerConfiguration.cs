using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration azurerm_vpn_server_configuration}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.VpnServerConfiguration.VpnServerConfiguration), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationConfig\"}}]")]
    public class VpnServerConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration azurerm_vpn_server_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpnServerConfiguration(Constructs.Construct scope, string id, azurerm.VpnServerConfiguration.IVpnServerConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.VpnServerConfiguration.IVpnServerConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnServerConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnServerConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VpnServerConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VpnServerConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing VpnServerConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VpnServerConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VpnServerConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VpnServerConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VpnServerConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.VpnServerConfiguration.VpnServerConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureActiveDirectoryAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthentication\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAzureActiveDirectoryAuthentication(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VpnServerConfiguration.IVpnServerConfigurationAzureActiveDirectoryAuthentication[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationAzureActiveDirectoryAuthentication).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationAzureActiveDirectoryAuthentication).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientRevokedCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationClientRevokedCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientRevokedCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRevokedCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRevokedCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRevokedCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientRootCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationClientRootCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientRootCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRootCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRootCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRootCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpsecPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicy\"}}]")]
        public virtual void PutIpsecPolicy(azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadius", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadius\"}}]")]
        public virtual void PutRadius(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.VpnServerConfiguration.IVpnServerConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureActiveDirectoryAuthentication")]
        public virtual void ResetAzureActiveDirectoryAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientRevokedCertificate")]
        public virtual void ResetClientRevokedCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientRootCertificate")]
        public virtual void ResetClientRootCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpsecPolicy")]
        public virtual void ResetIpsecPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRadius")]
        public virtual void ResetRadius()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnProtocols")]
        public virtual void ResetVpnProtocols()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.VpnServerConfiguration.VpnServerConfiguration))!;

        [JsiiProperty(name: "azureActiveDirectoryAuthentication", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthenticationList\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthenticationList AzureActiveDirectoryAuthentication
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthenticationList>()!;
        }

        [JsiiProperty(name: "clientRevokedCertificate", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationClientRevokedCertificateList\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationClientRevokedCertificateList ClientRevokedCertificate
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationClientRevokedCertificateList>()!;
        }

        [JsiiProperty(name: "clientRootCertificate", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationClientRootCertificateList\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationClientRootCertificateList ClientRootCertificate
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationClientRootCertificateList>()!;
        }

        [JsiiProperty(name: "ipsecPolicy", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicyOutputReference\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationIpsecPolicyOutputReference IpsecPolicy
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationIpsecPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "radius", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusOutputReference\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusOutputReference Radius
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationTimeoutsOutputReference\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectoryAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzureActiveDirectoryAuthenticationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientRevokedCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationClientRevokedCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientRevokedCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientRootCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationClientRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientRootCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsecPolicyInput", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicy\"}", isOptional: true)]
        public virtual azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy? IpsecPolicyInput
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "radiusInput", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadius\"}", isOptional: true)]
        public virtual azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius? RadiusInput
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnAuthenticationTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpnAuthenticationTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnProtocolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpnProtocolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnAuthenticationTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpnAuthenticationTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpnProtocols
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
