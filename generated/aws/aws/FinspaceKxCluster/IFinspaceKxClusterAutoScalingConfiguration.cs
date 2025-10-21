using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxClusterAutoScalingConfiguration), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterAutoScalingConfiguration")]
    public interface IFinspaceKxClusterAutoScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#auto_scaling_metric FinspaceKxCluster#auto_scaling_metric}.</summary>
        [JsiiProperty(name: "autoScalingMetric", typeJson: "{\"primitive\":\"string\"}")]
        string AutoScalingMetric
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#max_node_count FinspaceKxCluster#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#metric_target FinspaceKxCluster#metric_target}.</summary>
        [JsiiProperty(name: "metricTarget", typeJson: "{\"primitive\":\"number\"}")]
        double MetricTarget
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#min_node_count FinspaceKxCluster#min_node_count}.</summary>
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scale_in_cooldown_seconds FinspaceKxCluster#scale_in_cooldown_seconds}.</summary>
        [JsiiProperty(name: "scaleInCooldownSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double ScaleInCooldownSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scale_out_cooldown_seconds FinspaceKxCluster#scale_out_cooldown_seconds}.</summary>
        [JsiiProperty(name: "scaleOutCooldownSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double ScaleOutCooldownSeconds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxClusterAutoScalingConfiguration), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterAutoScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxCluster.IFinspaceKxClusterAutoScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#auto_scaling_metric FinspaceKxCluster#auto_scaling_metric}.</summary>
            [JsiiProperty(name: "autoScalingMetric", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoScalingMetric
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#max_node_count FinspaceKxCluster#max_node_count}.</summary>
            [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#metric_target FinspaceKxCluster#metric_target}.</summary>
            [JsiiProperty(name: "metricTarget", typeJson: "{\"primitive\":\"number\"}")]
            public double MetricTarget
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#min_node_count FinspaceKxCluster#min_node_count}.</summary>
            [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scale_in_cooldown_seconds FinspaceKxCluster#scale_in_cooldown_seconds}.</summary>
            [JsiiProperty(name: "scaleInCooldownSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double ScaleInCooldownSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scale_out_cooldown_seconds FinspaceKxCluster#scale_out_cooldown_seconds}.</summary>
            [JsiiProperty(name: "scaleOutCooldownSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double ScaleOutCooldownSeconds
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
