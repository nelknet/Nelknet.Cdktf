using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubernetesNetworkConfig")]
    public class EksClusterKubernetesNetworkConfig : aws.EksCluster.IEksClusterKubernetesNetworkConfig
    {
        /// <summary>elastic_load_balancing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#elastic_load_balancing EksCluster#elastic_load_balancing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticLoadBalancing", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancing\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing? ElasticLoadBalancing
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#ip_family EksCluster#ip_family}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpFamily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#service_ipv4_cidr EksCluster#service_ipv4_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceIpv4Cidr
        {
            get;
            set;
        }
    }
}
