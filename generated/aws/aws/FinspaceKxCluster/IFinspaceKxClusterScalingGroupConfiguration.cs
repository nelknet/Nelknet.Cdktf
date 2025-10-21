using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxClusterScalingGroupConfiguration), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterScalingGroupConfiguration")]
    public interface IFinspaceKxClusterScalingGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#memory_reservation FinspaceKxCluster#memory_reservation}.</summary>
        [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryReservation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#node_count FinspaceKxCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scaling_group_name FinspaceKxCluster#scaling_group_name}.</summary>
        [JsiiProperty(name: "scalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ScalingGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cpu FinspaceKxCluster#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#memory_limit FinspaceKxCluster#memory_limit}.</summary>
        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxClusterScalingGroupConfiguration), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterScalingGroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxCluster.IFinspaceKxClusterScalingGroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#memory_reservation FinspaceKxCluster#memory_reservation}.</summary>
            [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryReservation
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#node_count FinspaceKxCluster#node_count}.</summary>
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scaling_group_name FinspaceKxCluster#scaling_group_name}.</summary>
            [JsiiProperty(name: "scalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ScalingGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cpu FinspaceKxCluster#cpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cpu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#memory_limit FinspaceKxCluster#memory_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryLimit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
