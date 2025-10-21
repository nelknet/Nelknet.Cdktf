using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesOutputReference), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RoleManagementPolicyNotificationRulesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RoleManagementPolicyNotificationRulesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RoleManagementPolicyNotificationRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RoleManagementPolicyNotificationRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveAssignments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignments\"}}]")]
        public virtual void PutActiveAssignments(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEligibleActivations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations\"}}]")]
        public virtual void PutEligibleActivations(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEligibleAssignments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments\"}}]")]
        public virtual void PutEligibleAssignments(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveAssignments")]
        public virtual void ResetActiveAssignments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEligibleActivations")]
        public virtual void ResetEligibleActivations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEligibleAssignments")]
        public virtual void ResetEligibleAssignments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference ActiveAssignments
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference>()!;
        }

        [JsiiProperty(name: "eligibleActivations", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsOutputReference EligibleActivations
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsOutputReference>()!;
        }

        [JsiiProperty(name: "eligibleAssignments", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference EligibleAssignments
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeAssignmentsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments? ActiveAssignmentsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eligibleActivationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations? EligibleActivationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivations?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eligibleAssignmentsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments? EligibleAssignmentsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRules\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules? InternalValue
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
