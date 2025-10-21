using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsOutputReference), fullyQualifiedName: "azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermStorageManagementPolicyRuleActionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermStorageManagementPolicyRuleActionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermStorageManagementPolicyRuleActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStorageManagementPolicyRuleActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "baseBlob", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsBaseBlobList\"}")]
        public virtual azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsBaseBlobList BaseBlob
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsBaseBlobList>()!;
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsSnapshotList\"}")]
        public virtual azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsSnapshotList Snapshot
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsSnapshotList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsVersionList\"}")]
        public virtual azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsVersionList Version
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsVersionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActions\"}", isOptional: true)]
        public virtual azurerm.DataAzurermStorageManagementPolicy.IDataAzurermStorageManagementPolicyRuleActions? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageManagementPolicy.IDataAzurermStorageManagementPolicyRuleActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
