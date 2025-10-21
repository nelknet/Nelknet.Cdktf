using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRules")]
    public class CustomerprofilesDomainRuleBasedMatchingMatchingRules : aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingMatchingRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#rule CustomerprofilesDomain#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Rule
        {
            get;
            set;
        }
    }
}
