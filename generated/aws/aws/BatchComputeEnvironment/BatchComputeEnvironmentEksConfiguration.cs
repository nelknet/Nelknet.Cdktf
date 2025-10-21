using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchComputeEnvironment.BatchComputeEnvironmentEksConfiguration")]
    public class BatchComputeEnvironmentEksConfiguration : aws.BatchComputeEnvironment.IBatchComputeEnvironmentEksConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#eks_cluster_arn BatchComputeEnvironment#eks_cluster_arn}.</summary>
        [JsiiProperty(name: "eksClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string EksClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#kubernetes_namespace BatchComputeEnvironment#kubernetes_namespace}.</summary>
        [JsiiProperty(name: "kubernetesNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public string KubernetesNamespace
        {
            get;
            set;
        }
    }
}
