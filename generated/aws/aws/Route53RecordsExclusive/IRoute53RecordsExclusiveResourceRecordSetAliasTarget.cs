using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordsExclusiveResourceRecordSetAliasTarget), fullyQualifiedName: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetAliasTarget")]
    public interface IRoute53RecordsExclusiveResourceRecordSetAliasTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#dns_name Route53RecordsExclusive#dns_name}.</summary>
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        string DnsName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#evaluate_target_health Route53RecordsExclusive#evaluate_target_health}.</summary>
        [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EvaluateTargetHealth
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#hosted_zone_id Route53RecordsExclusive#hosted_zone_id}.</summary>
        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        string HostedZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordsExclusiveResourceRecordSetAliasTarget), fullyQualifiedName: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetAliasTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetAliasTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#dns_name Route53RecordsExclusive#dns_name}.</summary>
            [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#evaluate_target_health Route53RecordsExclusive#evaluate_target_health}.</summary>
            [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EvaluateTargetHealth
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#hosted_zone_id Route53RecordsExclusive#hosted_zone_id}.</summary>
            [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string HostedZoneId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
