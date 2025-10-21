using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53Record.Route53RecordLatencyRoutingPolicy")]
    public class Route53RecordLatencyRoutingPolicy : aws.Route53Record.IRoute53RecordLatencyRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#region Route53Record#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}
