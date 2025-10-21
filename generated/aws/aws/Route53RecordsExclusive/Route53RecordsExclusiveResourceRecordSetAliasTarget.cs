using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetAliasTarget")]
    public class Route53RecordsExclusiveResourceRecordSetAliasTarget : aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetAliasTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#dns_name Route53RecordsExclusive#dns_name}.</summary>
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsName
        {
            get;
            set;
        }

        private object _evaluateTargetHealth;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#evaluate_target_health Route53RecordsExclusive#evaluate_target_health}.</summary>
        [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EvaluateTargetHealth
        {
            get => _evaluateTargetHealth;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluateTargetHealth = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#hosted_zone_id Route53RecordsExclusive#hosted_zone_id}.</summary>
        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string HostedZoneId
        {
            get;
            set;
        }
    }
}
