namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecretsmanagerRandomPasswordState = { assignments: ResizeArray<aws.DataAwsSecretsmanagerRandomPassword.DataAwsSecretsmanagerRandomPasswordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password">aws_secretsmanager_random_password</a>.
    /// </summary>
    type DataAwsSecretsmanagerRandomPasswordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecretsmanagerRandomPasswordState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSecretsmanagerRandomPasswordState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_characters-1">DataAwsSecretsmanagerRandomPassword#exclude_characters</a>.
        /// </summary>
        [<CustomOperation "exclude_characters">]
        member _.ExcludeCharacters(state: DataAwsSecretsmanagerRandomPasswordState, value: string) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeCharacters <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_lowercase-1">DataAwsSecretsmanagerRandomPassword#exclude_lowercase</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_lowercase">]
        member _.ExcludeLowercase(state: DataAwsSecretsmanagerRandomPasswordState, value: bool) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeLowercase <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_lowercase-1">DataAwsSecretsmanagerRandomPassword#exclude_lowercase</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_lowercase">]
        member _.ExcludeLowercase(state: DataAwsSecretsmanagerRandomPasswordState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeLowercase <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_numbers-1">DataAwsSecretsmanagerRandomPassword#exclude_numbers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_numbers">]
        member _.ExcludeNumbers(state: DataAwsSecretsmanagerRandomPasswordState, value: bool) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeNumbers <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_numbers-1">DataAwsSecretsmanagerRandomPassword#exclude_numbers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_numbers">]
        member _.ExcludeNumbers(state: DataAwsSecretsmanagerRandomPasswordState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeNumbers <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_punctuation-1">DataAwsSecretsmanagerRandomPassword#exclude_punctuation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_punctuation">]
        member _.ExcludePunctuation(state: DataAwsSecretsmanagerRandomPasswordState, value: bool) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludePunctuation <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_punctuation-1">DataAwsSecretsmanagerRandomPassword#exclude_punctuation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_punctuation">]
        member _.ExcludePunctuation(state: DataAwsSecretsmanagerRandomPasswordState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludePunctuation <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_uppercase-1">DataAwsSecretsmanagerRandomPassword#exclude_uppercase</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_uppercase">]
        member _.ExcludeUppercase(state: DataAwsSecretsmanagerRandomPasswordState, value: bool) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeUppercase <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#exclude_uppercase-1">DataAwsSecretsmanagerRandomPassword#exclude_uppercase</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_uppercase">]
        member _.ExcludeUppercase(state: DataAwsSecretsmanagerRandomPasswordState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.ExcludeUppercase <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#id-1">DataAwsSecretsmanagerRandomPassword#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecretsmanagerRandomPasswordState, value: string) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#include_space-1">DataAwsSecretsmanagerRandomPassword#include_space</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_space">]
        member _.IncludeSpace(state: DataAwsSecretsmanagerRandomPasswordState, value: bool) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.IncludeSpace <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#include_space-1">DataAwsSecretsmanagerRandomPassword#include_space</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_space">]
        member _.IncludeSpace(state: DataAwsSecretsmanagerRandomPasswordState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.IncludeSpace <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#password_length-1">DataAwsSecretsmanagerRandomPassword#password_length</a>.
        /// </summary>
        [<CustomOperation "password_length">]
        member _.PasswordLength(state: DataAwsSecretsmanagerRandomPasswordState, value: double) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.PasswordLength <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#require_each_included_type-1">DataAwsSecretsmanagerRandomPassword#require_each_included_type</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_each_included_type">]
        member _.RequireEachIncludedType(state: DataAwsSecretsmanagerRandomPasswordState, value: bool) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.RequireEachIncludedType <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_random_password#require_each_included_type-1">DataAwsSecretsmanagerRandomPassword#require_each_included_type</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_each_included_type">]
        member _.RequireEachIncludedType(state: DataAwsSecretsmanagerRandomPasswordState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerRandomPasswordState =
            state.assignments.Add(fun config -> config.RequireEachIncludedType <- value)
            state : DataAwsSecretsmanagerRandomPasswordState

        member _.Run(state: DataAwsSecretsmanagerRandomPasswordState) : aws.DataAwsSecretsmanagerRandomPassword.DataAwsSecretsmanagerRandomPassword =
            let config = aws.DataAwsSecretsmanagerRandomPassword.DataAwsSecretsmanagerRandomPasswordConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecretsmanagerRandomPassword.DataAwsSecretsmanagerRandomPassword(StackContext.get (), logicalId, config)
