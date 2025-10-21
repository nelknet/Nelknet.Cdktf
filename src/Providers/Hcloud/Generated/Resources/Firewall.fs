namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallState<'Name> = { assignments: ResizeArray<hcloud.Firewall.FirewallConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall">hcloud_firewall</a>.
    /// </summary>
    type FirewallBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallState<Missing> =
            ({ assignments = ResizeArray() } : FirewallState<Missing>)

        member _.Zero(()) : FirewallState<Missing> =
            ({ assignments = ResizeArray() } : FirewallState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#name-1">Firewall#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallState<Missing>, value: string) : FirewallState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallState<Present>)

        /// <summary>
        /// apply_to block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#apply_to-1">Firewall#apply_to</a> Accepts: hcloud.IResolvable | hcloud.Firewall.FirewallApplyTo[]
        /// </summary>
        [<CustomOperation "apply_to">]
        member _.ApplyTo(state: FirewallState<'Name>, value: HashiCorp.Cdktf.IResolvable) : FirewallState<'Name> =
            state.assignments.Add(fun config -> config.ApplyTo <- value)
            state : FirewallState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#id-1">Firewall#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallState<'Name>, value: string) : FirewallState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#labels-1">Firewall#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: FirewallState<'Name>, value: seq<string * string>) : FirewallState<'Name> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : FirewallState<'Name>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#rule-1">Firewall#rule</a> Accepts: hcloud.IResolvable | hcloud.Firewall.FirewallRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: FirewallState<'Name>, value: HashiCorp.Cdktf.IResolvable) : FirewallState<'Name> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : FirewallState<'Name>

        member _.Run(state: FirewallState<Present>) : hcloud.Firewall.Firewall =
            let config = hcloud.Firewall.FirewallConfig()
            for setter in state.assignments do
                setter config
            hcloud.Firewall.Firewall(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.firewall: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: FirewallState<_>) : hcloud.Firewall.Firewall =
            Unchecked.defaultof<hcloud.Firewall.Firewall>
