using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsRegisteredDomain
{
    [JsiiByValue(fqn: "aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContact")]
    public class Route53DomainsRegisteredDomainAdminContact : aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainAdminContact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#address_line_1 Route53DomainsRegisteredDomain#address_line_1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressLine1
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#address_line_2 Route53DomainsRegisteredDomain#address_line_2}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressLine2
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#city Route53DomainsRegisteredDomain#city}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? City
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#contact_type Route53DomainsRegisteredDomain#contact_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contactType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContactType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#country_code Route53DomainsRegisteredDomain#country_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountryCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#email Route53DomainsRegisteredDomain#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#extra_params Route53DomainsRegisteredDomain#extra_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extraParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ExtraParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#fax Route53DomainsRegisteredDomain#fax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fax", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#first_name Route53DomainsRegisteredDomain#first_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#last_name Route53DomainsRegisteredDomain#last_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#organization_name Route53DomainsRegisteredDomain#organization_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#phone_number Route53DomainsRegisteredDomain#phone_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhoneNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#state Route53DomainsRegisteredDomain#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#zip_code Route53DomainsRegisteredDomain#zip_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zipCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ZipCode
        {
            get;
            set;
        }
    }
}
