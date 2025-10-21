using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RoleManagementPolicyNotificationRulesEligibleAssignmentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdminNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}}]")]
        public virtual void PutAdminNotifications(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApproverNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}}]")]
        public virtual void PutApproverNotifications(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssigneeNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}}]")]
        public virtual void PutAssigneeNotifications(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminNotifications")]
        public virtual void ResetAdminNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApproverNotifications")]
        public virtual void ResetApproverNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAssigneeNotifications")]
        public virtual void ResetAssigneeNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotificationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotificationsOutputReference AdminNotifications
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotificationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotificationsOutputReference ApproverNotifications
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotificationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotificationsOutputReference AssigneeNotifications
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotificationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminNotificationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotificationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAdminNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverNotificationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotificationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsApproverNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotificationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotificationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignmentsAssigneeNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleAssignments\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments? InternalValue
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleAssignments?>();
            set => SetInstanceProperty(value);
        }
    }
}
