using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevTestVirtualNetwork
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network azurerm_dev_test_virtual_network}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork), fullyQualifiedName: "azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkConfig\"}}]")]
    public class DataAzurermDevTestVirtualNetwork : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network azurerm_dev_test_virtual_network} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermDevTestVirtualNetwork(Constructs.Construct scope, string id, azurerm.DataAzurermDevTestVirtualNetwork.IDataAzurermDevTestVirtualNetworkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermDevTestVirtualNetwork.IDataAzurermDevTestVirtualNetworkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDevTestVirtualNetwork(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDevTestVirtualNetwork(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermDevTestVirtualNetwork resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermDevTestVirtualNetwork to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermDevTestVirtualNetwork that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermDevTestVirtualNetwork to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermDevTestVirtualNetwork to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermDevTestVirtualNetwork that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermDevTestVirtualNetwork to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermDevTestVirtualNetwork.IDataAzurermDevTestVirtualNetworkTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermDevTestVirtualNetwork.IDataAzurermDevTestVirtualNetworkTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork))!;

        [JsiiProperty(name: "allowedSubnets", typeJson: "{\"fqn\":\"azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkAllowedSubnetsList\"}")]
        public virtual azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkAllowedSubnetsList AllowedSubnets
        {
            get => GetInstanceProperty<azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkAllowedSubnetsList>()!;
        }

        [JsiiProperty(name: "subnetOverrides", typeJson: "{\"fqn\":\"azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkSubnetOverridesList\"}")]
        public virtual azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkSubnetOverridesList SubnetOverrides
        {
            get => GetInstanceProperty<azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkSubnetOverridesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UniqueIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LabNameInput
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "labName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabName
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
    }
}
