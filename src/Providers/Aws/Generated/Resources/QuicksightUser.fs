namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightUserState<'Email, 'IdentityType, 'UserRole> = { assignments: ResizeArray<aws.QuicksightUser.QuicksightUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user">aws_quicksight_user</a>.
    /// </summary>
    type QuicksightUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightUserState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightUserState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#email-1">QuicksightUser#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: QuicksightUserState<Missing, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<Present, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : QuicksightUserState<Present, 'IdentityType, 'UserRole>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#identity_type-1">QuicksightUser#identity_type</a>.
        /// </summary>
        [<CustomOperation "identity_type">]
        member _.IdentityType(state: QuicksightUserState<'Email, Missing, 'UserRole>, value: string) : QuicksightUserState<'Email, Present, 'UserRole> =
            state.assignments.Add(fun config -> config.IdentityType <- value)
            ({ assignments = state.assignments } : QuicksightUserState<'Email, Present, 'UserRole>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#user_role-1">QuicksightUser#user_role</a>.
        /// </summary>
        [<CustomOperation "user_role">]
        member _.UserRole(state: QuicksightUserState<'Email, 'IdentityType, Missing>, value: string) : QuicksightUserState<'Email, 'IdentityType, Present> =
            state.assignments.Add(fun config -> config.UserRole <- value)
            ({ assignments = state.assignments } : QuicksightUserState<'Email, 'IdentityType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#aws_account_id-1">QuicksightUser#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightUserState<'Email, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<'Email, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightUserState<'Email, 'IdentityType, 'UserRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#iam_arn-1">QuicksightUser#iam_arn</a>.
        /// </summary>
        [<CustomOperation "iam_arn">]
        member _.IamArn(state: QuicksightUserState<'Email, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<'Email, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.IamArn <- value)
            state : QuicksightUserState<'Email, 'IdentityType, 'UserRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#id-1">QuicksightUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightUserState<'Email, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<'Email, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightUserState<'Email, 'IdentityType, 'UserRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#namespace-1">QuicksightUser#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: QuicksightUserState<'Email, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<'Email, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : QuicksightUserState<'Email, 'IdentityType, 'UserRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#session_name-1">QuicksightUser#session_name</a>.
        /// </summary>
        [<CustomOperation "session_name">]
        member _.SessionName(state: QuicksightUserState<'Email, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<'Email, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.SessionName <- value)
            state : QuicksightUserState<'Email, 'IdentityType, 'UserRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_user#user_name-1">QuicksightUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: QuicksightUserState<'Email, 'IdentityType, 'UserRole>, value: string) : QuicksightUserState<'Email, 'IdentityType, 'UserRole> =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : QuicksightUserState<'Email, 'IdentityType, 'UserRole>

        member _.Run(state: QuicksightUserState<Present, Present, Present>) : aws.QuicksightUser.QuicksightUser =
            let config = aws.QuicksightUser.QuicksightUserConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightUser.QuicksightUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightUser: missing required arguments. Must call: email, identity_type, user_role.", 9999, IsError = true)>]
        member _.Run(_: QuicksightUserState<_, _, _>) : aws.QuicksightUser.QuicksightUser =
            Unchecked.defaultof<aws.QuicksightUser.QuicksightUser>
