using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    [JsiiByValue(fqn: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocation")]
    public class Route53RecordsExclusiveResourceRecordSetGeoproximityLocation : aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#aws_region Route53RecordsExclusive#aws_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#bias Route53RecordsExclusive#bias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bias", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Bias
        {
            get;
            set;
        }

        private object? _coordinates;

        /// <summary>coordinates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#coordinates Route53RecordsExclusive#coordinates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coordinates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Coordinates
        {
            get => _coordinates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _coordinates = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#local_zone_group Route53RecordsExclusive#local_zone_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localZoneGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalZoneGroup
        {
            get;
            set;
        }
    }
}
