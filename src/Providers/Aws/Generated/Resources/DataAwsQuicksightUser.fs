namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsQuicksightUserState<'UserName> = { assignments: ResizeArray<aws.DataAwsQuicksightUser.DataAwsQuicksightUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_user">aws_quicksight_user</a>.
    /// </summary>
    type DataAwsQuicksightUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsQuicksightUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightUserState<Missing>)

        member _.Zero(()) : DataAwsQuicksightUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_user#user_name-1">DataAwsQuicksightUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: DataAwsQuicksightUserState<Missing>, value: string) : DataAwsQuicksightUserState<Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : DataAwsQuicksightUserState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_user#aws_account_id-1">DataAwsQuicksightUser#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: DataAwsQuicksightUserState<'UserName>, value: string) : DataAwsQuicksightUserState<'UserName> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : DataAwsQuicksightUserState<'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_user#id-1">DataAwsQuicksightUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsQuicksightUserState<'UserName>, value: string) : DataAwsQuicksightUserState<'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsQuicksightUserState<'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_user#namespace-1">DataAwsQuicksightUser#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: DataAwsQuicksightUserState<'UserName>, value: string) : DataAwsQuicksightUserState<'UserName> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : DataAwsQuicksightUserState<'UserName>

        member _.Run(state: DataAwsQuicksightUserState<Present>) : aws.DataAwsQuicksightUser.DataAwsQuicksightUser =
            let config = aws.DataAwsQuicksightUser.DataAwsQuicksightUserConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsQuicksightUser.DataAwsQuicksightUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsQuicksightUser: missing required arguments. Must call: user_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsQuicksightUserState<_>) : aws.DataAwsQuicksightUser.DataAwsQuicksightUser =
            Unchecked.defaultof<aws.DataAwsQuicksightUser.DataAwsQuicksightUser>
