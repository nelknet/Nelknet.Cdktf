using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdminNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}}]")]
        public virtual void PutAdminNotifications(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApproverNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}}]")]
        public virtual void PutApproverNotifications(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssigneeNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}}]")]
        public virtual void PutAssigneeNotifications(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications)}, new object[]{@value});
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

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsOutputReference AdminNotifications
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsOutputReference ApproverNotifications
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsOutputReference\"}")]
        public virtual azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsOutputReference AssigneeNotifications
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminNotificationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications? AdminNotificationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverNotificationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotificationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assigneeNotificationsInput", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotificationsInput
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public virtual azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments? InternalValue
        {
            get => GetInstanceProperty<azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesActiveAssignments?>();
            set => SetInstanceProperty(value);
        }
    }
}
