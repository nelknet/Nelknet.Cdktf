using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleHttp")]
    public class IotTopicRuleHttp : aws.IotTopicRule.IIotTopicRuleHttp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#url IotTopicRule#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#confirmation_url IotTopicRule#confirmation_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfirmationUrl
        {
            get;
            set;
        }

        private object? _httpHeader;

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#http_header IotTopicRule#http_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotTopicRule.IotTopicRuleHttpHttpHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpHeader
        {
            get => _httpHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.IotTopicRule.IIotTopicRuleHttpHttpHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotTopicRule.IIotTopicRuleHttpHttpHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpHeader = value;
            }
        }
    }
}
