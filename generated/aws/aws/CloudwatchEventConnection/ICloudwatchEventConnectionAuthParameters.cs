using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParameters), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParameters")]
    public interface ICloudwatchEventConnectionAuthParameters
    {
        /// <summary>api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#api_key CloudwatchEventConnection#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>basic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#basic CloudwatchEventConnection#basic}
        /// </remarks>
        [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic? Basic
        {
            get
            {
                return null;
            }
        }

        /// <summary>invocation_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#invocation_http_parameters CloudwatchEventConnection#invocation_http_parameters}
        /// </remarks>
        [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#oauth CloudwatchEventConnection#oauth}
        /// </remarks>
        [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth? Oauth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParameters), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParameters")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#api_key CloudwatchEventConnection#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey? ApiKey
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey?>();
            }

            /// <summary>basic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#basic CloudwatchEventConnection#basic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic? Basic
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic?>();
            }

            /// <summary>invocation_http_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#invocation_http_parameters CloudwatchEventConnection#invocation_http_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParameters
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters?>();
            }

            /// <summary>oauth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#oauth CloudwatchEventConnection#oauth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth? Oauth
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth?>();
            }
        }
    }
}
