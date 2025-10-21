using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayUsagePlan
{
    [JsiiByValue(fqn: "aws.apiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettings")]
    public class ApiGatewayUsagePlanThrottleSettings : aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#burst_limit ApiGatewayUsagePlan#burst_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BurstLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#rate_limit ApiGatewayUsagePlan#rate_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RateLimit
        {
            get;
            set;
        }
    }
}
