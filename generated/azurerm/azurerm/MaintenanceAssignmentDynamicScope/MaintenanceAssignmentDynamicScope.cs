using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceAssignmentDynamicScope
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope azurerm_maintenance_assignment_dynamic_scope}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope), fullyQualifiedName: "azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeConfig\"}}]")]
    public class MaintenanceAssignmentDynamicScope : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope azurerm_maintenance_assignment_dynamic_scope} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MaintenanceAssignmentDynamicScope(Constructs.Construct scope, string id, azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MaintenanceAssignmentDynamicScope(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MaintenanceAssignmentDynamicScope(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MaintenanceAssignmentDynamicScope resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MaintenanceAssignmentDynamicScope to import.</param>
        /// <param name="importFromId">The id of the existing MaintenanceAssignmentDynamicScope that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MaintenanceAssignmentDynamicScope to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MaintenanceAssignmentDynamicScope to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MaintenanceAssignmentDynamicScope that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MaintenanceAssignmentDynamicScope to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilter\"}}]")]
        public virtual void PutFilter(azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilterOutputReference\"}")]
        public virtual azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilterOutputReference Filter
        {
            get => GetInstanceProperty<azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilterOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeTimeoutsOutputReference\"}")]
        public virtual azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilter\"}", isOptional: true)]
        public virtual azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeFilter? FilterInput
        {
            get => GetInstanceProperty<azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "maintenanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceConfigurationId
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
