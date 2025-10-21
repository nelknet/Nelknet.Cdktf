namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId> = { assignments: ResizeArray<aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter">aws_dx_hosted_transit_virtual_interface_accepter</a>.
    /// </summary>
    type DxHostedTransitVirtualInterfaceAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedTransitVirtualInterfaceAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedTransitVirtualInterfaceAccepterState<Missing, Missing>)

        member _.Zero(()) : DxHostedTransitVirtualInterfaceAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedTransitVirtualInterfaceAccepterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter#dx_gateway_id-1">DxHostedTransitVirtualInterfaceAccepter#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DxHostedTransitVirtualInterfaceAccepterState<Missing, 'VirtualInterfaceId>, value: string) : DxHostedTransitVirtualInterfaceAccepterState<Present, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceAccepterState<Present, 'VirtualInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter#virtual_interface_id-1">DxHostedTransitVirtualInterfaceAccepter#virtual_interface_id</a>.
        /// </summary>
        [<CustomOperation "virtual_interface_id">]
        member _.VirtualInterfaceId(state: DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, Missing>, value: string) : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, Present> =
            state.assignments.Add(fun config -> config.VirtualInterfaceId <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter#id-1">DxHostedTransitVirtualInterfaceAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>, value: string) : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter#tags-1">DxHostedTransitVirtualInterfaceAccepter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>, value: seq<string * string>) : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter#tags_all-1">DxHostedTransitVirtualInterfaceAccepter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>, value: seq<string * string>) : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface_accepter#timeouts-1">DxHostedTransitVirtualInterfaceAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>, value: aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepterTimeouts) : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxHostedTransitVirtualInterfaceAccepterState<'DxGatewayId, 'VirtualInterfaceId>

        member _.Run(state: DxHostedTransitVirtualInterfaceAccepterState<Present, Present>) : aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepter =
            let config = aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedTransitVirtualInterfaceAccepter: missing required arguments. Must call: dx_gateway_id, virtual_interface_id.", 9999, IsError = true)>]
        member _.Run(_: DxHostedTransitVirtualInterfaceAccepterState<_, _>) : aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepter =
            Unchecked.defaultof<aws.DxHostedTransitVirtualInterfaceAccepter.DxHostedTransitVirtualInterfaceAccepter>
