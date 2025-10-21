using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpv4CidrBlockAssociation
{
    [JsiiByValue(fqn: "aws.vpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociationTimeouts")]
    public class VpcIpv4CidrBlockAssociationTimeouts : aws.VpcIpv4CidrBlockAssociation.IVpcIpv4CidrBlockAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#create VpcIpv4CidrBlockAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#delete VpcIpv4CidrBlockAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
