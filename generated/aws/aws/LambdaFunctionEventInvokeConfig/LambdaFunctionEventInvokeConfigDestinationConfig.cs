using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionEventInvokeConfig
{
    [JsiiByValue(fqn: "aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfig")]
    public class LambdaFunctionEventInvokeConfigDestinationConfig : aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#on_failure LambdaFunctionEventInvokeConfig#on_failure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
        public aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure
        {
            get;
            set;
        }

        /// <summary>on_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#on_success LambdaFunctionEventInvokeConfig#on_success}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
        public aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess
        {
            get;
            set;
        }
    }
}
