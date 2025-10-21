namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamUserState<'UserName> = { assignments: ResizeArray<aws.DataAwsIamUser.DataAwsIamUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user">aws_iam_user</a>.
    /// </summary>
    type DataAwsIamUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamUserState<Missing>)

        member _.Zero(()) : DataAwsIamUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user#user_name-1">DataAwsIamUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: DataAwsIamUserState<Missing>, value: string) : DataAwsIamUserState<Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : DataAwsIamUserState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user#id-1">DataAwsIamUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamUserState<'UserName>, value: string) : DataAwsIamUserState<'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamUserState<'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user#tags-1">DataAwsIamUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsIamUserState<'UserName>, value: seq<string * string>) : DataAwsIamUserState<'UserName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsIamUserState<'UserName>

        member _.Run(state: DataAwsIamUserState<Present>) : aws.DataAwsIamUser.DataAwsIamUser =
            let config = aws.DataAwsIamUser.DataAwsIamUserConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamUser.DataAwsIamUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamUser: missing required arguments. Must call: user_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamUserState<_>) : aws.DataAwsIamUser.DataAwsIamUser =
            Unchecked.defaultof<aws.DataAwsIamUser.DataAwsIamUser>
