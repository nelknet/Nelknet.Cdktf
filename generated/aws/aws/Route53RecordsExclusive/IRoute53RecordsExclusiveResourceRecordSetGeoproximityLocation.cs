using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation), fullyQualifiedName: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocation")]
    public interface IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#aws_region Route53RecordsExclusive#aws_region}.</summary>
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#bias Route53RecordsExclusive#bias}.</summary>
        [JsiiProperty(name: "bias", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Bias
        {
            get
            {
                return null;
            }
        }

        /// <summary>coordinates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#coordinates Route53RecordsExclusive#coordinates}
        /// </remarks>
        [JsiiProperty(name: "coordinates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Coordinates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#local_zone_group Route53RecordsExclusive#local_zone_group}.</summary>
        [JsiiProperty(name: "localZoneGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalZoneGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation), fullyQualifiedName: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocation")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#aws_region Route53RecordsExclusive#aws_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#bias Route53RecordsExclusive#bias}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bias", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bias
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>coordinates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#coordinates Route53RecordsExclusive#coordinates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coordinates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocationCoordinates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Coordinates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#local_zone_group Route53RecordsExclusive#local_zone_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localZoneGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalZoneGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
