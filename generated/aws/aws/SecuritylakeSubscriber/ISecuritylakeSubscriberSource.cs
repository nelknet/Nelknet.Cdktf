using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriber
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeSubscriberSource), fullyQualifiedName: "aws.securitylakeSubscriber.SecuritylakeSubscriberSource")]
    public interface ISecuritylakeSubscriberSource
    {
        /// <summary>aws_log_source_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#aws_log_source_resource SecuritylakeSubscriber#aws_log_source_resource}
        /// </remarks>
        [JsiiProperty(name: "awsLogSourceResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriber.SecuritylakeSubscriberSourceAwsLogSourceResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsLogSourceResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_log_source_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#custom_log_source_resource SecuritylakeSubscriber#custom_log_source_resource}
        /// </remarks>
        [JsiiProperty(name: "customLogSourceResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriber.SecuritylakeSubscriberSourceCustomLogSourceResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomLogSourceResource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeSubscriberSource), fullyQualifiedName: "aws.securitylakeSubscriber.SecuritylakeSubscriberSource")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_log_source_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#aws_log_source_resource SecuritylakeSubscriber#aws_log_source_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsLogSourceResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriber.SecuritylakeSubscriberSourceAwsLogSourceResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsLogSourceResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_log_source_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#custom_log_source_resource SecuritylakeSubscriber#custom_log_source_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customLogSourceResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriber.SecuritylakeSubscriberSourceCustomLogSourceResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomLogSourceResource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
