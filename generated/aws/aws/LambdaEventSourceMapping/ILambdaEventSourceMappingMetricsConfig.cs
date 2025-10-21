using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingMetricsConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingMetricsConfig")]
    public interface ILambdaEventSourceMappingMetricsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#metrics LambdaEventSourceMapping#metrics}.</summary>
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Metrics
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingMetricsConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingMetricsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaEventSourceMapping.ILambdaEventSourceMappingMetricsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#metrics LambdaEventSourceMapping#metrics}.</summary>
            [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Metrics
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
