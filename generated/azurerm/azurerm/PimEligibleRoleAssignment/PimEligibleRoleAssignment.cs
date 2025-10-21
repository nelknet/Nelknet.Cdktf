using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment azurerm_pim_eligible_role_assignment}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentConfig\"}}]")]
    public class PimEligibleRoleAssignment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment azurerm_pim_eligible_role_assignment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PimEligibleRoleAssignment(Constructs.Construct scope, string id, azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PimEligibleRoleAssignment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PimEligibleRoleAssignment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a PimEligibleRoleAssignment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PimEligibleRoleAssignment to import.</param>
        /// <param name="importFromId">The id of the existing PimEligibleRoleAssignment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PimEligibleRoleAssignment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PimEligibleRoleAssignment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PimEligibleRoleAssignment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PimEligibleRoleAssignment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule\"}}]")]
        public virtual void PutSchedule(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTicket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket\"}}]")]
        public virtual void PutTicket(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment))!;

        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleOutputReference\"}")]
        public virtual azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "ticket", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicketOutputReference\"}")]
        public virtual azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentTicketOutputReference Ticket
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentTicketOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeoutsOutputReference\"}")]
        public virtual azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule\"}", isOptional: true)]
        public virtual azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule? ScheduleInput
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ticketInput", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket\"}", isOptional: true)]
        public virtual azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket? TicketInput
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeouts\"}]}}", isOptional: true)]
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
