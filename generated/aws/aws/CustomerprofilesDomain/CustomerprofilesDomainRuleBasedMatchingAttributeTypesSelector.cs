using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector")]
    public class CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector : aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#attribute_matching_model CustomerprofilesDomain#attribute_matching_model}.</summary>
        [JsiiProperty(name: "attributeMatchingModel", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeMatchingModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#address CustomerprofilesDomain#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#email_address CustomerprofilesDomain#email_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EmailAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#phone_number CustomerprofilesDomain#phone_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PhoneNumber
        {
            get;
            set;
        }
    }
}
