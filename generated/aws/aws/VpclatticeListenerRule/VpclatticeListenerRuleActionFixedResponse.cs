using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse")]
    public class VpclatticeListenerRuleActionFixedResponse : aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#status_code VpclatticeListenerRule#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public double StatusCode
        {
            get;
            set;
        }
    }
}
