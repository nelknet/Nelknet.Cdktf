namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamUsersState = { assignments: ResizeArray<aws.DataAwsIamUsers.DataAwsIamUsersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_users">aws_iam_users</a>.
    /// </summary>
    type DataAwsIamUsersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamUsersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamUsersState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_users#id-1">DataAwsIamUsers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamUsersState, value: string) : DataAwsIamUsersState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamUsersState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_users#name_regex-1">DataAwsIamUsers#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsIamUsersState, value: string) : DataAwsIamUsersState =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsIamUsersState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_users#path_prefix-1">DataAwsIamUsers#path_prefix</a>.
        /// </summary>
        [<CustomOperation "path_prefix">]
        member _.PathPrefix(state: DataAwsIamUsersState, value: string) : DataAwsIamUsersState =
            state.assignments.Add(fun config -> config.PathPrefix <- value)
            state : DataAwsIamUsersState

        member _.Run(state: DataAwsIamUsersState) : aws.DataAwsIamUsers.DataAwsIamUsers =
            let config = aws.DataAwsIamUsers.DataAwsIamUsersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamUsers.DataAwsIamUsers(StackContext.get (), logicalId, config)
