using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apiGatewayUsagePlan.ApiGatewayUsagePlanApiStages")]
    public class ApiGatewayUsagePlanApiStages : aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanApiStages
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#api_id ApiGatewayUsagePlan#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#stage ApiGatewayUsagePlan#stage}.</summary>
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
        public string Stage
        {
            get;
            set;
        }

        private object? _throttle;

        /// <summary>throttle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#throttle ApiGatewayUsagePlan#throttle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "throttle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanApiStagesThrottle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Throttle
        {
            get => _throttle;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanApiStagesThrottle[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanApiStagesThrottle).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _throttle = value;
            }
        }
    }
}
