using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53TrafficPolicyDocument
{
    [JsiiByValue(fqn: "aws.dataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocumentRuleGeoProximityLocation")]
    public class DataAwsRoute53TrafficPolicyDocumentRuleGeoProximityLocation : aws.DataAwsRoute53TrafficPolicyDocument.IDataAwsRoute53TrafficPolicyDocumentRuleGeoProximityLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#bias DataAwsRoute53TrafficPolicyDocument#bias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#endpoint_reference DataAwsRoute53TrafficPolicyDocument#endpoint_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointReference
        {
            get;
            set;
        }

        private object? _evaluateTargetHealth;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#evaluate_target_health DataAwsRoute53TrafficPolicyDocument#evaluate_target_health}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EvaluateTargetHealth
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluateTargetHealth = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#health_check DataAwsRoute53TrafficPolicyDocument#health_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#latitude DataAwsRoute53TrafficPolicyDocument#latitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Latitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#longitude DataAwsRoute53TrafficPolicyDocument#longitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Longitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#region DataAwsRoute53TrafficPolicyDocument#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#rule_reference DataAwsRoute53TrafficPolicyDocument#rule_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleReference
        {
            get;
            set;
        }
    }
}
