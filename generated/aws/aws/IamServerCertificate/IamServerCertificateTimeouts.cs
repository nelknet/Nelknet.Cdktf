using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IamServerCertificate
{
    [JsiiByValue(fqn: "aws.iamServerCertificate.IamServerCertificateTimeouts")]
    public class IamServerCertificateTimeouts : aws.IamServerCertificate.IIamServerCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#delete IamServerCertificate#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
