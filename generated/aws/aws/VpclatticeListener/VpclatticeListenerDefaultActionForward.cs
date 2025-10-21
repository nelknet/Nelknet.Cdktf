using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiByValue(fqn: "aws.vpclatticeListener.VpclatticeListenerDefaultActionForward")]
    public class VpclatticeListenerDefaultActionForward : aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward
    {
        private object? _targetGroups;

        /// <summary>target_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#target_groups VpclatticeListener#target_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardTargetGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetGroups
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
                        case aws.VpclatticeListener.IVpclatticeListenerDefaultActionForwardTargetGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListener.IVpclatticeListenerDefaultActionForwardTargetGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroups = value;
            }
        }
    }
}
