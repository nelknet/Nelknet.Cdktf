namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerConnection.DataAwsNetworkmanagerConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connection">aws_networkmanager_connection</a>.
    /// </summary>
    type DataAwsNetworkmanagerConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerConnectionState<Missing, Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connection#connection_id-1">DataAwsNetworkmanagerConnection#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DataAwsNetworkmanagerConnectionState<Missing, 'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerConnectionState<Present, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerConnectionState<Present, 'GlobalNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connection#global_network_id-1">DataAwsNetworkmanagerConnection#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerConnectionState<'ConnectionId, Missing>, value: string) : DataAwsNetworkmanagerConnectionState<'ConnectionId, Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerConnectionState<'ConnectionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connection#id-1">DataAwsNetworkmanagerConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_connection#tags-1">DataAwsNetworkmanagerConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerConnectionState<'ConnectionId, 'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerConnectionState<Present, Present>) : aws.DataAwsNetworkmanagerConnection.DataAwsNetworkmanagerConnection =
            let config = aws.DataAwsNetworkmanagerConnection.DataAwsNetworkmanagerConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerConnection.DataAwsNetworkmanagerConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerConnection: missing required arguments. Must call: connection_id, global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerConnectionState<_, _>) : aws.DataAwsNetworkmanagerConnection.DataAwsNetworkmanagerConnection =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerConnection.DataAwsNetworkmanagerConnection>
