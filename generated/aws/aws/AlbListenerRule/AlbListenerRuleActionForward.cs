using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleActionForward")]
    public class AlbListenerRuleActionForward : aws.AlbListenerRule.IAlbListenerRuleActionForward
    {
        private object _targetGroup;

        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#target_group AlbListenerRule#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroup
        {
            get => _targetGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AlbListenerRule.IAlbListenerRuleActionForwardTargetGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleActionForwardTargetGroup).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleActionForwardTargetGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroup = value;
            }
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#stickiness AlbListenerRule#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleActionForwardStickiness? Stickiness
        {
            get;
            set;
        }
    }
}
