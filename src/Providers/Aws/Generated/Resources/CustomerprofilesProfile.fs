namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CustomerprofilesProfileState<'DomainName> = { assignments: ResizeArray<aws.CustomerprofilesProfile.CustomerprofilesProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile">aws_customerprofiles_profile</a>.
    /// </summary>
    type CustomerprofilesProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : CustomerprofilesProfileState<Missing> =
            ({ assignments = ResizeArray() } : CustomerprofilesProfileState<Missing>)

        member _.Zero(()) : CustomerprofilesProfileState<Missing> =
            ({ assignments = ResizeArray() } : CustomerprofilesProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#domain_name-1">CustomerprofilesProfile#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: CustomerprofilesProfileState<Missing>, value: string) : CustomerprofilesProfileState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : CustomerprofilesProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#account_number-1">CustomerprofilesProfile#account_number</a>.
        /// </summary>
        [<CustomOperation "account_number">]
        member _.AccountNumber(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.AccountNumber <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#additional_information-1">CustomerprofilesProfile#additional_information</a>.
        /// </summary>
        [<CustomOperation "additional_information">]
        member _.AdditionalInformation(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.AdditionalInformation <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// address block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#address-1">CustomerprofilesProfile#address</a>
        /// </summary>
        [<CustomOperation "address">]
        member _.Address(state: CustomerprofilesProfileState<'DomainName>, value: aws.CustomerprofilesProfile.CustomerprofilesProfileAddress) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.Address <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#attributes-1">CustomerprofilesProfile#attributes</a>.
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: CustomerprofilesProfileState<'DomainName>, value: seq<string * string>) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.Attributes <- dict value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// billing_address block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#billing_address-1">CustomerprofilesProfile#billing_address</a>
        /// </summary>
        [<CustomOperation "billing_address">]
        member _.BillingAddress(state: CustomerprofilesProfileState<'DomainName>, value: aws.CustomerprofilesProfile.CustomerprofilesProfileBillingAddress) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingAddress <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#birth_date-1">CustomerprofilesProfile#birth_date</a>.
        /// </summary>
        [<CustomOperation "birth_date">]
        member _.BirthDate(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.BirthDate <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#business_email_address-1">CustomerprofilesProfile#business_email_address</a>.
        /// </summary>
        [<CustomOperation "business_email_address">]
        member _.BusinessEmailAddress(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.BusinessEmailAddress <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#business_name-1">CustomerprofilesProfile#business_name</a>.
        /// </summary>
        [<CustomOperation "business_name">]
        member _.BusinessName(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.BusinessName <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#business_phone_number-1">CustomerprofilesProfile#business_phone_number</a>.
        /// </summary>
        [<CustomOperation "business_phone_number">]
        member _.BusinessPhoneNumber(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.BusinessPhoneNumber <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#email_address-1">CustomerprofilesProfile#email_address</a>.
        /// </summary>
        [<CustomOperation "email_address">]
        member _.EmailAddress(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.EmailAddress <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#first_name-1">CustomerprofilesProfile#first_name</a>.
        /// </summary>
        [<CustomOperation "first_name">]
        member _.FirstName(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.FirstName <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#gender_string-1">CustomerprofilesProfile#gender_string</a>.
        /// </summary>
        [<CustomOperation "gender_string">]
        member _.GenderString(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.GenderString <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#home_phone_number-1">CustomerprofilesProfile#home_phone_number</a>.
        /// </summary>
        [<CustomOperation "home_phone_number">]
        member _.HomePhoneNumber(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.HomePhoneNumber <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#id-1">CustomerprofilesProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#last_name-1">CustomerprofilesProfile#last_name</a>.
        /// </summary>
        [<CustomOperation "last_name">]
        member _.LastName(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.LastName <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// mailing_address block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#mailing_address-1">CustomerprofilesProfile#mailing_address</a>
        /// </summary>
        [<CustomOperation "mailing_address">]
        member _.MailingAddress(state: CustomerprofilesProfileState<'DomainName>, value: aws.CustomerprofilesProfile.CustomerprofilesProfileMailingAddress) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.MailingAddress <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#middle_name-1">CustomerprofilesProfile#middle_name</a>.
        /// </summary>
        [<CustomOperation "middle_name">]
        member _.MiddleName(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.MiddleName <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#mobile_phone_number-1">CustomerprofilesProfile#mobile_phone_number</a>.
        /// </summary>
        [<CustomOperation "mobile_phone_number">]
        member _.MobilePhoneNumber(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.MobilePhoneNumber <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#party_type_string-1">CustomerprofilesProfile#party_type_string</a>.
        /// </summary>
        [<CustomOperation "party_type_string">]
        member _.PartyTypeString(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.PartyTypeString <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#personal_email_address-1">CustomerprofilesProfile#personal_email_address</a>.
        /// </summary>
        [<CustomOperation "personal_email_address">]
        member _.PersonalEmailAddress(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.PersonalEmailAddress <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#phone_number-1">CustomerprofilesProfile#phone_number</a>.
        /// </summary>
        [<CustomOperation "phone_number">]
        member _.PhoneNumber(state: CustomerprofilesProfileState<'DomainName>, value: string) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.PhoneNumber <- value)
            state : CustomerprofilesProfileState<'DomainName>

        /// <summary>
        /// shipping_address block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#shipping_address-1">CustomerprofilesProfile#shipping_address</a>
        /// </summary>
        [<CustomOperation "shipping_address">]
        member _.ShippingAddress(state: CustomerprofilesProfileState<'DomainName>, value: aws.CustomerprofilesProfile.CustomerprofilesProfileShippingAddress) : CustomerprofilesProfileState<'DomainName> =
            state.assignments.Add(fun config -> config.ShippingAddress <- value)
            state : CustomerprofilesProfileState<'DomainName>

        member _.Run(state: CustomerprofilesProfileState<Present>) : aws.CustomerprofilesProfile.CustomerprofilesProfile =
            let config = aws.CustomerprofilesProfile.CustomerprofilesProfileConfig()
            for setter in state.assignments do
                setter config
            aws.CustomerprofilesProfile.CustomerprofilesProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.customerprofilesProfile: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: CustomerprofilesProfileState<_>) : aws.CustomerprofilesProfile.CustomerprofilesProfile =
            Unchecked.defaultof<aws.CustomerprofilesProfile.CustomerprofilesProfile>
