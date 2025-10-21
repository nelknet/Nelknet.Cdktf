using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterOpenMonitoringPrometheusOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoringPrometheusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterOpenMonitoringPrometheusOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterOpenMonitoringPrometheusOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterOpenMonitoringPrometheusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterOpenMonitoringPrometheusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJmxExporter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter\"}}]")]
        public virtual void PutJmxExporter(aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeExporter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusNodeExporter\"}}]")]
        public virtual void PutNodeExporter(aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJmxExporter")]
        public virtual void ResetJmxExporter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeExporter")]
        public virtual void ResetNodeExporter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporterOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterOpenMonitoringPrometheusJmxExporterOutputReference JmxExporter
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterOpenMonitoringPrometheusJmxExporterOutputReference>()!;
        }

        [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusNodeExporterOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterOpenMonitoringPrometheusNodeExporterOutputReference NodeExporter
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterOpenMonitoringPrometheusNodeExporterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jmxExporterInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporterInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeExporterInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporterInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheus\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterOpenMonitoringPrometheus? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheus?>();
            set => SetInstanceProperty(value);
        }
    }
}
