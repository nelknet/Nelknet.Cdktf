using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionEventInvokeConfig
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfig), fullyQualifiedName: "aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfig")]
    public interface ILambdaFunctionEventInvokeConfigDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#on_failure LambdaFunctionEventInvokeConfig#on_failure}
        /// </remarks>
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#on_success LambdaFunctionEventInvokeConfig#on_success}
        /// </remarks>
        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfig), fullyQualifiedName: "aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_failure block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#on_failure LambdaFunctionEventInvokeConfig#on_failure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
            public aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure
            {
                get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure?>();
            }

            /// <summary>on_success block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#on_success LambdaFunctionEventInvokeConfig#on_success}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
            public aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess
            {
                get => GetInstanceProperty<aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess?>();
            }
        }
    }
}
