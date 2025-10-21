using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SignalrServiceNetworkAcl
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl azurerm_signalr_service_network_acl}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl), fullyQualifiedName: "azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAcl", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclConfig\"}}]")]
    public class SignalrServiceNetworkAcl : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl azurerm_signalr_service_network_acl} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SignalrServiceNetworkAcl(Constructs.Construct scope, string id, azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignalrServiceNetworkAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignalrServiceNetworkAcl(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SignalrServiceNetworkAcl resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SignalrServiceNetworkAcl to import.</param>
        /// <param name="importFromId">The id of the existing SignalrServiceNetworkAcl that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SignalrServiceNetworkAcl to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SignalrServiceNetworkAcl to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SignalrServiceNetworkAcl that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SignalrServiceNetworkAcl to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPrivateEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPrivateEndpoint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateEndpoint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPrivateEndpoint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPrivateEndpoint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPrivateEndpoint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPublicNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetwork\"}}]")]
        public virtual void PutPublicNetwork(azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPublicNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPublicNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateEndpoint")]
        public virtual void ResetPrivateEndpoint()
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
        = GetStaticProperty<string>(typeof(azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl))!;

        [JsiiProperty(name: "privateEndpoint", typeJson: "{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPrivateEndpointList\"}")]
        public virtual azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclPrivateEndpointList PrivateEndpoint
        {
            get => GetInstanceProperty<azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclPrivateEndpointList>()!;
        }

        [JsiiProperty(name: "publicNetwork", typeJson: "{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetworkOutputReference\"}")]
        public virtual azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetworkOutputReference PublicNetwork
        {
            get => GetInstanceProperty<azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclTimeoutsOutputReference\"}")]
        public virtual azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPrivateEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateEndpointInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkInput", typeJson: "{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetwork\"}", isOptional: true)]
        public virtual azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPublicNetwork? PublicNetworkInput
        {
            get => GetInstanceProperty<azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPublicNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signalrServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignalrServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultAction
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

        [JsiiProperty(name: "signalrServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignalrServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
