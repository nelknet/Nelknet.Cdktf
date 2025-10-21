using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRoleManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference), fullyQualifiedName: "azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminNotifications", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotificationsList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotificationsList AdminNotifications
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotificationsList>()!;
        }

        [JsiiProperty(name: "approverNotifications", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotificationsList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotificationsList ApproverNotifications
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotificationsList>()!;
        }

        [JsiiProperty(name: "assigneeNotifications", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotificationsList\"}")]
        public virtual azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotificationsList AssigneeNotifications
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivationsAssigneeNotificationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyNotificationRulesEligibleActivations\"}", isOptional: true)]
        public virtual azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyNotificationRulesEligibleActivations? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermRoleManagementPolicy.IDataAzurermRoleManagementPolicyNotificationRulesEligibleActivations?>();
            set => SetInstanceProperty(value);
        }
    }
}
