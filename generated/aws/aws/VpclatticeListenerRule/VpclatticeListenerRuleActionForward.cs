using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward")]
    public class VpclatticeListenerRuleActionForward : aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward
    {
        private object _targetGroups;

        /// <summary>target_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#target_groups VpclatticeListenerRule#target_groups}
        /// </remarks>
        [JsiiProperty(name: "targetGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForwardTargetGroups\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroups
        {
            get => _targetGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForwardTargetGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForwardTargetGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForwardTargetGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroups = value;
            }
        }
    }
}
