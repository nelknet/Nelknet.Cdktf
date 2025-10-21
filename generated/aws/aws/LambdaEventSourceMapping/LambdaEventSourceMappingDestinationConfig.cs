using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfig")]
    public class LambdaEventSourceMappingDestinationConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#on_failure LambdaEventSourceMapping#on_failure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
        public aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDestinationConfigOnFailure? OnFailure
        {
            get;
            set;
        }
    }
}
