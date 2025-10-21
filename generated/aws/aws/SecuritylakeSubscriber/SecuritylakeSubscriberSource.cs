using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriber
{
    [JsiiByValue(fqn: "aws.securitylakeSubscriber.SecuritylakeSubscriberSource")]
    public class SecuritylakeSubscriberSource : aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSource
    {
        private object? _awsLogSourceResource;

        /// <summary>aws_log_source_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#aws_log_source_resource SecuritylakeSubscriber#aws_log_source_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsLogSourceResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriber.SecuritylakeSubscriberSourceAwsLogSourceResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsLogSourceResource
        {
            get => _awsLogSourceResource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSourceAwsLogSourceResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSourceAwsLogSourceResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsLogSourceResource = value;
            }
        }

        private object? _customLogSourceResource;

        /// <summary>custom_log_source_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#custom_log_source_resource SecuritylakeSubscriber#custom_log_source_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customLogSourceResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriber.SecuritylakeSubscriberSourceCustomLogSourceResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomLogSourceResource
        {
            get => _customLogSourceResource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSourceCustomLogSourceResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSourceCustomLogSourceResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customLogSourceResource = value;
            }
        }
    }
}
