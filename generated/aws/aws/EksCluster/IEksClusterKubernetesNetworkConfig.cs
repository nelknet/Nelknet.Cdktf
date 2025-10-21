using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubernetesNetworkConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubernetesNetworkConfig")]
    public interface IEksClusterKubernetesNetworkConfig
    {
        /// <summary>elastic_load_balancing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#elastic_load_balancing EksCluster#elastic_load_balancing}
        /// </remarks>
        [JsiiProperty(name: "elasticLoadBalancing", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing? ElasticLoadBalancing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#ip_family EksCluster#ip_family}.</summary>
        [JsiiProperty(name: "ipFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpFamily
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#service_ipv4_cidr EksCluster#service_ipv4_cidr}.</summary>
        [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceIpv4Cidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubernetesNetworkConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubernetesNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubernetesNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>elastic_load_balancing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#elastic_load_balancing EksCluster#elastic_load_balancing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticLoadBalancing", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancing\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing? ElasticLoadBalancing
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#ip_family EksCluster#ip_family}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpFamily
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#service_ipv4_cidr EksCluster#service_ipv4_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceIpv4Cidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
