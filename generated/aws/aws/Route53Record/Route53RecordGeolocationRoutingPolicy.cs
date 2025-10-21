using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    [JsiiByValue(fqn: "aws.route53Record.Route53RecordGeolocationRoutingPolicy")]
    public class Route53RecordGeolocationRoutingPolicy : aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#continent Route53Record#continent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "continent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Continent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#country Route53Record#country}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Country
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#subdivision Route53Record#subdivision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subdivision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subdivision
        {
            get;
            set;
        }
    }
}
