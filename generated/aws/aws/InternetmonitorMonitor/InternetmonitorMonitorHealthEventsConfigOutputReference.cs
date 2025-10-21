using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    [JsiiClass(nativeType: typeof(aws.InternetmonitorMonitor.InternetmonitorMonitorHealthEventsConfigOutputReference), fullyQualifiedName: "aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InternetmonitorMonitorHealthEventsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InternetmonitorMonitorHealthEventsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InternetmonitorMonitorHealthEventsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InternetmonitorMonitorHealthEventsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAvailabilityScoreThreshold")]
        public virtual void ResetAvailabilityScoreThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceScoreThreshold")]
        public virtual void ResetPerformanceScoreThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityScoreThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AvailabilityScoreThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceScoreThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PerformanceScoreThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "availabilityScoreThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailabilityScoreThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "performanceScoreThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PerformanceScoreThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig\"}", isOptional: true)]
        public virtual aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
