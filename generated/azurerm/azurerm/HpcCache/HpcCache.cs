using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache azurerm_hpc_cache}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.HpcCache.HpcCache), fullyQualifiedName: "azurerm.hpcCache.HpcCache", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheConfig\"}}]")]
    public class HpcCache : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache azurerm_hpc_cache} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HpcCache(Constructs.Construct scope, string id, azurerm.HpcCache.IHpcCacheConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.HpcCache.IHpcCacheConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HpcCache(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HpcCache(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a HpcCache resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HpcCache to import.</param>
        /// <param name="importFromId">The id of the existing HpcCache that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HpcCache to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HpcCache to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HpcCache that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HpcCache to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.HpcCache.HpcCache), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDefaultAccessPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDefaultAccessPolicy\"}}]")]
        public virtual void PutDefaultAccessPolicy(azurerm.HpcCache.IHpcCacheDefaultAccessPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheDefaultAccessPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDirectoryActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryActiveDirectory\"}}]")]
        public virtual void PutDirectoryActiveDirectory(azurerm.HpcCache.IHpcCacheDirectoryActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheDirectoryActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDirectoryFlatFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryFlatFile\"}}]")]
        public virtual void PutDirectoryFlatFile(azurerm.HpcCache.IHpcCacheDirectoryFlatFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheDirectoryFlatFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDirectoryLdap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdap\"}}]")]
        public virtual void PutDirectoryLdap(azurerm.HpcCache.IHpcCacheDirectoryLdap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheDirectoryLdap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDns\"}}]")]
        public virtual void PutDns(azurerm.HpcCache.IHpcCacheDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.HpcCache.IHpcCacheIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.HpcCache.IHpcCacheTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticallyRotateKeyToLatestEnabled")]
        public virtual void ResetAutomaticallyRotateKeyToLatestEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultAccessPolicy")]
        public virtual void ResetDefaultAccessPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirectoryActiveDirectory")]
        public virtual void ResetDirectoryActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirectoryFlatFile")]
        public virtual void ResetDirectoryFlatFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirectoryLdap")]
        public virtual void ResetDirectoryLdap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDns")]
        public virtual void ResetDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultKeyId")]
        public virtual void ResetKeyVaultKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtu")]
        public virtual void ResetMtu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNtpServer")]
        public virtual void ResetNtpServer()
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
        = GetStaticProperty<string>(typeof(azurerm.HpcCache.HpcCache))!;

        [JsiiProperty(name: "defaultAccessPolicy", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDefaultAccessPolicyOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheDefaultAccessPolicyOutputReference DefaultAccessPolicy
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheDefaultAccessPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "directoryActiveDirectory", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryActiveDirectoryOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheDirectoryActiveDirectoryOutputReference DirectoryActiveDirectory
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheDirectoryActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "directoryFlatFile", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryFlatFileOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheDirectoryFlatFileOutputReference DirectoryFlatFile
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheDirectoryFlatFileOutputReference>()!;
        }

        [JsiiProperty(name: "directoryLdap", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheDirectoryLdapOutputReference DirectoryLdap
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheDirectoryLdapOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDnsOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheDnsOutputReference Dns
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheDnsOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheIdentityOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "mountAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MountAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheTimeoutsOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticallyRotateKeyToLatestEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutomaticallyRotateKeyToLatestEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheSizeInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CacheSizeInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultAccessPolicyInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDefaultAccessPolicy\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDefaultAccessPolicy? DefaultAccessPolicyInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDefaultAccessPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryActiveDirectoryInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDirectoryActiveDirectory? DirectoryActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryFlatFileInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryFlatFile\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDirectoryFlatFile? DirectoryFlatFileInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryFlatFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryLdapInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdap\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDirectoryLdap? DirectoryLdapInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryLdap?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDns\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDns? DnsInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheIdentity\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MtuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ntpServerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NtpServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.hpcCache.HpcCacheTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "automaticallyRotateKeyToLatestEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutomaticallyRotateKeyToLatestEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "cacheSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheSizeInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultKeyId
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

        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Mtu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ntpServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NtpServer
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

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
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
    }
}
