namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallAttachmentState<'FirewallId> = { assignments: ResizeArray<hcloud.FirewallAttachment.FirewallAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment">hcloud_firewall_attachment</a>.
    /// </summary>
    type FirewallAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : FirewallAttachmentState<Missing>)

        member _.Zero(()) : FirewallAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : FirewallAttachmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#firewall_id-1">FirewallAttachment#firewall_id</a>.
        /// </summary>
        [<CustomOperation "firewall_id">]
        member _.FirewallId(state: FirewallAttachmentState<Missing>, value: double) : FirewallAttachmentState<Present> =
            state.assignments.Add(fun config -> config.FirewallId <- value)
            ({ assignments = state.assignments } : FirewallAttachmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#id-1">FirewallAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallAttachmentState<'FirewallId>, value: string) : FirewallAttachmentState<'FirewallId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallAttachmentState<'FirewallId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#label_selectors-1">FirewallAttachment#label_selectors</a>.
        /// </summary>
        [<CustomOperation "label_selectors">]
        member _.LabelSelectors(state: FirewallAttachmentState<'FirewallId>, value: seq<string>) : FirewallAttachmentState<'FirewallId> =
            state.assignments.Add(fun config -> config.LabelSelectors <- (value |> Seq.toArray))
            state : FirewallAttachmentState<'FirewallId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#server_ids-1">FirewallAttachment#server_ids</a>.
        /// </summary>
        [<CustomOperation "server_ids">]
        member _.ServerIds(state: FirewallAttachmentState<'FirewallId>, value: seq<double>) : FirewallAttachmentState<'FirewallId> =
            state.assignments.Add(fun config -> config.ServerIds <- (value |> Seq.toArray))
            state : FirewallAttachmentState<'FirewallId>

        member _.Run(state: FirewallAttachmentState<Present>) : hcloud.FirewallAttachment.FirewallAttachment =
            let config = hcloud.FirewallAttachment.FirewallAttachmentConfig()
            for setter in state.assignments do
                setter config
            hcloud.FirewallAttachment.FirewallAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.firewallAttachment: missing required arguments. Must call: firewall_id.", 9999, IsError = true)>]
        member _.Run(_: FirewallAttachmentState<_>) : hcloud.FirewallAttachment.FirewallAttachment =
            Unchecked.defaultof<hcloud.FirewallAttachment.FirewallAttachment>
