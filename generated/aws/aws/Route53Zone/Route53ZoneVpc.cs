using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Zone
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53Zone.Route53ZoneVpc")]
    public class Route53ZoneVpc : aws.Route53Zone.IRoute53ZoneVpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#vpc_id Route53Zone#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#vpc_region Route53Zone#vpc_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcRegion
        {
            get;
            set;
        }
    }
}
