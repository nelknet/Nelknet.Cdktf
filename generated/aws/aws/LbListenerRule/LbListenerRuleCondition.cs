using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiByValue(fqn: "aws.lbListenerRule.LbListenerRuleCondition")]
    public class LbListenerRuleCondition : aws.LbListenerRule.ILbListenerRuleCondition
    {
        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#host_header LbListenerRule#host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleConditionHostHeader? HostHeader
        {
            get;
            set;
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#http_header LbListenerRule#http_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleConditionHttpHeader? HttpHeader
        {
            get;
            set;
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#http_request_method LbListenerRule#http_request_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get;
            set;
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#path_pattern LbListenerRule#path_pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleConditionPathPattern? PathPattern
        {
            get;
            set;
        }

        private object? _queryString;

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#query_string LbListenerRule#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.LbListenerRule.ILbListenerRuleConditionQueryString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListenerRule.ILbListenerRuleConditionQueryString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryString = value;
            }
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#source_ip LbListenerRule#source_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleConditionSourceIp? SourceIp
        {
            get;
            set;
        }
    }
}
