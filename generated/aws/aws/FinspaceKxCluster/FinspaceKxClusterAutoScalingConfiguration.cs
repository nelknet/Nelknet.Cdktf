using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxCluster.FinspaceKxClusterAutoScalingConfiguration")]
    public class FinspaceKxClusterAutoScalingConfiguration : aws.FinspaceKxCluster.IFinspaceKxClusterAutoScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#auto_scaling_metric FinspaceKxCluster#auto_scaling_metric}.</summary>
        [JsiiProperty(name: "autoScalingMetric", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoScalingMetric
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#max_node_count FinspaceKxCluster#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxNodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#metric_target FinspaceKxCluster#metric_target}.</summary>
        [JsiiProperty(name: "metricTarget", typeJson: "{\"primitive\":\"number\"}")]
        public double MetricTarget
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#min_node_count FinspaceKxCluster#min_node_count}.</summary>
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinNodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scale_in_cooldown_seconds FinspaceKxCluster#scale_in_cooldown_seconds}.</summary>
        [JsiiProperty(name: "scaleInCooldownSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double ScaleInCooldownSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scale_out_cooldown_seconds FinspaceKxCluster#scale_out_cooldown_seconds}.</summary>
        [JsiiProperty(name: "scaleOutCooldownSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double ScaleOutCooldownSeconds
        {
            get;
            set;
        }
    }
}
