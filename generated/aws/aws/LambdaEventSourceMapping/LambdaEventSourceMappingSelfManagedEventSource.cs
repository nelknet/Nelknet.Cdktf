using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedEventSource")]
    public class LambdaEventSourceMappingSelfManagedEventSource : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedEventSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#endpoints LambdaEventSourceMapping#endpoints}.</summary>
        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Endpoints
        {
            get;
            set;
        }
    }
}
