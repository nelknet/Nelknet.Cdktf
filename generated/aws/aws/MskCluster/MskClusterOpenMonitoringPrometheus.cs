using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterOpenMonitoringPrometheus")]
    public class MskClusterOpenMonitoringPrometheus : aws.MskCluster.IMskClusterOpenMonitoringPrometheus
    {
        /// <summary>jmx_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#jmx_exporter MskCluster#jmx_exporter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporter
        {
            get;
            set;
        }

        /// <summary>node_exporter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#node_exporter MskCluster#node_exporter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporter
        {
            get;
            set;
        }
    }
}
