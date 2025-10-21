using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcIpamPreviewNextCidr
{
    [JsiiByValue(fqn: "aws.dataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidrTimeouts")]
    public class DataAwsVpcIpamPreviewNextCidrTimeouts : aws.DataAwsVpcIpamPreviewNextCidr.IDataAwsVpcIpamPreviewNextCidrTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr#read DataAwsVpcIpamPreviewNextCidr#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
