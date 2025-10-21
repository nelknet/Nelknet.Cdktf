using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRoutePort
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port azurerm_express_route_port}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ExpressRoutePort.ExpressRoutePort), fullyQualifiedName: "azurerm.expressRoutePort.ExpressRoutePort", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortConfig\"}}]")]
    public class ExpressRoutePort : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port azurerm_express_route_port} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ExpressRoutePort(Constructs.Construct scope, string id, azurerm.ExpressRoutePort.IExpressRoutePortConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ExpressRoutePort.IExpressRoutePortConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ExpressRoutePort(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ExpressRoutePort(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ExpressRoutePort resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ExpressRoutePort to import.</param>
        /// <param name="importFromId">The id of the existing ExpressRoutePort that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ExpressRoutePort to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ExpressRoutePort to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ExpressRoutePort that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ExpressRoutePort to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ExpressRoutePort.ExpressRoutePort), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ExpressRoutePort.IExpressRoutePortIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ExpressRoutePort.IExpressRoutePortIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLink1", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortLink1\"}}]")]
        public virtual void PutLink1(azurerm.ExpressRoutePort.IExpressRoutePortLink1 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ExpressRoutePort.IExpressRoutePortLink1)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLink2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortLink2\"}}]")]
        public virtual void PutLink2(azurerm.ExpressRoutePort.IExpressRoutePortLink2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ExpressRoutePort.IExpressRoutePortLink2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ExpressRoutePort.IExpressRoutePortTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ExpressRoutePort.IExpressRoutePortTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBillingType")]
        public virtual void ResetBillingType()
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

        [JsiiMethod(name: "resetLink1")]
        public virtual void ResetLink1()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLink2")]
        public virtual void ResetLink2()
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
        = GetStaticProperty<string>(typeof(azurerm.ExpressRoutePort.ExpressRoutePort))!;

        [JsiiProperty(name: "ethertype", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ethertype
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "guid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Guid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortIdentityOutputReference\"}")]
        public virtual azurerm.ExpressRoutePort.ExpressRoutePortIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.ExpressRoutePortIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "link1", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortLink1OutputReference\"}")]
        public virtual azurerm.ExpressRoutePort.ExpressRoutePortLink1OutputReference Link1
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.ExpressRoutePortLink1OutputReference>()!;
        }

        [JsiiProperty(name: "link2", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortLink2OutputReference\"}")]
        public virtual azurerm.ExpressRoutePort.ExpressRoutePortLink2OutputReference Link2
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.ExpressRoutePortLink2OutputReference>()!;
        }

        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mtu
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortTimeoutsOutputReference\"}")]
        public virtual azurerm.ExpressRoutePort.ExpressRoutePortTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.ExpressRoutePortTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bandwidthInGbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BandwidthInGbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encapsulationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncapsulationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortIdentity\"}", isOptional: true)]
        public virtual azurerm.ExpressRoutePort.IExpressRoutePortIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.IExpressRoutePortIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "link1Input", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortLink1\"}", isOptional: true)]
        public virtual azurerm.ExpressRoutePort.IExpressRoutePortLink1? Link1Input
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.IExpressRoutePortLink1?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "link2Input", typeJson: "{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortLink2\"}", isOptional: true)]
        public virtual azurerm.ExpressRoutePort.IExpressRoutePortLink2? Link2Input
        {
            get => GetInstanceProperty<azurerm.ExpressRoutePort.IExpressRoutePortLink2?>();
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
        [JsiiProperty(name: "peeringLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeeringLocationInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.expressRoutePort.ExpressRoutePortTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bandwidthInGbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BandwidthInGbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "billingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encapsulation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Encapsulation
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

        [JsiiProperty(name: "peeringLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeringLocation
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
    }
}
