namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectQuickConnectState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_quick_connect">aws_connect_quick_connect</a>.
    /// </summary>
    type DataAwsConnectQuickConnectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectQuickConnectState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectQuickConnectState<Missing>)

        member _.Zero(()) : DataAwsConnectQuickConnectState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectQuickConnectState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_quick_connect#instance_id-1">DataAwsConnectQuickConnect#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectQuickConnectState<Missing>, value: string) : DataAwsConnectQuickConnectState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectQuickConnectState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_quick_connect#id-1">DataAwsConnectQuickConnect#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectQuickConnectState<'InstanceId>, value: string) : DataAwsConnectQuickConnectState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectQuickConnectState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_quick_connect#name-1">DataAwsConnectQuickConnect#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectQuickConnectState<'InstanceId>, value: string) : DataAwsConnectQuickConnectState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectQuickConnectState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_quick_connect#quick_connect_id-1">DataAwsConnectQuickConnect#quick_connect_id</a>.
        /// </summary>
        [<CustomOperation "quick_connect_id">]
        member _.QuickConnectId(state: DataAwsConnectQuickConnectState<'InstanceId>, value: string) : DataAwsConnectQuickConnectState<'InstanceId> =
            state.assignments.Add(fun config -> config.QuickConnectId <- value)
            state : DataAwsConnectQuickConnectState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_quick_connect#tags-1">DataAwsConnectQuickConnect#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectQuickConnectState<'InstanceId>, value: seq<string * string>) : DataAwsConnectQuickConnectState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectQuickConnectState<'InstanceId>

        member _.Run(state: DataAwsConnectQuickConnectState<Present>) : aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnect =
            let config = aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnect(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectQuickConnect: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectQuickConnectState<_>) : aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnect =
            Unchecked.defaultof<aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnect>
