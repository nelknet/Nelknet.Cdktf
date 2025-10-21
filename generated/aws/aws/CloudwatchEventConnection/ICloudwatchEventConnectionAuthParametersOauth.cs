using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauth), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth")]
    public interface ICloudwatchEventConnectionAuthParametersOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#authorization_endpoint CloudwatchEventConnection#authorization_endpoint}.</summary>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#http_method CloudwatchEventConnection#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        string HttpMethod
        {
            get;
        }

        /// <summary>oauth_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#oauth_http_parameters CloudwatchEventConnection#oauth_http_parameters}
        /// </remarks>
        [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}")]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters OauthHttpParameters
        {
            get;
        }

        /// <summary>client_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#client_parameters CloudwatchEventConnection#client_parameters}
        /// </remarks>
        [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauth), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#authorization_endpoint CloudwatchEventConnection#authorization_endpoint}.</summary>
            [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#http_method CloudwatchEventConnection#http_method}.</summary>
            [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>oauth_http_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#oauth_http_parameters CloudwatchEventConnection#oauth_http_parameters}
            /// </remarks>
            [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}")]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters OauthHttpParameters
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters>()!;
            }

            /// <summary>client_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#client_parameters CloudwatchEventConnection#client_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParameters
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters?>();
            }
        }
    }
}
