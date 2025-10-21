using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpv4CidrBlockAssociation
{
    [JsiiInterface(nativeType: typeof(IVpcIpv4CidrBlockAssociationTimeouts), fullyQualifiedName: "aws.vpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociationTimeouts")]
    public interface IVpcIpv4CidrBlockAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#create VpcIpv4CidrBlockAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#delete VpcIpv4CidrBlockAssociation#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpv4CidrBlockAssociationTimeouts), fullyQualifiedName: "aws.vpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.VpcIpv4CidrBlockAssociation.IVpcIpv4CidrBlockAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#create VpcIpv4CidrBlockAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#delete VpcIpv4CidrBlockAssociation#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
