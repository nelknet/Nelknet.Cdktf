using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsmPatchBaseline
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineApprovalRuleOutputReference), fullyQualifiedName: "aws.dataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineApprovalRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSsmPatchBaselineApprovalRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSsmPatchBaselineApprovalRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsSsmPatchBaselineApprovalRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSsmPatchBaselineApprovalRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApproveAfterDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "approveUntilDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproveUntilDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComplianceLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnableNonSecurity
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "patchFilter", typeJson: "{\"fqn\":\"aws.dataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineApprovalRulePatchFilterList\"}")]
        public virtual aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineApprovalRulePatchFilterList PatchFilter
        {
            get => GetInstanceProperty<aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineApprovalRulePatchFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineApprovalRule\"}", isOptional: true)]
        public virtual aws.DataAwsSsmPatchBaseline.IDataAwsSsmPatchBaselineApprovalRule? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSsmPatchBaseline.IDataAwsSsmPatchBaselineApprovalRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
