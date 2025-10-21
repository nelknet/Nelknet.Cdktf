using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchCompositeAlarm
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressorOutputReference), fullyQualifiedName: "aws.cloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchCompositeAlarmActionsSuppressorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchCompositeAlarmActionsSuppressorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchCompositeAlarmActionsSuppressorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchCompositeAlarmActionsSuppressorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlarmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExtensionPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "alarm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alarm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extensionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExtensionPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressor\"}", isOptional: true)]
        public virtual aws.CloudwatchCompositeAlarm.ICloudwatchCompositeAlarmActionsSuppressor? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchCompositeAlarm.ICloudwatchCompositeAlarmActionsSuppressor?>();
            set => SetInstanceProperty(value);
        }
    }
}
