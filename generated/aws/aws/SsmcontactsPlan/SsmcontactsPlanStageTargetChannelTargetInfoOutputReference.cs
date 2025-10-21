using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    [JsiiClass(nativeType: typeof(aws.SsmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfoOutputReference), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmcontactsPlanStageTargetChannelTargetInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmcontactsPlanStageTargetChannelTargetInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SsmcontactsPlanStageTargetChannelTargetInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmcontactsPlanStageTargetChannelTargetInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRetryIntervalInMinutes")]
        public virtual void ResetRetryIntervalInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "contactChannelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContactChannelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryIntervalInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryIntervalInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "contactChannelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactChannelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryIntervalInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo\"}", isOptional: true)]
        public virtual aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo? InternalValue
        {
            get => GetInstanceProperty<aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
