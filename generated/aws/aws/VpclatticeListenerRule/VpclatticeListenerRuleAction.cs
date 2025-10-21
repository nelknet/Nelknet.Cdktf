using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleAction")]
    public class VpclatticeListenerRuleAction : aws.VpclatticeListenerRule.IVpclatticeListenerRuleAction
    {
        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#fixed_response VpclatticeListenerRule#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse\"}", isOptional: true)]
        public aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#forward VpclatticeListenerRule#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward\"}", isOptional: true)]
        public aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward? Forward
        {
            get;
            set;
        }
    }
}
