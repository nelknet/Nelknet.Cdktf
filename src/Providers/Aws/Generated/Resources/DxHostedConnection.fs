namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> = { assignments: ResizeArray<aws.DxHostedConnection.DxHostedConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection">aws_dx_hosted_connection</a>.
    /// </summary>
    type DxHostedConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedConnectionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxHostedConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedConnectionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection#bandwidth-1">DxHostedConnection#bandwidth</a>.
        /// </summary>
        [<CustomOperation "bandwidth">]
        member _.Bandwidth(state: DxHostedConnectionState<Missing, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedConnectionState<Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Bandwidth <- value)
            ({ assignments = state.assignments } : DxHostedConnectionState<Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection#connection_id-1">DxHostedConnection#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxHostedConnectionState<'Bandwidth, Missing, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedConnectionState<'Bandwidth, Present, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxHostedConnectionState<'Bandwidth, Present, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection#name-1">DxHostedConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxHostedConnectionState<'Bandwidth, 'ConnectionId, Missing, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedConnectionState<'Bandwidth, 'ConnectionId, Present, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxHostedConnectionState<'Bandwidth, 'ConnectionId, Present, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection#owner_account_id-1">DxHostedConnection#owner_account_id</a>.
        /// </summary>
        [<CustomOperation "owner_account_id">]
        member _.OwnerAccountId(state: DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, Missing, 'Vlan>, value: string) : DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.OwnerAccountId <- value)
            ({ assignments = state.assignments } : DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection#vlan-1">DxHostedConnection#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, Missing>, value: double) : DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_connection#id-1">DxHostedConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedConnectionState<'Bandwidth, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        member _.Run(state: DxHostedConnectionState<Present, Present, Present, Present, Present>) : aws.DxHostedConnection.DxHostedConnection =
            let config = aws.DxHostedConnection.DxHostedConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedConnection.DxHostedConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedConnection: missing required arguments. Must call: bandwidth, connection_id, name, owner_account_id, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxHostedConnectionState<_, _, _, _, _>) : aws.DxHostedConnection.DxHostedConnection =
            Unchecked.defaultof<aws.DxHostedConnection.DxHostedConnection>
