using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingScalingConfig")]
    public class LambdaEventSourceMappingScalingConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_concurrency LambdaEventSourceMapping#maximum_concurrency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumConcurrency
        {
            get;
            set;
        }
    }
}
