using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity")]
    public class MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity : aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
    {
        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_authentication MskCluster#client_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication
        {
            get;
            set;
        }
    }
}
