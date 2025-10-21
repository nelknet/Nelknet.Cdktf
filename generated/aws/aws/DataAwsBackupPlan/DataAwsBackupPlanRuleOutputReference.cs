using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBackupPlan
{
    [JsiiClass(nativeType: typeof(aws.DataAwsBackupPlan.DataAwsBackupPlanRuleOutputReference), fullyQualifiedName: "aws.dataAwsBackupPlan.DataAwsBackupPlanRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsBackupPlanRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsBackupPlanRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsBackupPlanRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBackupPlanRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "completionWindow", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletionWindow
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "copyAction", typeJson: "{\"fqn\":\"aws.dataAwsBackupPlan.DataAwsBackupPlanRuleCopyActionList\"}")]
        public virtual aws.DataAwsBackupPlan.DataAwsBackupPlanRuleCopyActionList CopyAction
        {
            get => GetInstanceProperty<aws.DataAwsBackupPlan.DataAwsBackupPlanRuleCopyActionList>()!;
        }

        [JsiiProperty(name: "enableContinuousBackup", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnableContinuousBackup
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"aws.dataAwsBackupPlan.DataAwsBackupPlanRuleLifecycleList\"}")]
        public virtual aws.DataAwsBackupPlan.DataAwsBackupPlanRuleLifecycleList Lifecycle
        {
            get => GetInstanceProperty<aws.DataAwsBackupPlan.DataAwsBackupPlanRuleLifecycleList>()!;
        }

        [JsiiProperty(name: "recoveryPointTags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap RecoveryPointTags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleExpressionTimezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleExpressionTimezone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startWindow", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartWindow
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetVaultName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetVaultName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsBackupPlan.DataAwsBackupPlanRule\"}", isOptional: true)]
        public virtual aws.DataAwsBackupPlan.IDataAwsBackupPlanRule? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsBackupPlan.IDataAwsBackupPlanRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
