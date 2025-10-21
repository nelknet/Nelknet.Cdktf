namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchInboundConnectionAccepterState<'ConnectionId> = { assignments: ResizeArray<aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter">aws_opensearch_inbound_connection_accepter</a>.
    /// </summary>
    type OpensearchInboundConnectionAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchInboundConnectionAccepterState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchInboundConnectionAccepterState<Missing>)

        member _.Zero(()) : OpensearchInboundConnectionAccepterState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchInboundConnectionAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#connection_id-1">OpensearchInboundConnectionAccepter#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: OpensearchInboundConnectionAccepterState<Missing>, value: string) : OpensearchInboundConnectionAccepterState<Present> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : OpensearchInboundConnectionAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#id-1">OpensearchInboundConnectionAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchInboundConnectionAccepterState<'ConnectionId>, value: string) : OpensearchInboundConnectionAccepterState<'ConnectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchInboundConnectionAccepterState<'ConnectionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_inbound_connection_accepter#timeouts-1">OpensearchInboundConnectionAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchInboundConnectionAccepterState<'ConnectionId>, value: aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepterTimeouts) : OpensearchInboundConnectionAccepterState<'ConnectionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchInboundConnectionAccepterState<'ConnectionId>

        member _.Run(state: OpensearchInboundConnectionAccepterState<Present>) : aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepter =
            let config = aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchInboundConnectionAccepter: missing required arguments. Must call: connection_id.", 9999, IsError = true)>]
        member _.Run(_: OpensearchInboundConnectionAccepterState<_>) : aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepter =
            Unchecked.defaultof<aws.OpensearchInboundConnectionAccepter.OpensearchInboundConnectionAccepter>
