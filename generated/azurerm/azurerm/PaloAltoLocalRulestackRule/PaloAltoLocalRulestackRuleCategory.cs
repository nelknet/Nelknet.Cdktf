using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoLocalRulestackRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleCategory")]
    public class PaloAltoLocalRulestackRuleCategory : azurerm.PaloAltoLocalRulestackRule.IPaloAltoLocalRulestackRuleCategory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#custom_urls PaloAltoLocalRulestackRule#custom_urls}.</summary>
        [JsiiProperty(name: "customUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CustomUrls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#feeds PaloAltoLocalRulestackRule#feeds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "feeds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Feeds
        {
            get;
            set;
        }
    }
}
