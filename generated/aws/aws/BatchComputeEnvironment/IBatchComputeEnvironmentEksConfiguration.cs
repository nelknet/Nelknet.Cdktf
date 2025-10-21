using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentEksConfiguration), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironmentEksConfiguration")]
    public interface IBatchComputeEnvironmentEksConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#eks_cluster_arn BatchComputeEnvironment#eks_cluster_arn}.</summary>
        [JsiiProperty(name: "eksClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string EksClusterArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#kubernetes_namespace BatchComputeEnvironment#kubernetes_namespace}.</summary>
        [JsiiProperty(name: "kubernetesNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string KubernetesNamespace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentEksConfiguration), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironmentEksConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BatchComputeEnvironment.IBatchComputeEnvironmentEksConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#eks_cluster_arn BatchComputeEnvironment#eks_cluster_arn}.</summary>
            [JsiiProperty(name: "eksClusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string EksClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#kubernetes_namespace BatchComputeEnvironment#kubernetes_namespace}.</summary>
            [JsiiProperty(name: "kubernetesNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string KubernetesNamespace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
