using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterLoggingInfoBrokerLogsOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterLoggingInfoBrokerLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterLoggingInfoBrokerLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterLoggingInfoBrokerLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterLoggingInfoBrokerLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterLoggingInfoBrokerLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsFirehose\"}}]")]
        public virtual void PutFirehose(aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsS3\"}}]")]
        public virtual void PutS3(aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogsOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsFirehoseOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterLoggingInfoBrokerLogsFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterLoggingInfoBrokerLogsFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsS3OutputReference\"}")]
        public virtual aws.MskCluster.MskClusterLoggingInfoBrokerLogsS3OutputReference S3
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterLoggingInfoBrokerLogsS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3? S3Input
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogs\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfoBrokerLogs? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
