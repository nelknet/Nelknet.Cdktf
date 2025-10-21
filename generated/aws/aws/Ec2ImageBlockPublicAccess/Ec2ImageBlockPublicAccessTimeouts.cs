using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2ImageBlockPublicAccess
{
    [JsiiByValue(fqn: "aws.ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccessTimeouts")]
    public class Ec2ImageBlockPublicAccessTimeouts : aws.Ec2ImageBlockPublicAccess.IEc2ImageBlockPublicAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access#update Ec2ImageBlockPublicAccess#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
