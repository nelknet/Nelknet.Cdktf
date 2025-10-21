using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxCluster.FinspaceKxClusterScalingGroupConfiguration")]
    public class FinspaceKxClusterScalingGroupConfiguration : aws.FinspaceKxCluster.IFinspaceKxClusterScalingGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#memory_reservation FinspaceKxCluster#memory_reservation}.</summary>
        [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}")]
        public double MemoryReservation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#node_count FinspaceKxCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double NodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scaling_group_name FinspaceKxCluster#scaling_group_name}.</summary>
        [JsiiProperty(name: "scalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ScalingGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cpu FinspaceKxCluster#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#memory_limit FinspaceKxCluster#memory_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryLimit
        {
            get;
            set;
        }
    }
}
