using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticSanVolumeGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group azurerm_elastic_san_volume_group}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup), fullyQualifiedName: "azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupConfig\"}}]")]
    public class ElasticSanVolumeGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group azurerm_elastic_san_volume_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticSanVolumeGroup(Constructs.Construct scope, string id, azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticSanVolumeGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticSanVolumeGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElasticSanVolumeGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElasticSanVolumeGroup to import.</param>
        /// <param name="importFromId">The id of the existing ElasticSanVolumeGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElasticSanVolumeGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElasticSanVolumeGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElasticSanVolumeGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElasticSanVolumeGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupEncryption\"}}]")]
        public virtual void PutEncryption(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupNetworkRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupNetworkRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupNetworkRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupNetworkRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionType")]
        public virtual void ResetEncryptionType()
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

        [JsiiMethod(name: "resetNetworkRule")]
        public virtual void ResetNetworkRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocolType")]
        public virtual void ResetProtocolType()
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
        = GetStaticProperty<string>(typeof(azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup))!;

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupEncryptionOutputReference\"}")]
        public virtual azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupIdentityOutputReference\"}")]
        public virtual azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "networkRule", typeJson: "{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupNetworkRuleList\"}")]
        public virtual azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupNetworkRuleList NetworkRule
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupNetworkRuleList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupTimeoutsOutputReference\"}")]
        public virtual azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticSanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticSanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupEncryption\"}", isOptional: true)]
        public virtual azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupEncryption? EncryptionInput
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupIdentity\"}", isOptional: true)]
        public virtual azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolumeGroup.IElasticSanVolumeGroupIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "networkRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupNetworkRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.elasticSanVolumeGroup.ElasticSanVolumeGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "elasticSanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticSanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
