using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Alb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.alb.AlbSubnetMapping")]
    public class AlbSubnetMapping : aws.Alb.IAlbSubnetMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#subnet_id Alb#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#allocation_id Alb#allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#ipv6_address Alb#ipv6_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#private_ipv4_address Alb#private_ipv4_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpv4Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpv4Address
        {
            get;
            set;
        }
    }
}
