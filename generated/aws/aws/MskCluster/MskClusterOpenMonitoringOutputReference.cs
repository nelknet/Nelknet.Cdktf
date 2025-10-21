using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterOpenMonitoringOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoringOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterOpenMonitoringOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterOpenMonitoringOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterOpenMonitoringOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterOpenMonitoringOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrometheus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheus\"}}]")]
        public virtual void PutPrometheus(aws.MskCluster.IMskClusterOpenMonitoringPrometheus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterOpenMonitoringPrometheus)}, new object[]{@value});
        }

        [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterOpenMonitoringPrometheusOutputReference Prometheus
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterOpenMonitoringPrometheusOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prometheusInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheus\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterOpenMonitoringPrometheus? PrometheusInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheus?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoring\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterOpenMonitoring? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoring?>();
            set => SetInstanceProperty(value);
        }
    }
}
