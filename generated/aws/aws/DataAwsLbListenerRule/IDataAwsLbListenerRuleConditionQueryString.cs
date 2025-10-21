using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleConditionQueryString), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString")]
    public interface IDataAwsLbListenerRuleConditionQueryString
    {
        /// <summary>values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#values DataAwsLbListenerRule#values}
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryStringValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleConditionQueryString), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#values DataAwsLbListenerRule#values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryStringValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Values
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
