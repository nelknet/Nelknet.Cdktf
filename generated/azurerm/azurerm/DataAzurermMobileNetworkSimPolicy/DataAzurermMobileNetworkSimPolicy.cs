using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkSimPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy azurerm_mobile_network_sim_policy}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyConfig\"}}]")]
    public class DataAzurermMobileNetworkSimPolicy : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy azurerm_mobile_network_sim_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermMobileNetworkSimPolicy(Constructs.Construct scope, string id, azurerm.DataAzurermMobileNetworkSimPolicy.IDataAzurermMobileNetworkSimPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermMobileNetworkSimPolicy.IDataAzurermMobileNetworkSimPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMobileNetworkSimPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMobileNetworkSimPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermMobileNetworkSimPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermMobileNetworkSimPolicy to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermMobileNetworkSimPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermMobileNetworkSimPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermMobileNetworkSimPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermMobileNetworkSimPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermMobileNetworkSimPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermMobileNetworkSimPolicy.IDataAzurermMobileNetworkSimPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermMobileNetworkSimPolicy.IDataAzurermMobileNetworkSimPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy))!;

        [JsiiProperty(name: "defaultSliceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSliceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ratFrequencySelectionPriorityIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RatFrequencySelectionPriorityIndex
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "registrationTimerInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RegistrationTimerInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "slice", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicySliceList\"}")]
        public virtual azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicySliceList Slice
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicySliceList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userEquipmentAggregateMaximumBitRate", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateList\"}")]
        public virtual azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateList UserEquipmentAggregateMaximumBitRate
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mobileNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MobileNetworkIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mobileNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MobileNetworkId
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
    }
}
