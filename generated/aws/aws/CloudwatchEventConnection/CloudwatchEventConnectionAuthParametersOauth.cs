using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth")]
    public class CloudwatchEventConnectionAuthParametersOauth : aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#authorization_endpoint CloudwatchEventConnection#authorization_endpoint}.</summary>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#http_method CloudwatchEventConnection#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpMethod
        {
            get;
            set;
        }

        /// <summary>oauth_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#oauth_http_parameters CloudwatchEventConnection#oauth_http_parameters}
        /// </remarks>
        [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}")]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters OauthHttpParameters
        {
            get;
            set;
        }

        /// <summary>client_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#client_parameters CloudwatchEventConnection#client_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParameters
        {
            get;
            set;
        }
    }
}
