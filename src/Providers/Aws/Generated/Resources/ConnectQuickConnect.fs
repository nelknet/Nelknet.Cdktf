namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig> = { assignments: ResizeArray<aws.ConnectQuickConnect.ConnectQuickConnectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect">aws_connect_quick_connect</a>.
    /// </summary>
    type ConnectQuickConnectBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectQuickConnectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectQuickConnectState<Missing, Missing, Missing>)

        member _.Zero(()) : ConnectQuickConnectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectQuickConnectState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#instance_id-1">ConnectQuickConnect#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectQuickConnectState<Missing, 'Name, 'QuickConnectConfig>, value: string) : ConnectQuickConnectState<Present, 'Name, 'QuickConnectConfig> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectQuickConnectState<Present, 'Name, 'QuickConnectConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#name-1">ConnectQuickConnect#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectQuickConnectState<'InstanceId, Missing, 'QuickConnectConfig>, value: string) : ConnectQuickConnectState<'InstanceId, Present, 'QuickConnectConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectQuickConnectState<'InstanceId, Present, 'QuickConnectConfig>)

        /// <summary>
        /// quick_connect_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#quick_connect_config-1">ConnectQuickConnect#quick_connect_config</a>
        /// </summary>
        [<CustomOperation "quick_connect_config">]
        member _.QuickConnectConfig(state: ConnectQuickConnectState<'InstanceId, 'Name, Missing>, value: aws.ConnectQuickConnect.ConnectQuickConnectQuickConnectConfig) : ConnectQuickConnectState<'InstanceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.QuickConnectConfig <- value)
            ({ assignments = state.assignments } : ConnectQuickConnectState<'InstanceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#description-1">ConnectQuickConnect#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>, value: string) : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#id-1">ConnectQuickConnect#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>, value: string) : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#tags-1">ConnectQuickConnect#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>, value: seq<string * string>) : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#tags_all-1">ConnectQuickConnect#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>, value: seq<string * string>) : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectQuickConnectState<'InstanceId, 'Name, 'QuickConnectConfig>

        member _.Run(state: ConnectQuickConnectState<Present, Present, Present>) : aws.ConnectQuickConnect.ConnectQuickConnect =
            let config = aws.ConnectQuickConnect.ConnectQuickConnectConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectQuickConnect.ConnectQuickConnect(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectQuickConnect: missing required arguments. Must call: instance_id, name, quick_connect_config.", 9999, IsError = true)>]
        member _.Run(_: ConnectQuickConnectState<_, _, _>) : aws.ConnectQuickConnect.ConnectQuickConnect =
            Unchecked.defaultof<aws.ConnectQuickConnect.ConnectQuickConnect>
