using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceAssignmentVirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set azurerm_maintenance_assignment_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet), fullyQualifiedName: "azurerm.maintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.maintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetConfig\"}}]")]
    public class MaintenanceAssignmentVirtualMachineScaleSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set azurerm_maintenance_assignment_virtual_machine_scale_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MaintenanceAssignmentVirtualMachineScaleSet(Constructs.Construct scope, string id, azurerm.MaintenanceAssignmentVirtualMachineScaleSet.IMaintenanceAssignmentVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MaintenanceAssignmentVirtualMachineScaleSet.IMaintenanceAssignmentVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MaintenanceAssignmentVirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MaintenanceAssignmentVirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MaintenanceAssignmentVirtualMachineScaleSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MaintenanceAssignmentVirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing MaintenanceAssignmentVirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MaintenanceAssignmentVirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MaintenanceAssignmentVirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MaintenanceAssignmentVirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MaintenanceAssignmentVirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.maintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MaintenanceAssignmentVirtualMachineScaleSet.IMaintenanceAssignmentVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MaintenanceAssignmentVirtualMachineScaleSet.IMaintenanceAssignmentVirtualMachineScaleSetTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.maintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "maintenanceConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.maintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineScaleSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualMachineScaleSetIdInput
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

        [JsiiProperty(name: "maintenanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineScaleSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
