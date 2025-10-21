using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiInterface(nativeType: typeof(ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector")]
    public interface ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#attribute_matching_model CustomerprofilesDomain#attribute_matching_model}.</summary>
        [JsiiProperty(name: "attributeMatchingModel", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeMatchingModel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#address CustomerprofilesDomain#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#email_address CustomerprofilesDomain#email_address}.</summary>
        [JsiiProperty(name: "emailAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EmailAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#phone_number CustomerprofilesDomain#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PhoneNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector")]
        internal sealed class _Proxy : DeputyBase, aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#attribute_matching_model CustomerprofilesDomain#attribute_matching_model}.</summary>
            [JsiiProperty(name: "attributeMatchingModel", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeMatchingModel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#address CustomerprofilesDomain#address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Address
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#email_address CustomerprofilesDomain#email_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EmailAddress
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#phone_number CustomerprofilesDomain#phone_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PhoneNumber
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
