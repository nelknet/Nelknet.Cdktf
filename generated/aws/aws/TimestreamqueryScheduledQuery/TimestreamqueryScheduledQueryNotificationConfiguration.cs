using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryNotificationConfiguration")]
    public class TimestreamqueryScheduledQueryNotificationConfiguration : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryNotificationConfiguration
    {
        private object? _snsConfiguration;

        /// <summary>sns_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#sns_configuration TimestreamqueryScheduledQuery#sns_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryNotificationConfigurationSnsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SnsConfiguration
        {
            get => _snsConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryNotificationConfigurationSnsConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryNotificationConfigurationSnsConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _snsConfiguration = value;
            }
        }
    }
}
