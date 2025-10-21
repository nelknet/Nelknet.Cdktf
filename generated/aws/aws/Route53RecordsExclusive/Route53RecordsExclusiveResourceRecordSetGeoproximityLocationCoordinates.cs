using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates")]
    public class Route53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates : aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#latitude Route53RecordsExclusive#latitude}.</summary>
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}")]
        public string Latitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#longitude Route53RecordsExclusive#longitude}.</summary>
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}")]
        public string Longitude
        {
            get;
            set;
        }
    }
}
