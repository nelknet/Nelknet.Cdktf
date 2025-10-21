using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiByValue(fqn: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParameters")]
    public class CloudwatchEventConnectionAuthParameters : aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParameters
    {
        /// <summary>api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#api_key CloudwatchEventConnection#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey? ApiKey
        {
            get;
            set;
        }

        /// <summary>basic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#basic CloudwatchEventConnection#basic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic? Basic
        {
            get;
            set;
        }

        /// <summary>invocation_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#invocation_http_parameters CloudwatchEventConnection#invocation_http_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParameters
        {
            get;
            set;
        }

        /// <summary>oauth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#oauth CloudwatchEventConnection#oauth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth? Oauth
        {
            get;
            set;
        }
    }
}
