namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> = { assignments: ResizeArray<aws.AccountPrimaryContact.AccountPrimaryContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact">aws_account_primary_contact</a>.
    /// </summary>
    type AccountPrimaryContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : AccountPrimaryContactState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AccountPrimaryContactState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AccountPrimaryContactState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AccountPrimaryContactState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#address_line_1-1">AccountPrimaryContact#address_line_1</a>.
        /// </summary>
        [<CustomOperation "address_line1">]
        member _.AddressLine1(state: AccountPrimaryContactState<Missing, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<Present, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.AddressLine1 <- value)
            ({ assignments = state.assignments } : AccountPrimaryContactState<Present, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#city-1">AccountPrimaryContact#city</a>.
        /// </summary>
        [<CustomOperation "city">]
        member _.City(state: AccountPrimaryContactState<'AddressLine1, Missing, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, Present, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.City <- value)
            ({ assignments = state.assignments } : AccountPrimaryContactState<'AddressLine1, Present, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#country_code-1">AccountPrimaryContact#country_code</a>.
        /// </summary>
        [<CustomOperation "country_code">]
        member _.CountryCode(state: AccountPrimaryContactState<'AddressLine1, 'City, Missing, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, Present, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.CountryCode <- value)
            ({ assignments = state.assignments } : AccountPrimaryContactState<'AddressLine1, 'City, Present, 'FullName, 'PhoneNumber, 'PostalCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#full_name-1">AccountPrimaryContact#full_name</a>.
        /// </summary>
        [<CustomOperation "full_name">]
        member _.FullName(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, Missing, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, Present, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.FullName <- value)
            ({ assignments = state.assignments } : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, Present, 'PhoneNumber, 'PostalCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#phone_number-1">AccountPrimaryContact#phone_number</a>.
        /// </summary>
        [<CustomOperation "phone_number">]
        member _.PhoneNumber(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, Missing, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, Present, 'PostalCode> =
            state.assignments.Add(fun config -> config.PhoneNumber <- value)
            ({ assignments = state.assignments } : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, Present, 'PostalCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#postal_code-1">AccountPrimaryContact#postal_code</a>.
        /// </summary>
        [<CustomOperation "postal_code">]
        member _.PostalCode(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, Missing>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, Present> =
            state.assignments.Add(fun config -> config.PostalCode <- value)
            ({ assignments = state.assignments } : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#account_id-1">AccountPrimaryContact#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#address_line_2-1">AccountPrimaryContact#address_line_2</a>.
        /// </summary>
        [<CustomOperation "address_line2">]
        member _.AddressLine2(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.AddressLine2 <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#address_line_3-1">AccountPrimaryContact#address_line_3</a>.
        /// </summary>
        [<CustomOperation "address_line3">]
        member _.AddressLine3(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.AddressLine3 <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#company_name-1">AccountPrimaryContact#company_name</a>.
        /// </summary>
        [<CustomOperation "company_name">]
        member _.CompanyName(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.CompanyName <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#district_or_county-1">AccountPrimaryContact#district_or_county</a>.
        /// </summary>
        [<CustomOperation "district_or_county">]
        member _.DistrictOrCounty(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.DistrictOrCounty <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#id-1">AccountPrimaryContact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#state_or_region-1">AccountPrimaryContact#state_or_region</a>.
        /// </summary>
        [<CustomOperation "state_or_region">]
        member _.StateOrRegion(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.StateOrRegion <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_primary_contact#website_url-1">AccountPrimaryContact#website_url</a>.
        /// </summary>
        [<CustomOperation "website_url">]
        member _.WebsiteUrl(state: AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>, value: string) : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode> =
            state.assignments.Add(fun config -> config.WebsiteUrl <- value)
            state : AccountPrimaryContactState<'AddressLine1, 'City, 'CountryCode, 'FullName, 'PhoneNumber, 'PostalCode>

        member _.Run(state: AccountPrimaryContactState<Present, Present, Present, Present, Present, Present>) : aws.AccountPrimaryContact.AccountPrimaryContact =
            let config = aws.AccountPrimaryContact.AccountPrimaryContactConfig()
            for setter in state.assignments do
                setter config
            aws.AccountPrimaryContact.AccountPrimaryContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.accountPrimaryContact: missing required arguments. Must call: address_line1, city, country_code, full_name, phone_number, postal_code.", 9999, IsError = true)>]
        member _.Run(_: AccountPrimaryContactState<_, _, _, _, _, _>) : aws.AccountPrimaryContact.AccountPrimaryContact =
            Unchecked.defaultof<aws.AccountPrimaryContact.AccountPrimaryContact>
