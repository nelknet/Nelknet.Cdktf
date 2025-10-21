using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSourceAccessConfiguration")]
    public class LambdaEventSourceMappingSourceAccessConfiguration : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSourceAccessConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#type LambdaEventSourceMapping#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#uri LambdaEventSourceMapping#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }
    }
}
