using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterClientAuthenticationTls")]
    public class MskClusterClientAuthenticationTls : aws.MskCluster.IMskClusterClientAuthenticationTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#certificate_authority_arns MskCluster#certificate_authority_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CertificateAuthorityArns
        {
            get;
            set;
        }
    }
}
