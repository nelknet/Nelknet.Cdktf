using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiInterface(nativeType: typeof(IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy")]
    public interface IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#firewall_deployment_model FmsPolicy#firewall_deployment_model}.</summary>
        [JsiiProperty(name: "firewallDeploymentModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirewallDeploymentModel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#firewall_deployment_model FmsPolicy#firewall_deployment_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firewallDeploymentModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirewallDeploymentModel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
