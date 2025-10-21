using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl")]
    public class MskServerlessClusterClientAuthenticationSasl : aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl
    {
        /// <summary>iam block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#iam MskServerlessCluster#iam}
        /// </remarks>
        [JsiiProperty(name: "iam", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam\"}")]
        public aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam Iam
        {
            get;
            set;
        }
    }
}
