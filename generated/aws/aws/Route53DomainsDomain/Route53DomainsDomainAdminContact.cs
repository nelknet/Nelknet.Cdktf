using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsDomain
{
    [JsiiByValue(fqn: "aws.route53DomainsDomain.Route53DomainsDomainAdminContact")]
    public class Route53DomainsDomainAdminContact : aws.Route53DomainsDomain.IRoute53DomainsDomainAdminContact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#address_line_1 Route53DomainsDomain#address_line_1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressLine1
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#address_line_2 Route53DomainsDomain#address_line_2}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressLine2
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#city Route53DomainsDomain#city}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? City
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#contact_type Route53DomainsDomain#contact_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contactType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContactType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#country_code Route53DomainsDomain#country_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountryCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#email Route53DomainsDomain#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        private object? _extraParam;

        /// <summary>extra_param block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#extra_param Route53DomainsDomain#extra_param}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extraParam", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsDomain.Route53DomainsDomainAdminContactExtraParam\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExtraParam
        {
            get => _extraParam;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53DomainsDomain.IRoute53DomainsDomainAdminContactExtraParam[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53DomainsDomain.IRoute53DomainsDomainAdminContactExtraParam).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extraParam = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#fax Route53DomainsDomain#fax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fax", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#first_name Route53DomainsDomain#first_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#last_name Route53DomainsDomain#last_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#organization_name Route53DomainsDomain#organization_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#phone_number Route53DomainsDomain#phone_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhoneNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#state Route53DomainsDomain#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#zip_code Route53DomainsDomain#zip_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zipCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ZipCode
        {
            get;
            set;
        }
    }
}
