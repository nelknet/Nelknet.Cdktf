using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53Record.Route53RecordWeightedRoutingPolicy")]
    public class Route53RecordWeightedRoutingPolicy : aws.Route53Record.IRoute53RecordWeightedRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#weight Route53Record#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
