using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkFunctionCollectorPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy azurerm_network_function_collector_policy}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy), fullyQualifiedName: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyConfig\"}}]")]
    public class NetworkFunctionCollectorPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy azurerm_network_function_collector_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkFunctionCollectorPolicy(Constructs.Construct scope, string id, azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFunctionCollectorPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFunctionCollectorPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a NetworkFunctionCollectorPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkFunctionCollectorPolicy to import.</param>
        /// <param name="importFromId">The id of the existing NetworkFunctionCollectorPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkFunctionCollectorPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkFunctionCollectorPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkFunctionCollectorPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkFunctionCollectorPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIpfxEmission", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmission\"}}]")]
        public virtual void PutIpfxEmission(azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxEmission @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxEmission)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpfxIngestion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestion\"}}]")]
        public virtual void PutIpfxIngestion(azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxIngestion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxIngestion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy))!;

        [JsiiProperty(name: "ipfxEmission", typeJson: "{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmissionOutputReference\"}")]
        public virtual azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmissionOutputReference IpfxEmission
        {
            get => GetInstanceProperty<azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmissionOutputReference>()!;
        }

        [JsiiProperty(name: "ipfxIngestion", typeJson: "{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestionOutputReference\"}")]
        public virtual azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestionOutputReference IpfxIngestion
        {
            get => GetInstanceProperty<azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestionOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyTimeoutsOutputReference\"}")]
        public virtual azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipfxEmissionInput", typeJson: "{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmission\"}", isOptional: true)]
        public virtual azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxEmission? IpfxEmissionInput
        {
            get => GetInstanceProperty<azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxEmission?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipfxIngestionInput", typeJson: "{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestion\"}", isOptional: true)]
        public virtual azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxIngestion? IpfxIngestionInput
        {
            get => GetInstanceProperty<azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxIngestion?>();
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficCollectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrafficCollectorIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficCollectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficCollectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
