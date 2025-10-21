using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfig")]
    public class LambdaEventSourceMappingSelfManagedKafkaEventSourceConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#consumer_group_id LambdaEventSourceMapping#consumer_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerGroupId
        {
            get;
            set;
        }
    }
}
