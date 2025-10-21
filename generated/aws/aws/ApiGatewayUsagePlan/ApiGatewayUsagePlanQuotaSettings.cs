using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettings")]
    public class ApiGatewayUsagePlanQuotaSettings : aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanQuotaSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#limit ApiGatewayUsagePlan#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public double Limit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#period ApiGatewayUsagePlan#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        public string Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#offset ApiGatewayUsagePlan#offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Offset
        {
            get;
            set;
        }
    }
}
