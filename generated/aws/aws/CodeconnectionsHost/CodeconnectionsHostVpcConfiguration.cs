using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodeconnectionsHost
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codeconnectionsHost.CodeconnectionsHostVpcConfiguration")]
    public class CodeconnectionsHostVpcConfiguration : aws.CodeconnectionsHost.ICodeconnectionsHostVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#security_group_ids CodeconnectionsHost#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#subnet_ids CodeconnectionsHost#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#vpc_id CodeconnectionsHost#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#tls_certificate CodeconnectionsHost#tls_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsCertificate
        {
            get;
            set;
        }
    }
}
