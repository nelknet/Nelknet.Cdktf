using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsBaseBlobOutputReference), fullyQualifiedName: "azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsBaseBlobOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermStorageManagementPolicyRuleActionsBaseBlobOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermStorageManagementPolicyRuleActionsBaseBlobOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermStorageManagementPolicyRuleActionsBaseBlobOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStorageManagementPolicyRuleActionsBaseBlobOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoTierToHotFromCoolEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutoTierToHotFromCoolEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "deleteAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deleteAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deleteAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastTierChangeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToColdAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToColdAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToColdAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToColdAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToColdAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToCoolAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToCoolAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToCoolAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToCoolAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tierToCoolAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToCoolAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyRuleActionsBaseBlob\"}", isOptional: true)]
        public virtual azurerm.DataAzurermStorageManagementPolicy.IDataAzurermStorageManagementPolicyRuleActionsBaseBlob? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageManagementPolicy.IDataAzurermStorageManagementPolicyRuleActionsBaseBlob?>();
            set => SetInstanceProperty(value);
        }
    }
}
