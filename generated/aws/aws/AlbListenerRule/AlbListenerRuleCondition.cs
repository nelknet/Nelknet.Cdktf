using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleCondition")]
    public class AlbListenerRuleCondition : aws.AlbListenerRule.IAlbListenerRuleCondition
    {
        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#host_header AlbListenerRule#host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader? HostHeader
        {
            get;
            set;
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#http_header AlbListenerRule#http_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader? HttpHeader
        {
            get;
            set;
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#http_request_method AlbListenerRule#http_request_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get;
            set;
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#path_pattern AlbListenerRule#path_pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern? PathPattern
        {
            get;
            set;
        }

        private object? _queryString;

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#query_string AlbListenerRule#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryString
        {
            get => _queryString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AlbListenerRule.IAlbListenerRuleConditionQueryString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleConditionQueryString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryString = value;
            }
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#source_ip AlbListenerRule#source_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp? SourceIp
        {
            get;
            set;
        }
    }
}
