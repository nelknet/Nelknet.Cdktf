using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiByValue(fqn: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy")]
    public class FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy : aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#firewall_deployment_model FmsPolicy#firewall_deployment_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firewallDeploymentModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirewallDeploymentModel
        {
            get;
            set;
        }
    }
}
