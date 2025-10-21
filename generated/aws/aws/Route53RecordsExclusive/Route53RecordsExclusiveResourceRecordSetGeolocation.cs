using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    [JsiiByValue(fqn: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeolocation")]
    public class Route53RecordsExclusiveResourceRecordSetGeolocation : aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeolocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#continent_code Route53RecordsExclusive#continent_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "continentCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContinentCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#country_code Route53RecordsExclusive#country_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountryCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#subdivision_code Route53RecordsExclusive#subdivision_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subdivisionCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubdivisionCode
        {
            get;
            set;
        }
    }
}
