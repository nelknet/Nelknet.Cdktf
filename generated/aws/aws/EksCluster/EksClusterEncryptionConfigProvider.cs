using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksCluster.EksClusterEncryptionConfigProvider")]
    public class EksClusterEncryptionConfigProvider : aws.EksCluster.IEksClusterEncryptionConfigProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#key_arn EksCluster#key_arn}.</summary>
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyArn
        {
            get;
            set;
        }
    }
}
