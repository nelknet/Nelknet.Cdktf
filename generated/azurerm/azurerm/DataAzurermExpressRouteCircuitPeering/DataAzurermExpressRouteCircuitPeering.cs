using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExpressRouteCircuitPeering
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering azurerm_express_route_circuit_peering}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering), fullyQualifiedName: "azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringConfig\"}}]")]
    public class DataAzurermExpressRouteCircuitPeering : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering azurerm_express_route_circuit_peering} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermExpressRouteCircuitPeering(Constructs.Construct scope, string id, azurerm.DataAzurermExpressRouteCircuitPeering.IDataAzurermExpressRouteCircuitPeeringConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermExpressRouteCircuitPeering.IDataAzurermExpressRouteCircuitPeeringConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermExpressRouteCircuitPeering(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermExpressRouteCircuitPeering(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermExpressRouteCircuitPeering resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermExpressRouteCircuitPeering to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermExpressRouteCircuitPeering that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermExpressRouteCircuitPeering to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermExpressRouteCircuitPeering to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermExpressRouteCircuitPeering that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermExpressRouteCircuitPeering to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermExpressRouteCircuitPeering.IDataAzurermExpressRouteCircuitPeeringTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermExpressRouteCircuitPeering.IDataAzurermExpressRouteCircuitPeeringTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering))!;

        [JsiiProperty(name: "azureAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AzureAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gatewayManagerEtag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayManagerEtag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4Enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Ipv4Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "primaryAzurePort", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAzurePort
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryPeerAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeFilterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteFilterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryAzurePort", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAzurePort
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryPeerAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VlanId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expressRouteCircuitNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpressRouteCircuitNameInput
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
        [JsiiProperty(name: "peeringTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeeringTypeInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "expressRouteCircuitName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpressRouteCircuitName
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

        [JsiiProperty(name: "peeringType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeringType
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
    }
}
