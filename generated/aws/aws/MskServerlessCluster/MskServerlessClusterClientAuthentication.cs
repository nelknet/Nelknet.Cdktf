using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskServerlessCluster.MskServerlessClusterClientAuthentication")]
    public class MskServerlessClusterClientAuthentication : aws.MskServerlessCluster.IMskServerlessClusterClientAuthentication
    {
        /// <summary>sasl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#sasl MskServerlessCluster#sasl}
        /// </remarks>
        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl\"}")]
        public aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl Sasl
        {
            get;
            set;
        }
    }
}
