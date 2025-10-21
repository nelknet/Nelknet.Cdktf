using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53TrafficPolicyDocument
{
    [JsiiByValue(fqn: "aws.dataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocumentRuleItems")]
    public class DataAwsRoute53TrafficPolicyDocumentRuleItems : aws.DataAwsRoute53TrafficPolicyDocument.IDataAwsRoute53TrafficPolicyDocumentRuleItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#endpoint_reference DataAwsRoute53TrafficPolicyDocument#endpoint_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#health_check DataAwsRoute53TrafficPolicyDocument#health_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheck
        {
            get;
            set;
        }
    }
}
