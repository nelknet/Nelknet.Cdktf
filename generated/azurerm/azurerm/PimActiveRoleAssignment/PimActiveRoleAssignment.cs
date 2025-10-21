using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimActiveRoleAssignment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment azurerm_pim_active_role_assignment}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment), fullyQualifiedName: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentConfig\"}}]")]
    public class PimActiveRoleAssignment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment azurerm_pim_active_role_assignment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PimActiveRoleAssignment(Constructs.Construct scope, string id, azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PimActiveRoleAssignment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PimActiveRoleAssignment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a PimActiveRoleAssignment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PimActiveRoleAssignment to import.</param>
        /// <param name="importFromId">The id of the existing PimActiveRoleAssignment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PimActiveRoleAssignment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PimActiveRoleAssignment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PimActiveRoleAssignment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PimActiveRoleAssignment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentSchedule\"}}]")]
        public virtual void PutSchedule(azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTicket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTicket\"}}]")]
        public virtual void PutTicket(azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTicket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTicket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJustification")]
        public virtual void ResetJustification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTicket")]
        public virtual void ResetTicket()
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
        = GetStaticProperty<string>(typeof(azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment))!;

        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleOutputReference\"}")]
        public virtual azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "ticket", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTicketOutputReference\"}")]
        public virtual azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentTicketOutputReference Ticket
        {
            get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentTicketOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTimeoutsOutputReference\"}")]
        public virtual azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "justificationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JustificationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleDefinitionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleDefinitionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentSchedule\"}", isOptional: true)]
        public virtual azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentSchedule? ScheduleInput
        {
            get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ticketInput", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTicket\"}", isOptional: true)]
        public virtual azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTicket? TicketInput
        {
            get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTicket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleDefinitionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
