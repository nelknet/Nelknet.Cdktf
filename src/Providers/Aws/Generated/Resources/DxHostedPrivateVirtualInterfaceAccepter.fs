namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> = { assignments: ResizeArray<aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter">aws_dx_hosted_private_virtual_interface_accepter</a>.
    /// </summary>
    type DxHostedPrivateVirtualInterfaceAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedPrivateVirtualInterfaceAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DxHostedPrivateVirtualInterfaceAccepterState<Missing>)

        member _.Zero(()) : DxHostedPrivateVirtualInterfaceAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DxHostedPrivateVirtualInterfaceAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#virtual_interface_id-1">DxHostedPrivateVirtualInterfaceAccepter#virtual_interface_id</a>.
        /// </summary>
        [<CustomOperation "virtual_interface_id">]
        member _.VirtualInterfaceId(state: DxHostedPrivateVirtualInterfaceAccepterState<Missing>, value: string) : DxHostedPrivateVirtualInterfaceAccepterState<Present> =
            state.assignments.Add(fun config -> config.VirtualInterfaceId <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#dx_gateway_id-1">DxHostedPrivateVirtualInterfaceAccepter#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: string) : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            state : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#id-1">DxHostedPrivateVirtualInterfaceAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: string) : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#tags-1">DxHostedPrivateVirtualInterfaceAccepter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: seq<string * string>) : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#tags_all-1">DxHostedPrivateVirtualInterfaceAccepter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: seq<string * string>) : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#timeouts-1">DxHostedPrivateVirtualInterfaceAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepterTimeouts) : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface_accepter#vpn_gateway_id-1">DxHostedPrivateVirtualInterfaceAccepter#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: string) : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            state : DxHostedPrivateVirtualInterfaceAccepterState<'VirtualInterfaceId>

        member _.Run(state: DxHostedPrivateVirtualInterfaceAccepterState<Present>) : aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepter =
            let config = aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedPrivateVirtualInterfaceAccepter: missing required arguments. Must call: virtual_interface_id.", 9999, IsError = true)>]
        member _.Run(_: DxHostedPrivateVirtualInterfaceAccepterState<_>) : aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepter =
            Unchecked.defaultof<aws.DxHostedPrivateVirtualInterfaceAccepter.DxHostedPrivateVirtualInterfaceAccepter>
