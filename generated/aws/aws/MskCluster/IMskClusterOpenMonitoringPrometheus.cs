using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoringPrometheus), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoringPrometheus")]
    public interface IMskClusterOpenMonitoringPrometheus
    {
        /// <summary>jmx_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#jmx_exporter MskCluster#jmx_exporter}
        /// </remarks>
        [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporter
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#node_exporter MskCluster#node_exporter}
        /// </remarks>
        [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoringPrometheus), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoringPrometheus")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterOpenMonitoringPrometheus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>jmx_exporter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#jmx_exporter MskCluster#jmx_exporter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporter
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter?>();
            }

            /// <summary>node_exporter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#node_exporter MskCluster#node_exporter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporter
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter?>();
            }
        }
    }
}
