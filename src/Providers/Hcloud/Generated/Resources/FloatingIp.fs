namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FloatingIpState<'Type> = { assignments: ResizeArray<hcloud.FloatingIp.FloatingIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip">hcloud_floating_ip</a>.
    /// </summary>
    type FloatingIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : FloatingIpState<Missing> =
            ({ assignments = ResizeArray() } : FloatingIpState<Missing>)

        member _.Zero(()) : FloatingIpState<Missing> =
            ({ assignments = ResizeArray() } : FloatingIpState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#type-1">FloatingIp#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: FloatingIpState<Missing>, value: string) : FloatingIpState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : FloatingIpState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#delete_protection-1">FloatingIp#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: FloatingIpState<'Type>, value: bool) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#delete_protection-1">FloatingIp#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: FloatingIpState<'Type>, value: HashiCorp.Cdktf.IResolvable) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#description-1">FloatingIp#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FloatingIpState<'Type>, value: string) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#home_location-1">FloatingIp#home_location</a>.
        /// </summary>
        [<CustomOperation "home_location">]
        member _.HomeLocation(state: FloatingIpState<'Type>, value: string) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.HomeLocation <- value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#id-1">FloatingIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FloatingIpState<'Type>, value: string) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#labels-1">FloatingIp#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: FloatingIpState<'Type>, value: seq<string * string>) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#name-1">FloatingIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FloatingIpState<'Type>, value: string) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : FloatingIpState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#server_id-1">FloatingIp#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: FloatingIpState<'Type>, value: double) : FloatingIpState<'Type> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            state : FloatingIpState<'Type>

        member _.Run(state: FloatingIpState<Present>) : hcloud.FloatingIp.FloatingIp =
            let config = hcloud.FloatingIp.FloatingIpConfig()
            for setter in state.assignments do
                setter config
            hcloud.FloatingIp.FloatingIp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.floatingIp: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: FloatingIpState<_>) : hcloud.FloatingIp.FloatingIp =
            Unchecked.defaultof<hcloud.FloatingIp.FloatingIp>
