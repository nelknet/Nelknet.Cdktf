using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference), fullyQualifiedName: "azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsList AdminNotifications
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsAdminNotificationsList>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsList ApproverNotifications
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsApproverNotificationsList>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsList AssigneeNotifications
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignmentsAssigneeNotificationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesActiveAssignments\"}", isOptional: true)]
        public virtual azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyNotificationRulesActiveAssignments? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyNotificationRulesActiveAssignments?>();
            set => SetInstanceProperty(value);
        }
    }
}
