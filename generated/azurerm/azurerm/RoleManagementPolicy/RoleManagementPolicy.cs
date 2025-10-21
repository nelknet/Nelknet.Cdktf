using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy azurerm_role_management_policy}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.RoleManagementPolicy.RoleManagementPolicy), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyConfig\"}}]")]
    public class RoleManagementPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy azurerm_role_management_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RoleManagementPolicy(Constructs.Construct scope, string id, azurerm.RoleManagementPolicy.IRoleManagementPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.RoleManagementPolicy.IRoleManagementPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RoleManagementPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RoleManagementPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a RoleManagementPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the RoleManagementPolicy to import.</param>
        /// <param name="importFromId">The id of the existing RoleManagementPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the RoleManagementPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the RoleManagementPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing RoleManagementPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the RoleManagementPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.RoleManagementPolicy.RoleManagementPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putActivationRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRules\"}}]")]
        public virtual void PutActivationRules(azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putActiveAssignmentRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRules\"}}]")]
        public virtual void PutActiveAssignmentRules(azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEligibleAssignmentRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules\"}}]")]
        public virtual void PutEligibleAssignmentRules(azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotificationRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules\"}}]")]
        public virtual void PutNotificationRules(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.RoleManagementPolicy.IRoleManagementPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivationRules")]
        public virtual void ResetActivationRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActiveAssignmentRules")]
        public virtual void ResetActiveAssignmentRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEligibleAssignmentRules")]
        public virtual void ResetEligibleAssignmentRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationRules")]
        public virtual void ResetNotificationRules()
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
        = GetStaticProperty<string>(typeof(azurerm.RoleManagementPolicy.RoleManagementPolicy))!;

        [JsiiProperty(name: "activationRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRulesOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyActivationRulesOutputReference ActivationRules
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyActivationRulesOutputReference>()!;
        }

        [JsiiProperty(name: "activeAssignmentRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRulesOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyActiveAssignmentRulesOutputReference ActiveAssignmentRules
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyActiveAssignmentRulesOutputReference>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eligibleAssignmentRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRulesOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyEligibleAssignmentRulesOutputReference EligibleAssignmentRules
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyEligibleAssignmentRulesOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationRules", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesOutputReference NotificationRules
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyTimeoutsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activationRulesInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActivationRules\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules? ActivationRulesInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyActivationRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeAssignmentRulesInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyActiveAssignmentRules\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules? ActiveAssignmentRulesInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyActiveAssignmentRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eligibleAssignmentRulesInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules? EligibleAssignmentRulesInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyEligibleAssignmentRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationRulesInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules? NotificationRulesInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleDefinitionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleDefinitionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyTimeouts\"}]}}", isOptional: true)]
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
