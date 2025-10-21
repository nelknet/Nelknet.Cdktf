using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsmincidentsResponsePlan
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanActionSsmAutomationOutputReference), fullyQualifiedName: "aws.dataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanActionSsmAutomationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSsmincidentsResponsePlanActionSsmAutomationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSsmincidentsResponsePlanActionSsmAutomationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsSsmincidentsResponsePlanActionSsmAutomationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSsmincidentsResponsePlanActionSsmAutomationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "documentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dynamicParameters", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap DynamicParameters
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "parameter", typeJson: "{\"fqn\":\"aws.dataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanActionSsmAutomationParameterList\"}")]
        public virtual aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanActionSsmAutomationParameterList Parameter
        {
            get => GetInstanceProperty<aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanActionSsmAutomationParameterList>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanActionSsmAutomation\"}", isOptional: true)]
        public virtual aws.DataAwsSsmincidentsResponsePlan.IDataAwsSsmincidentsResponsePlanActionSsmAutomation? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSsmincidentsResponsePlan.IDataAwsSsmincidentsResponsePlanActionSsmAutomation?>();
            set => SetInstanceProperty(value);
        }
    }
}
