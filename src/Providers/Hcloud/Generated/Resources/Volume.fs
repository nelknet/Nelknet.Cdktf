namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VolumeState<'Name, 'Size> = { assignments: ResizeArray<hcloud.Volume.VolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume">hcloud_volume</a>.
    /// </summary>
    type VolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : VolumeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VolumeState<Missing, Missing>)

        member _.Zero(()) : VolumeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VolumeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#name-1">Volume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VolumeState<Missing, 'Size>, value: string) : VolumeState<Present, 'Size> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VolumeState<Present, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#size-1">Volume#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: VolumeState<'Name, Missing>, value: double) : VolumeState<'Name, Present> =
            state.assignments.Add(fun config -> config.Size <- value)
            ({ assignments = state.assignments } : VolumeState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#automount-1">Volume#automount</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "automount">]
        member _.Automount(state: VolumeState<'Name, 'Size>, value: bool) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.Automount <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#automount-1">Volume#automount</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "automount">]
        member _.Automount(state: VolumeState<'Name, 'Size>, value: HashiCorp.Cdktf.IResolvable) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.Automount <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#delete_protection-1">Volume#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: VolumeState<'Name, 'Size>, value: bool) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#delete_protection-1">Volume#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: VolumeState<'Name, 'Size>, value: HashiCorp.Cdktf.IResolvable) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#format-1">Volume#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: VolumeState<'Name, 'Size>, value: string) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.Format <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#id-1">Volume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VolumeState<'Name, 'Size>, value: string) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#labels-1">Volume#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: VolumeState<'Name, 'Size>, value: seq<string * string>) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#location-1">Volume#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VolumeState<'Name, 'Size>, value: string) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : VolumeState<'Name, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#server_id-1">Volume#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: VolumeState<'Name, 'Size>, value: double) : VolumeState<'Name, 'Size> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            state : VolumeState<'Name, 'Size>

        member _.Run(state: VolumeState<Present, Present>) : hcloud.Volume.Volume =
            let config = hcloud.Volume.VolumeConfig()
            for setter in state.assignments do
                setter config
            hcloud.Volume.Volume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.volume: missing required arguments. Must call: name, size.", 9999, IsError = true)>]
        member _.Run(_: VolumeState<_, _>) : hcloud.Volume.Volume =
            Unchecked.defaultof<hcloud.Volume.Volume>
