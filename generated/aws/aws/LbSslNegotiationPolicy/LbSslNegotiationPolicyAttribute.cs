using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbSslNegotiationPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbSslNegotiationPolicy.LbSslNegotiationPolicyAttribute")]
    public class LbSslNegotiationPolicyAttribute : aws.LbSslNegotiationPolicy.ILbSslNegotiationPolicyAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#name LbSslNegotiationPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#value LbSslNegotiationPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
