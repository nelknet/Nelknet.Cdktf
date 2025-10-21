using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayDeployment
{
    [JsiiByValue(fqn: "aws.apiGatewayDeployment.ApiGatewayDeploymentCanarySettings")]
    public class ApiGatewayDeploymentCanarySettings : aws.ApiGatewayDeployment.IApiGatewayDeploymentCanarySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#percent_traffic ApiGatewayDeployment#percent_traffic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "percentTraffic", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PercentTraffic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#stage_variable_overrides ApiGatewayDeployment#stage_variable_overrides}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stageVariableOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? StageVariableOverrides
        {
            get;
            set;
        }

        private object? _useStageCache;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#use_stage_cache ApiGatewayDeployment#use_stage_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useStageCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseStageCache
        {
            get => _useStageCache;
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
                _useStageCache = value;
            }
        }
    }
}
