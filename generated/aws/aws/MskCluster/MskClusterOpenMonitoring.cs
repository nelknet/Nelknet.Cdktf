using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskCluster.MskClusterOpenMonitoring")]
    public class MskClusterOpenMonitoring : aws.MskCluster.IMskClusterOpenMonitoring
    {
        /// <summary>prometheus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#prometheus MskCluster#prometheus}
        /// </remarks>
        [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheus\"}")]
        public aws.MskCluster.IMskClusterOpenMonitoringPrometheus Prometheus
        {
            get;
            set;
        }
    }
}
