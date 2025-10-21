using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiByValue(fqn: "aws.vpclatticeListener.VpclatticeListenerDefaultAction")]
    public class VpclatticeListenerDefaultAction : aws.VpclatticeListener.IVpclatticeListenerDefaultAction
    {
        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#fixed_response VpclatticeListener#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse\"}", isOptional: true)]
        public aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse? FixedResponse
        {
            get;
            set;
        }

        private object? _forward;

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#forward VpclatticeListener#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Forward
        {
            get => _forward;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forward = value;
            }
        }
    }
}
