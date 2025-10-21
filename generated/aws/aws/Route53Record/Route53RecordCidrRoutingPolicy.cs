using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53Record.Route53RecordCidrRoutingPolicy")]
    public class Route53RecordCidrRoutingPolicy : aws.Route53Record.IRoute53RecordCidrRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#collection_id Route53Record#collection_id}.</summary>
        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string CollectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#location_name Route53Record#location_name}.</summary>
        [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
        public string LocationName
        {
            get;
            set;
        }
    }
}
