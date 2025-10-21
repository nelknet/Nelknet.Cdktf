using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListener
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbListener.LbListenerDefaultActionForward")]
    public class LbListenerDefaultActionForward : aws.LbListener.ILbListenerDefaultActionForward
    {
        private object _targetGroup;

        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#target_group LbListener#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
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
                        case aws.LbListener.ILbListenerDefaultActionForwardTargetGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultActionForwardTargetGroup).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultActionForwardTargetGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroup = value;
            }
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#stickiness LbListener#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
        public aws.LbListener.ILbListenerDefaultActionForwardStickiness? Stickiness
        {
            get;
            set;
        }
    }
}
