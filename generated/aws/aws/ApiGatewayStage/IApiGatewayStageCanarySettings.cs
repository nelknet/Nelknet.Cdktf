using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayStage
{
    [JsiiInterface(nativeType: typeof(IApiGatewayStageCanarySettings), fullyQualifiedName: "aws.apiGatewayStage.ApiGatewayStageCanarySettings")]
    public interface IApiGatewayStageCanarySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#deployment_id ApiGatewayStage#deployment_id}.</summary>
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#percent_traffic ApiGatewayStage#percent_traffic}.</summary>
        [JsiiProperty(name: "percentTraffic", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PercentTraffic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#stage_variable_overrides ApiGatewayStage#stage_variable_overrides}.</summary>
        [JsiiProperty(name: "stageVariableOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? StageVariableOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#use_stage_cache ApiGatewayStage#use_stage_cache}.</summary>
        [JsiiProperty(name: "useStageCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseStageCache
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayStageCanarySettings), fullyQualifiedName: "aws.apiGatewayStage.ApiGatewayStageCanarySettings")]
        internal sealed class _Proxy : DeputyBase, aws.ApiGatewayStage.IApiGatewayStageCanarySettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#deployment_id ApiGatewayStage#deployment_id}.</summary>
            [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#percent_traffic ApiGatewayStage#percent_traffic}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "percentTraffic", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PercentTraffic
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#stage_variable_overrides ApiGatewayStage#stage_variable_overrides}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stageVariableOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? StageVariableOverrides
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#use_stage_cache ApiGatewayStage#use_stage_cache}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useStageCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseStageCache
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
