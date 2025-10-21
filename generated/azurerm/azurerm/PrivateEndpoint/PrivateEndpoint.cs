using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint azurerm_private_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.PrivateEndpoint.PrivateEndpoint), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointConfig\"}}]")]
    public class PrivateEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint azurerm_private_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PrivateEndpoint(Constructs.Construct scope, string id, azurerm.PrivateEndpoint.IPrivateEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.PrivateEndpoint.IPrivateEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrivateEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrivateEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a PrivateEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PrivateEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing PrivateEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PrivateEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PrivateEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PrivateEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PrivateEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.PrivateEndpoint.PrivateEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointIpConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIpConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.PrivateEndpoint.IPrivateEndpointIpConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.PrivateEndpoint.IPrivateEndpointIpConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.PrivateEndpoint.IPrivateEndpointIpConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateDnsZoneGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneGroup\"}}]")]
        public virtual void PutPrivateDnsZoneGroup(azurerm.PrivateEndpoint.IPrivateEndpointPrivateDnsZoneGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PrivateEndpoint.IPrivateEndpointPrivateDnsZoneGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateServiceConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateServiceConnection\"}}]")]
        public virtual void PutPrivateServiceConnection(azurerm.PrivateEndpoint.IPrivateEndpointPrivateServiceConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PrivateEndpoint.IPrivateEndpointPrivateServiceConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.PrivateEndpoint.IPrivateEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PrivateEndpoint.IPrivateEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomNetworkInterfaceName")]
        public virtual void ResetCustomNetworkInterfaceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpConfiguration")]
        public virtual void ResetIpConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDnsZoneGroup")]
        public virtual void ResetPrivateDnsZoneGroup()
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
        = GetStaticProperty<string>(typeof(azurerm.PrivateEndpoint.PrivateEndpoint))!;

        [JsiiProperty(name: "customDnsConfigs", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointCustomDnsConfigsList\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointCustomDnsConfigsList CustomDnsConfigs
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointCustomDnsConfigsList>()!;
        }

        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointIpConfigurationList\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointIpConfigurationList IpConfiguration
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointIpConfigurationList>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointNetworkInterfaceList\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "privateDnsZoneConfigs", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneConfigsList\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointPrivateDnsZoneConfigsList PrivateDnsZoneConfigs
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointPrivateDnsZoneConfigsList>()!;
        }

        [JsiiProperty(name: "privateDnsZoneGroup", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneGroupOutputReference\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointPrivateDnsZoneGroupOutputReference PrivateDnsZoneGroup
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointPrivateDnsZoneGroupOutputReference>()!;
        }

        [JsiiProperty(name: "privateServiceConnection", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateServiceConnectionOutputReference\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointPrivateServiceConnectionOutputReference PrivateServiceConnection
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointPrivateServiceConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointTimeoutsOutputReference\"}")]
        public virtual azurerm.PrivateEndpoint.PrivateEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.PrivateEndpointTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customNetworkInterfaceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomNetworkInterfaceNameInput
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
        [JsiiProperty(name: "ipConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointIpConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IpConfigurationInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "privateDnsZoneGroupInput", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneGroup\"}", isOptional: true)]
        public virtual azurerm.PrivateEndpoint.IPrivateEndpointPrivateDnsZoneGroup? PrivateDnsZoneGroupInput
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.IPrivateEndpointPrivateDnsZoneGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateServiceConnectionInput", typeJson: "{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointPrivateServiceConnection\"}", isOptional: true)]
        public virtual azurerm.PrivateEndpoint.IPrivateEndpointPrivateServiceConnection? PrivateServiceConnectionInput
        {
            get => GetInstanceProperty<azurerm.PrivateEndpoint.IPrivateEndpointPrivateServiceConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.privateEndpoint.PrivateEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "customNetworkInterfaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomNetworkInterfaceName
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
