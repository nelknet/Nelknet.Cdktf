using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set azurerm_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet), fullyQualifiedName: "azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetConfig\"}}]")]
    public class DataAzurermVirtualMachineScaleSet : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set azurerm_virtual_machine_scale_set} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermVirtualMachineScaleSet(Constructs.Construct scope, string id, azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermVirtualMachineScaleSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermVirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermVirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermVirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermVirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermVirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermVirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetIdentityList\"}")]
        public virtual azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetIdentityList>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetInstancesList\"}")]
        public virtual azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetInstancesList Instances
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetInstancesList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceList\"}")]
        public virtual azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
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
