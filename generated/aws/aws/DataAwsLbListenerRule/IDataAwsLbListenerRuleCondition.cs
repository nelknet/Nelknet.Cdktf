using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleCondition), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition")]
    public interface IDataAwsLbListenerRuleCondition
    {
        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#query_string DataAwsLbListenerRule#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString? QueryString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleCondition), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#query_string DataAwsLbListenerRule#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"}", isOptional: true)]
            public aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString? QueryString
            {
                get => GetInstanceProperty<aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString?>();
            }
        }
    }
}
