using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkPacketCoreControlPlane
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane azurerm_mobile_network_packet_core_control_plane}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane), fullyQualifiedName: "azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneConfig\"}}]")]
    public class MobileNetworkPacketCoreControlPlane : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane azurerm_mobile_network_packet_core_control_plane} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MobileNetworkPacketCoreControlPlane(Constructs.Construct scope, string id, azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkPacketCoreControlPlane(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkPacketCoreControlPlane(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MobileNetworkPacketCoreControlPlane resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MobileNetworkPacketCoreControlPlane to import.</param>
        /// <param name="importFromId">The id of the existing MobileNetworkPacketCoreControlPlane that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MobileNetworkPacketCoreControlPlane to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MobileNetworkPacketCoreControlPlane to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MobileNetworkPacketCoreControlPlane that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MobileNetworkPacketCoreControlPlane to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalDiagnosticsAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess\"}}]")]
        public virtual void PutLocalDiagnosticsAccess(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlatform", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatform\"}}]")]
        public virtual void PutPlatform(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlanePlatform @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlanePlatform)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetControlPlaneAccessIpv4Address")]
        public virtual void ResetControlPlaneAccessIpv4Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetControlPlaneAccessIpv4Gateway")]
        public virtual void ResetControlPlaneAccessIpv4Gateway()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetControlPlaneAccessIpv4Subnet")]
        public virtual void ResetControlPlaneAccessIpv4Subnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetControlPlaneAccessName")]
        public virtual void ResetControlPlaneAccessName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreNetworkTechnology")]
        public virtual void ResetCoreNetworkTechnology()
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

        [JsiiMethod(name: "resetInteroperabilitySettingsJson")]
        public virtual void ResetInteroperabilitySettingsJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatform")]
        public virtual void ResetPlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareVersion")]
        public virtual void ResetSoftwareVersion()
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

        [JsiiMethod(name: "resetUserEquipmentMtuInBytes")]
        public virtual void ResetUserEquipmentMtuInBytes()
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
        = GetStaticProperty<string>(typeof(azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneIdentityOutputReference\"}")]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "localDiagnosticsAccess", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessOutputReference\"}")]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessOutputReference LocalDiagnosticsAccess
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessOutputReference>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatformOutputReference\"}")]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatformOutputReference Platform
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatformOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneTimeoutsOutputReference\"}")]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlaneAccessIpv4AddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ControlPlaneAccessIpv4AddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlaneAccessIpv4GatewayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ControlPlaneAccessIpv4GatewayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlaneAccessIpv4SubnetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ControlPlaneAccessIpv4SubnetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlaneAccessNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ControlPlaneAccessNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreNetworkTechnologyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CoreNetworkTechnologyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneIdentity\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interoperabilitySettingsJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InteroperabilitySettingsJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localDiagnosticsAccessInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess? LocalDiagnosticsAccessInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess?>();
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
        [JsiiProperty(name: "platformInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatform\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlanePlatform? PlatformInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlanePlatform?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "siteIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SiteIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftwareVersionInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userEquipmentMtuInBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UserEquipmentMtuInBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "controlPlaneAccessIpv4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlPlaneAccessIpv4Address
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "controlPlaneAccessIpv4Gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlPlaneAccessIpv4Gateway
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "controlPlaneAccessIpv4Subnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlPlaneAccessIpv4Subnet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "controlPlaneAccessName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlPlaneAccessName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "coreNetworkTechnology", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreNetworkTechnology
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

        [JsiiProperty(name: "interoperabilitySettingsJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InteroperabilitySettingsJson
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

        [JsiiProperty(name: "siteIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SiteIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareVersion
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

        [JsiiProperty(name: "userEquipmentMtuInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UserEquipmentMtuInBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
