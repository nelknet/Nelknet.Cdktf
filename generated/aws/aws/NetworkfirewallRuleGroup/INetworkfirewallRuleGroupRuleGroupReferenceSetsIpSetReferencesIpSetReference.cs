using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference")]
    public interface INetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#reference_arn NetworkfirewallRuleGroup#reference_arn}.</summary>
        [JsiiProperty(name: "referenceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ReferenceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#reference_arn NetworkfirewallRuleGroup#reference_arn}.</summary>
            [JsiiProperty(name: "referenceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ReferenceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
