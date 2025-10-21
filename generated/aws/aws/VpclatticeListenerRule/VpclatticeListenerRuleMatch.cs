using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatch")]
    public class VpclatticeListenerRuleMatch : aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatch
    {
        /// <summary>http_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#http_match VpclatticeListenerRule#http_match}
        /// </remarks>
        [JsiiProperty(name: "httpMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch\"}")]
        public aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch HttpMatch
        {
            get;
            set;
        }
    }
}
