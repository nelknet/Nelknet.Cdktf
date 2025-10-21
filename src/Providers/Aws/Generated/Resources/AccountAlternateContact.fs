namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title> = { assignments: ResizeArray<aws.AccountAlternateContact.AccountAlternateContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact">aws_account_alternate_contact</a>.
    /// </summary>
    type AccountAlternateContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : AccountAlternateContactState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AccountAlternateContactState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AccountAlternateContactState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AccountAlternateContactState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#alternate_contact_type-1">AccountAlternateContact#alternate_contact_type</a>.
        /// </summary>
        [<CustomOperation "alternate_contact_type">]
        member _.AlternateContactType(state: AccountAlternateContactState<Missing, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>, value: string) : AccountAlternateContactState<Present, 'EmailAddress, 'Name, 'PhoneNumber, 'Title> =
            state.assignments.Add(fun config -> config.AlternateContactType <- value)
            ({ assignments = state.assignments } : AccountAlternateContactState<Present, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#email_address-1">AccountAlternateContact#email_address</a>.
        /// </summary>
        [<CustomOperation "email_address">]
        member _.EmailAddress(state: AccountAlternateContactState<'AlternateContactType, Missing, 'Name, 'PhoneNumber, 'Title>, value: string) : AccountAlternateContactState<'AlternateContactType, Present, 'Name, 'PhoneNumber, 'Title> =
            state.assignments.Add(fun config -> config.EmailAddress <- value)
            ({ assignments = state.assignments } : AccountAlternateContactState<'AlternateContactType, Present, 'Name, 'PhoneNumber, 'Title>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#name-1">AccountAlternateContact#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AccountAlternateContactState<'AlternateContactType, 'EmailAddress, Missing, 'PhoneNumber, 'Title>, value: string) : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, Present, 'PhoneNumber, 'Title> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, Present, 'PhoneNumber, 'Title>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#phone_number-1">AccountAlternateContact#phone_number</a>.
        /// </summary>
        [<CustomOperation "phone_number">]
        member _.PhoneNumber(state: AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, Missing, 'Title>, value: string) : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, Present, 'Title> =
            state.assignments.Add(fun config -> config.PhoneNumber <- value)
            ({ assignments = state.assignments } : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, Present, 'Title>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#title-1">AccountAlternateContact#title</a>.
        /// </summary>
        [<CustomOperation "title">]
        member _.Title(state: AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, Missing>, value: string) : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, Present> =
            state.assignments.Add(fun config -> config.Title <- value)
            ({ assignments = state.assignments } : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#account_id-1">AccountAlternateContact#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>, value: string) : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#id-1">AccountAlternateContact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>, value: string) : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_alternate_contact#timeouts-1">AccountAlternateContact#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>, value: aws.AccountAlternateContact.AccountAlternateContactTimeouts) : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AccountAlternateContactState<'AlternateContactType, 'EmailAddress, 'Name, 'PhoneNumber, 'Title>

        member _.Run(state: AccountAlternateContactState<Present, Present, Present, Present, Present>) : aws.AccountAlternateContact.AccountAlternateContact =
            let config = aws.AccountAlternateContact.AccountAlternateContactConfig()
            for setter in state.assignments do
                setter config
            aws.AccountAlternateContact.AccountAlternateContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.accountAlternateContact: missing required arguments. Must call: alternate_contact_type, email_address, name, phone_number, title.", 9999, IsError = true)>]
        member _.Run(_: AccountAlternateContactState<_, _, _, _, _>) : aws.AccountAlternateContact.AccountAlternateContact =
            Unchecked.defaultof<aws.AccountAlternateContact.AccountAlternateContact>
