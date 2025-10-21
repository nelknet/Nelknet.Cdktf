namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> = { assignments: ResizeArray<aws.IdentitystoreUser.IdentitystoreUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user">aws_identitystore_user</a>.
    /// </summary>
    type IdentitystoreUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : IdentitystoreUserState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IdentitystoreUserState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IdentitystoreUserState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IdentitystoreUserState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#display_name-1">IdentitystoreUser#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: IdentitystoreUserState<Missing, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<Present, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : IdentitystoreUserState<Present, 'IdentityStoreId, 'Name, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#identity_store_id-1">IdentitystoreUser#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: IdentitystoreUserState<'DisplayName, Missing, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, Present, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : IdentitystoreUserState<'DisplayName, Present, 'Name, 'UserName>)

        /// <summary>
        /// name block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#name-1">IdentitystoreUser#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, Missing, 'UserName>, value: aws.IdentitystoreUser.IdentitystoreUserName) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, Present, 'UserName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#user_name-1">IdentitystoreUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, Missing>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, Present>)

        /// <summary>
        /// addresses block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#addresses-1">IdentitystoreUser#addresses</a>
        /// </summary>
        [<CustomOperation "addresses">]
        member _.Addresses(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: aws.IdentitystoreUser.IdentitystoreUserAddresses) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Addresses <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// emails block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#emails-1">IdentitystoreUser#emails</a>
        /// </summary>
        [<CustomOperation "emails">]
        member _.Emails(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: aws.IdentitystoreUser.IdentitystoreUserEmails) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Emails <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#id-1">IdentitystoreUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#locale-1">IdentitystoreUser#locale</a>.
        /// </summary>
        [<CustomOperation "locale">]
        member _.Locale(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Locale <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#nickname-1">IdentitystoreUser#nickname</a>.
        /// </summary>
        [<CustomOperation "nickname">]
        member _.Nickname(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Nickname <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// phone_numbers block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#phone_numbers-1">IdentitystoreUser#phone_numbers</a>
        /// </summary>
        [<CustomOperation "phone_numbers">]
        member _.PhoneNumbers(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: aws.IdentitystoreUser.IdentitystoreUserPhoneNumbers) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.PhoneNumbers <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#preferred_language-1">IdentitystoreUser#preferred_language</a>.
        /// </summary>
        [<CustomOperation "preferred_language">]
        member _.PreferredLanguage(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.PreferredLanguage <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#profile_url-1">IdentitystoreUser#profile_url</a>.
        /// </summary>
        [<CustomOperation "profile_url">]
        member _.ProfileUrl(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.ProfileUrl <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#timezone-1">IdentitystoreUser#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#title-1">IdentitystoreUser#title</a>.
        /// </summary>
        [<CustomOperation "title">]
        member _.Title(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.Title <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#user_type-1">IdentitystoreUser#user_type</a>.
        /// </summary>
        [<CustomOperation "user_type">]
        member _.UserType(state: IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>, value: string) : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName> =
            state.assignments.Add(fun config -> config.UserType <- value)
            state : IdentitystoreUserState<'DisplayName, 'IdentityStoreId, 'Name, 'UserName>

        member _.Run(state: IdentitystoreUserState<Present, Present, Present, Present>) : aws.IdentitystoreUser.IdentitystoreUser =
            let config = aws.IdentitystoreUser.IdentitystoreUserConfig()
            for setter in state.assignments do
                setter config
            aws.IdentitystoreUser.IdentitystoreUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.identitystoreUser: missing required arguments. Must call: display_name, identity_store_id, name, user_name.", 9999, IsError = true)>]
        member _.Run(_: IdentitystoreUserState<_, _, _, _>) : aws.IdentitystoreUser.IdentitystoreUser =
            Unchecked.defaultof<aws.IdentitystoreUser.IdentitystoreUser>
