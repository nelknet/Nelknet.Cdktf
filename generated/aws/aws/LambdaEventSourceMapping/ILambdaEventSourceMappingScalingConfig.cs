using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingScalingConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingScalingConfig")]
    public interface ILambdaEventSourceMappingScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_concurrency LambdaEventSourceMapping#maximum_concurrency}.</summary>
        [JsiiProperty(name: "maximumConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumConcurrency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingScalingConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaEventSourceMapping.ILambdaEventSourceMappingScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_concurrency LambdaEventSourceMapping#maximum_concurrency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumConcurrency
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
