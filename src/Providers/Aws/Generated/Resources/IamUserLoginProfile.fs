namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserLoginProfileState<'User> = { assignments: ResizeArray<aws.IamUserLoginProfile.IamUserLoginProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile">aws_iam_user_login_profile</a>.
    /// </summary>
    type IamUserLoginProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserLoginProfileState<Missing> =
            ({ assignments = ResizeArray() } : IamUserLoginProfileState<Missing>)

        member _.Zero(()) : IamUserLoginProfileState<Missing> =
            ({ assignments = ResizeArray() } : IamUserLoginProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile#user-1">IamUserLoginProfile#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: IamUserLoginProfileState<Missing>, value: string) : IamUserLoginProfileState<Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : IamUserLoginProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile#id-1">IamUserLoginProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamUserLoginProfileState<'User>, value: string) : IamUserLoginProfileState<'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamUserLoginProfileState<'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile#password_length-1">IamUserLoginProfile#password_length</a>.
        /// </summary>
        [<CustomOperation "password_length">]
        member _.PasswordLength(state: IamUserLoginProfileState<'User>, value: double) : IamUserLoginProfileState<'User> =
            state.assignments.Add(fun config -> config.PasswordLength <- value)
            state : IamUserLoginProfileState<'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile#password_reset_required-1">IamUserLoginProfile#password_reset_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "password_reset_required">]
        member _.PasswordResetRequired(state: IamUserLoginProfileState<'User>, value: bool) : IamUserLoginProfileState<'User> =
            state.assignments.Add(fun config -> config.PasswordResetRequired <- value)
            state : IamUserLoginProfileState<'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile#password_reset_required-1">IamUserLoginProfile#password_reset_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "password_reset_required">]
        member _.PasswordResetRequired(state: IamUserLoginProfileState<'User>, value: HashiCorp.Cdktf.IResolvable) : IamUserLoginProfileState<'User> =
            state.assignments.Add(fun config -> config.PasswordResetRequired <- value)
            state : IamUserLoginProfileState<'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_login_profile#pgp_key-1">IamUserLoginProfile#pgp_key</a>.
        /// </summary>
        [<CustomOperation "pgp_key">]
        member _.PgpKey(state: IamUserLoginProfileState<'User>, value: string) : IamUserLoginProfileState<'User> =
            state.assignments.Add(fun config -> config.PgpKey <- value)
            state : IamUserLoginProfileState<'User>

        member _.Run(state: IamUserLoginProfileState<Present>) : aws.IamUserLoginProfile.IamUserLoginProfile =
            let config = aws.IamUserLoginProfile.IamUserLoginProfileConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserLoginProfile.IamUserLoginProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserLoginProfile: missing required arguments. Must call: user.", 9999, IsError = true)>]
        member _.Run(_: IamUserLoginProfileState<_>) : aws.IamUserLoginProfile.IamUserLoginProfile =
            Unchecked.defaultof<aws.IamUserLoginProfile.IamUserLoginProfile>
