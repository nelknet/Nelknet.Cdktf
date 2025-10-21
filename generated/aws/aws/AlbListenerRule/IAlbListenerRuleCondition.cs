using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleCondition), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleCondition")]
    public interface IAlbListenerRuleCondition
    {
        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#host_header AlbListenerRule#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#http_header AlbListenerRule#http_header}
        /// </remarks>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#http_request_method AlbListenerRule#http_request_method}
        /// </remarks>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#path_pattern AlbListenerRule#path_pattern}
        /// </remarks>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#query_string AlbListenerRule#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#source_ip AlbListenerRule#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp? SourceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleCondition), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListenerRule.IAlbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#host_header AlbListenerRule#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader? HostHeader
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader?>();
            }

            /// <summary>http_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#http_header AlbListenerRule#http_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader? HttpHeader
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader?>();
            }

            /// <summary>http_request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#http_request_method AlbListenerRule#http_request_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod?>();
            }

            /// <summary>path_pattern block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#path_pattern AlbListenerRule#path_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern? PathPattern
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#query_string AlbListenerRule#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#source_ip AlbListenerRule#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp? SourceIp
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp?>();
            }
        }
    }
}
