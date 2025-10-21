namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId> = { assignments: ResizeArray<aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface_accepter">aws_dx_hosted_public_virtual_interface_accepter</a>.
    /// </summary>
    type DxHostedPublicVirtualInterfaceAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedPublicVirtualInterfaceAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DxHostedPublicVirtualInterfaceAccepterState<Missing>)

        member _.Zero(()) : DxHostedPublicVirtualInterfaceAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DxHostedPublicVirtualInterfaceAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface_accepter#virtual_interface_id-1">DxHostedPublicVirtualInterfaceAccepter#virtual_interface_id</a>.
        /// </summary>
        [<CustomOperation "virtual_interface_id">]
        member _.VirtualInterfaceId(state: DxHostedPublicVirtualInterfaceAccepterState<Missing>, value: string) : DxHostedPublicVirtualInterfaceAccepterState<Present> =
            state.assignments.Add(fun config -> config.VirtualInterfaceId <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface_accepter#id-1">DxHostedPublicVirtualInterfaceAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: string) : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface_accepter#tags-1">DxHostedPublicVirtualInterfaceAccepter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: seq<string * string>) : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface_accepter#tags_all-1">DxHostedPublicVirtualInterfaceAccepter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: seq<string * string>) : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface_accepter#timeouts-1">DxHostedPublicVirtualInterfaceAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>, value: aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepterTimeouts) : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxHostedPublicVirtualInterfaceAccepterState<'VirtualInterfaceId>

        member _.Run(state: DxHostedPublicVirtualInterfaceAccepterState<Present>) : aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepter =
            let config = aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedPublicVirtualInterfaceAccepter: missing required arguments. Must call: virtual_interface_id.", 9999, IsError = true)>]
        member _.Run(_: DxHostedPublicVirtualInterfaceAccepterState<_>) : aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepter =
            Unchecked.defaultof<aws.DxHostedPublicVirtualInterfaceAccepter.DxHostedPublicVirtualInterfaceAccepter>
