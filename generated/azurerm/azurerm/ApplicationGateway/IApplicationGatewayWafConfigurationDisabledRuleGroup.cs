using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayWafConfigurationDisabledRuleGroup), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroup")]
    public interface IApplicationGatewayWafConfigurationDisabledRuleGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_group_name ApplicationGateway#rule_group_name}.</summary>
        [JsiiProperty(name: "ruleGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rules ApplicationGateway#rules}.</summary>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Rules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayWafConfigurationDisabledRuleGroup), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_group_name ApplicationGateway#rule_group_name}.</summary>
            [JsiiProperty(name: "ruleGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rules ApplicationGateway#rules}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Rules
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
