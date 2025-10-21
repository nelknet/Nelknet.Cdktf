using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleAction), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction")]
    public interface IDataAwsLbListenerRuleAction
    {
        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#forward DataAwsLbListenerRule#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward? Forward
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleAction), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#forward DataAwsLbListenerRule#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"}", isOptional: true)]
            public aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward? Forward
            {
                get => GetInstanceProperty<aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward?>();
            }
        }
    }
}
