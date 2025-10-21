namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectUserState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectUser.DataAwsConnectUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user">aws_connect_user</a>.
    /// </summary>
    type DataAwsConnectUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectUserState<Missing>)

        member _.Zero(()) : DataAwsConnectUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user#instance_id-1">DataAwsConnectUser#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectUserState<Missing>, value: string) : DataAwsConnectUserState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectUserState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user#id-1">DataAwsConnectUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectUserState<'InstanceId>, value: string) : DataAwsConnectUserState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectUserState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user#name-1">DataAwsConnectUser#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectUserState<'InstanceId>, value: string) : DataAwsConnectUserState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectUserState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user#tags-1">DataAwsConnectUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectUserState<'InstanceId>, value: seq<string * string>) : DataAwsConnectUserState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectUserState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user#user_id-1">DataAwsConnectUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: DataAwsConnectUserState<'InstanceId>, value: string) : DataAwsConnectUserState<'InstanceId> =
            state.assignments.Add(fun config -> config.UserId <- value)
            state : DataAwsConnectUserState<'InstanceId>

        member _.Run(state: DataAwsConnectUserState<Present>) : aws.DataAwsConnectUser.DataAwsConnectUser =
            let config = aws.DataAwsConnectUser.DataAwsConnectUserConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectUser.DataAwsConnectUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectUser: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectUserState<_>) : aws.DataAwsConnectUser.DataAwsConnectUser =
            Unchecked.defaultof<aws.DataAwsConnectUser.DataAwsConnectUser>
