namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerConnections.DataAwsNetworkmanagerConnectionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connections">aws_networkmanager_connections</a>.
    /// </summary>
    type DataAwsNetworkmanagerConnectionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerConnectionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerConnectionsState<Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerConnectionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerConnectionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connections#global_network_id-1">DataAwsNetworkmanagerConnections#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerConnectionsState<Missing>, value: string) : DataAwsNetworkmanagerConnectionsState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerConnectionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connections#device_id-1">DataAwsNetworkmanagerConnections#device_id</a>.
        /// </summary>
        [<CustomOperation "device_id">]
        member _.DeviceId(state: DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.DeviceId <- value)
            state : DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connections#id-1">DataAwsNetworkmanagerConnections#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connections#tags-1">DataAwsNetworkmanagerConnections#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerConnectionsState<'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerConnectionsState<Present>) : aws.DataAwsNetworkmanagerConnections.DataAwsNetworkmanagerConnections =
            let config = aws.DataAwsNetworkmanagerConnections.DataAwsNetworkmanagerConnectionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerConnections.DataAwsNetworkmanagerConnections(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerConnections: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerConnectionsState<_>) : aws.DataAwsNetworkmanagerConnections.DataAwsNetworkmanagerConnections =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerConnections.DataAwsNetworkmanagerConnections>
