using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterLoggingInfoOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterLoggingInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterLoggingInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterLoggingInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterLoggingInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterLoggingInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBrokerLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogs\"}}]")]
        public virtual void PutBrokerLogs(aws.MskCluster.IMskClusterLoggingInfoBrokerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterLoggingInfoBrokerLogs)}, new object[]{@value});
        }

        [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterLoggingInfoBrokerLogsOutputReference BrokerLogs
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterLoggingInfoBrokerLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerLogsInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogs\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfoBrokerLogs? BrokerLogsInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfo? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
