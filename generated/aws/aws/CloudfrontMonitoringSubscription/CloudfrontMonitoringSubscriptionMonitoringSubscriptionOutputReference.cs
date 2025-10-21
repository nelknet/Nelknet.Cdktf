using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMonitoringSubscription
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference), fullyQualifiedName: "aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRealtimeMetricsSubscriptionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig\"}}]")]
        public virtual void PutRealtimeMetricsSubscriptionConfig(aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "realtimeMetricsSubscriptionConfig", typeJson: "{\"fqn\":\"aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfigOutputReference\"}")]
        public virtual aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfigOutputReference RealtimeMetricsSubscriptionConfig
        {
            get => GetInstanceProperty<aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "realtimeMetricsSubscriptionConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig? RealtimeMetricsSubscriptionConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscription\"}", isOptional: true)]
        public virtual aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscription? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontMonitoringSubscription.ICloudfrontMonitoringSubscriptionMonitoringSubscription?>();
            set => SetInstanceProperty(value);
        }
    }
}
