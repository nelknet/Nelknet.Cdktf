using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkAttachedDataNetwork
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network azurerm_mobile_network_attached_data_network}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork), fullyQualifiedName: "azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkConfig\"}}]")]
    public class MobileNetworkAttachedDataNetwork : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network azurerm_mobile_network_attached_data_network} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MobileNetworkAttachedDataNetwork(Constructs.Construct scope, string id, azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkAttachedDataNetwork(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkAttachedDataNetwork(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MobileNetworkAttachedDataNetwork resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MobileNetworkAttachedDataNetwork to import.</param>
        /// <param name="importFromId">The id of the existing MobileNetworkAttachedDataNetwork that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MobileNetworkAttachedDataNetwork to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MobileNetworkAttachedDataNetwork to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MobileNetworkAttachedDataNetwork that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MobileNetworkAttachedDataNetwork to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putNetworkAddressPortTranslation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslation\"}}]")]
        public virtual void PutNetworkAddressPortTranslation(azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkAddressPortTranslation")]
        public virtual void ResetNetworkAddressPortTranslation()
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

        [JsiiMethod(name: "resetUserEquipmentAddressPoolPrefixes")]
        public virtual void ResetUserEquipmentAddressPoolPrefixes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserEquipmentStaticAddressPoolPrefixes")]
        public virtual void ResetUserEquipmentStaticAddressPoolPrefixes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPlaneAccessIpv4Address")]
        public virtual void ResetUserPlaneAccessIpv4Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPlaneAccessIpv4Gateway")]
        public virtual void ResetUserPlaneAccessIpv4Gateway()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPlaneAccessIpv4Subnet")]
        public virtual void ResetUserPlaneAccessIpv4Subnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPlaneAccessName")]
        public virtual void ResetUserPlaneAccessName()
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
        = GetStaticProperty<string>(typeof(azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork))!;

        [JsiiProperty(name: "networkAddressPortTranslation", typeJson: "{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference\"}")]
        public virtual azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference NetworkAddressPortTranslation
        {
            get => GetInstanceProperty<azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkTimeoutsOutputReference\"}")]
        public virtual azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsAddressesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DnsAddressesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "mobileNetworkDataNetworkNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MobileNetworkDataNetworkNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mobileNetworkPacketCoreDataPlaneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MobileNetworkPacketCoreDataPlaneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkAddressPortTranslationInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslation\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation? NetworkAddressPortTranslationInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userEquipmentAddressPoolPrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UserEquipmentAddressPoolPrefixesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userEquipmentStaticAddressPoolPrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UserEquipmentStaticAddressPoolPrefixesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPlaneAccessIpv4AddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPlaneAccessIpv4AddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPlaneAccessIpv4GatewayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPlaneAccessIpv4GatewayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPlaneAccessIpv4SubnetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPlaneAccessIpv4SubnetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPlaneAccessNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPlaneAccessNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dnsAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsAddresses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "mobileNetworkDataNetworkName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MobileNetworkDataNetworkName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mobileNetworkPacketCoreDataPlaneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MobileNetworkPacketCoreDataPlaneId
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

        [JsiiProperty(name: "userEquipmentAddressPoolPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UserEquipmentAddressPoolPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userEquipmentStaticAddressPoolPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UserEquipmentStaticAddressPoolPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPlaneAccessIpv4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPlaneAccessIpv4Address
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPlaneAccessIpv4Gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPlaneAccessIpv4Gateway
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPlaneAccessIpv4Subnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPlaneAccessIpv4Subnet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPlaneAccessName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPlaneAccessName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
