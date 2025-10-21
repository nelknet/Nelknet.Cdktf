namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamAccountPasswordPolicyState = { assignments: ResizeArray<aws.IamAccountPasswordPolicy.IamAccountPasswordPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy">aws_iam_account_password_policy</a>.
    /// </summary>
    type IamAccountPasswordPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamAccountPasswordPolicyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : IamAccountPasswordPolicyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#allow_users_to_change_password-1">IamAccountPasswordPolicy#allow_users_to_change_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_users_to_change_password">]
        member _.AllowUsersToChangePassword(state: IamAccountPasswordPolicyState, value: bool) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.AllowUsersToChangePassword <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#allow_users_to_change_password-1">IamAccountPasswordPolicy#allow_users_to_change_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_users_to_change_password">]
        member _.AllowUsersToChangePassword(state: IamAccountPasswordPolicyState, value: HashiCorp.Cdktf.IResolvable) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.AllowUsersToChangePassword <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#hard_expiry-1">IamAccountPasswordPolicy#hard_expiry</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hard_expiry">]
        member _.HardExpiry(state: IamAccountPasswordPolicyState, value: bool) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.HardExpiry <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#hard_expiry-1">IamAccountPasswordPolicy#hard_expiry</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hard_expiry">]
        member _.HardExpiry(state: IamAccountPasswordPolicyState, value: HashiCorp.Cdktf.IResolvable) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.HardExpiry <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#id-1">IamAccountPasswordPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamAccountPasswordPolicyState, value: string) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#max_password_age-1">IamAccountPasswordPolicy#max_password_age</a>.
        /// </summary>
        [<CustomOperation "max_password_age">]
        member _.MaxPasswordAge(state: IamAccountPasswordPolicyState, value: double) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.MaxPasswordAge <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#minimum_password_length-1">IamAccountPasswordPolicy#minimum_password_length</a>.
        /// </summary>
        [<CustomOperation "minimum_password_length">]
        member _.MinimumPasswordLength(state: IamAccountPasswordPolicyState, value: double) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.MinimumPasswordLength <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#password_reuse_prevention-1">IamAccountPasswordPolicy#password_reuse_prevention</a>.
        /// </summary>
        [<CustomOperation "password_reuse_prevention">]
        member _.PasswordReusePrevention(state: IamAccountPasswordPolicyState, value: double) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.PasswordReusePrevention <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_lowercase_characters-1">IamAccountPasswordPolicy#require_lowercase_characters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_lowercase_characters">]
        member _.RequireLowercaseCharacters(state: IamAccountPasswordPolicyState, value: bool) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireLowercaseCharacters <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_lowercase_characters-1">IamAccountPasswordPolicy#require_lowercase_characters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_lowercase_characters">]
        member _.RequireLowercaseCharacters(state: IamAccountPasswordPolicyState, value: HashiCorp.Cdktf.IResolvable) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireLowercaseCharacters <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_numbers-1">IamAccountPasswordPolicy#require_numbers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_numbers">]
        member _.RequireNumbers(state: IamAccountPasswordPolicyState, value: bool) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireNumbers <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_numbers-1">IamAccountPasswordPolicy#require_numbers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_numbers">]
        member _.RequireNumbers(state: IamAccountPasswordPolicyState, value: HashiCorp.Cdktf.IResolvable) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireNumbers <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_symbols-1">IamAccountPasswordPolicy#require_symbols</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_symbols">]
        member _.RequireSymbols(state: IamAccountPasswordPolicyState, value: bool) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireSymbols <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_symbols-1">IamAccountPasswordPolicy#require_symbols</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_symbols">]
        member _.RequireSymbols(state: IamAccountPasswordPolicyState, value: HashiCorp.Cdktf.IResolvable) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireSymbols <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_uppercase_characters-1">IamAccountPasswordPolicy#require_uppercase_characters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_uppercase_characters">]
        member _.RequireUppercaseCharacters(state: IamAccountPasswordPolicyState, value: bool) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireUppercaseCharacters <- value)
            state : IamAccountPasswordPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_password_policy#require_uppercase_characters-1">IamAccountPasswordPolicy#require_uppercase_characters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_uppercase_characters">]
        member _.RequireUppercaseCharacters(state: IamAccountPasswordPolicyState, value: HashiCorp.Cdktf.IResolvable) : IamAccountPasswordPolicyState =
            state.assignments.Add(fun config -> config.RequireUppercaseCharacters <- value)
            state : IamAccountPasswordPolicyState

        member _.Run(state: IamAccountPasswordPolicyState) : aws.IamAccountPasswordPolicy.IamAccountPasswordPolicy =
            let config = aws.IamAccountPasswordPolicy.IamAccountPasswordPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.IamAccountPasswordPolicy.IamAccountPasswordPolicy(StackContext.get (), logicalId, config)
