using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetCidrRoutingConfig")]
    public class Route53RecordsExclusiveResourceRecordSetCidrRoutingConfig : aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#collection_id Route53RecordsExclusive#collection_id}.</summary>
        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string CollectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#location_name Route53RecordsExclusive#location_name}.</summary>
        [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
        public string LocationName
        {
            get;
            set;
        }
    }
}
