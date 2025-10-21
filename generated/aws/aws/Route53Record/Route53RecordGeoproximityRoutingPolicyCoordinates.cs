using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53Record.Route53RecordGeoproximityRoutingPolicyCoordinates")]
    public class Route53RecordGeoproximityRoutingPolicyCoordinates : aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicyCoordinates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#latitude Route53Record#latitude}.</summary>
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}")]
        public string Latitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#longitude Route53Record#longitude}.</summary>
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}")]
        public string Longitude
        {
            get;
            set;
        }
    }
}
