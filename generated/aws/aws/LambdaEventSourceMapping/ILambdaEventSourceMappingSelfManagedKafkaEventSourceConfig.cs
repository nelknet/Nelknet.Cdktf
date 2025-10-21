using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfig")]
    public interface ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#consumer_group_id LambdaEventSourceMapping#consumer_group_id}.</summary>
        [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#consumer_group_id LambdaEventSourceMapping#consumer_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
