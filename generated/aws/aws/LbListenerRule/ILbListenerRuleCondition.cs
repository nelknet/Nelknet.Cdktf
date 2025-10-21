using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleCondition), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleCondition")]
    public interface ILbListenerRuleCondition
    {
        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#host_header LbListenerRule#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleConditionHostHeader? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#http_header LbListenerRule#http_header}
        /// </remarks>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleConditionHttpHeader? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#http_request_method LbListenerRule#http_request_method}
        /// </remarks>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#path_pattern LbListenerRule#path_pattern}
        /// </remarks>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleConditionPathPattern? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#query_string LbListenerRule#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#source_ip LbListenerRule#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleConditionSourceIp? SourceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleCondition), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#host_header LbListenerRule#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleConditionHostHeader? HostHeader
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionHostHeader?>();
            }

            /// <summary>http_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#http_header LbListenerRule#http_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleConditionHttpHeader? HttpHeader
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionHttpHeader?>();
            }

            /// <summary>http_request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#http_request_method LbListenerRule#http_request_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod?>();
            }

            /// <summary>path_pattern block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#path_pattern LbListenerRule#path_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleConditionPathPattern? PathPattern
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionPathPattern?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#query_string LbListenerRule#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#source_ip LbListenerRule#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleConditionSourceIp? SourceIp
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionSourceIp?>();
            }
        }
    }
}
