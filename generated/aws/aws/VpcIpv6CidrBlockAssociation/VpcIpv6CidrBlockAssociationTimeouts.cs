using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpv6CidrBlockAssociation
{
    [JsiiByValue(fqn: "aws.vpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociationTimeouts")]
    public class VpcIpv6CidrBlockAssociationTimeouts : aws.VpcIpv6CidrBlockAssociation.IVpcIpv6CidrBlockAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#create VpcIpv6CidrBlockAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#delete VpcIpv6CidrBlockAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
