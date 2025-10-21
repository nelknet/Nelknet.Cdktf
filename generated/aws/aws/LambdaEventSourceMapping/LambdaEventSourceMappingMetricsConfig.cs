using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingMetricsConfig")]
    public class LambdaEventSourceMappingMetricsConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingMetricsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#metrics LambdaEventSourceMapping#metrics}.</summary>
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Metrics
        {
            get;
            set;
        }
    }
}
