using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworks")]
    public class EksClusterRemoteNetworkConfigRemotePodNetworks : aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#cidrs EksCluster#cidrs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Cidrs
        {
            get;
            set;
        }
    }
}
