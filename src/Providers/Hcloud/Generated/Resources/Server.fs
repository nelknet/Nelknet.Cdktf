namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServerState<'Name, 'ServerType> = { assignments: ResizeArray<hcloud.Server.ServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server">hcloud_server</a>.
    /// </summary>
    type ServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServerState<Missing, Missing>)

        member _.Zero(()) : ServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#name-1">Server#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServerState<Missing, 'ServerType>, value: string) : ServerState<Present, 'ServerType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServerState<Present, 'ServerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#server_type-1">Server#server_type</a>.
        /// </summary>
        [<CustomOperation "server_type">]
        member _.ServerType(state: ServerState<'Name, Missing>, value: string) : ServerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ServerType <- value)
            ({ assignments = state.assignments } : ServerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#allow_deprecated_images-1">Server#allow_deprecated_images</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "allow_deprecated_images">]
        member _.AllowDeprecatedImages(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.AllowDeprecatedImages <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#allow_deprecated_images-1">Server#allow_deprecated_images</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "allow_deprecated_images">]
        member _.AllowDeprecatedImages(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.AllowDeprecatedImages <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#backups-1">Server#backups</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "backups">]
        member _.Backups(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Backups <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#backups-1">Server#backups</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "backups">]
        member _.Backups(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Backups <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#datacenter-1">Server#datacenter</a>.
        /// </summary>
        [<CustomOperation "datacenter">]
        member _.Datacenter(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Datacenter <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#delete_protection-1">Server#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#delete_protection-1">Server#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#firewall_ids-1">Server#firewall_ids</a>.
        /// </summary>
        [<CustomOperation "firewall_ids">]
        member _.FirewallIds(state: ServerState<'Name, 'ServerType>, value: seq<double>) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.FirewallIds <- (value |> Seq.toArray))
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#id-1">Server#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ignore_remote_firewall_ids-1">Server#ignore_remote_firewall_ids</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "ignore_remote_firewall_ids">]
        member _.IgnoreRemoteFirewallIds(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.IgnoreRemoteFirewallIds <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ignore_remote_firewall_ids-1">Server#ignore_remote_firewall_ids</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "ignore_remote_firewall_ids">]
        member _.IgnoreRemoteFirewallIds(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.IgnoreRemoteFirewallIds <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#image-1">Server#image</a>.
        /// </summary>
        [<CustomOperation "image">]
        member _.Image(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Image <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#iso-1">Server#iso</a>.
        /// </summary>
        [<CustomOperation "iso">]
        member _.Iso(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Iso <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#keep_disk-1">Server#keep_disk</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "keep_disk">]
        member _.KeepDisk(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.KeepDisk <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#keep_disk-1">Server#keep_disk</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "keep_disk">]
        member _.KeepDisk(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.KeepDisk <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#labels-1">Server#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: ServerState<'Name, 'ServerType>, value: seq<string * string>) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#location-1">Server#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#network-1">Server#network</a> Accepts: hcloud.IResolvable | hcloud.Server.ServerNetwork[]
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#placement_group_id-1">Server#placement_group_id</a>.
        /// </summary>
        [<CustomOperation "placement_group_id">]
        member _.PlacementGroupId(state: ServerState<'Name, 'ServerType>, value: double) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.PlacementGroupId <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// public_net block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#public_net-1">Server#public_net</a> Accepts: hcloud.IResolvable | hcloud.Server.ServerPublicNet[]
        /// </summary>
        [<CustomOperation "public_net">]
        member _.PublicNet(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.PublicNet <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#rebuild_protection-1">Server#rebuild_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "rebuild_protection">]
        member _.RebuildProtection(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.RebuildProtection <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#rebuild_protection-1">Server#rebuild_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "rebuild_protection">]
        member _.RebuildProtection(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.RebuildProtection <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#rescue-1">Server#rescue</a>.
        /// </summary>
        [<CustomOperation "rescue">]
        member _.Rescue(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Rescue <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#shutdown_before_deletion-1">Server#shutdown_before_deletion</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "shutdown_before_deletion">]
        member _.ShutdownBeforeDeletion(state: ServerState<'Name, 'ServerType>, value: bool) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.ShutdownBeforeDeletion <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#shutdown_before_deletion-1">Server#shutdown_before_deletion</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "shutdown_before_deletion">]
        member _.ShutdownBeforeDeletion(state: ServerState<'Name, 'ServerType>, value: HashiCorp.Cdktf.IResolvable) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.ShutdownBeforeDeletion <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ssh_keys-1">Server#ssh_keys</a>.
        /// </summary>
        [<CustomOperation "ssh_keys">]
        member _.SshKeys(state: ServerState<'Name, 'ServerType>, value: seq<string>) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.SshKeys <- (value |> Seq.toArray))
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#timeouts-1">Server#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServerState<'Name, 'ServerType>, value: hcloud.Server.ServerTimeouts) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServerState<'Name, 'ServerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#user_data-1">Server#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: ServerState<'Name, 'ServerType>, value: string) : ServerState<'Name, 'ServerType> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : ServerState<'Name, 'ServerType>

        member _.Run(state: ServerState<Present, Present>) : hcloud.Server.Server =
            let config = hcloud.Server.ServerConfig()
            for setter in state.assignments do
                setter config
            hcloud.Server.Server(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.server: missing required arguments. Must call: name, server_type.", 9999, IsError = true)>]
        member _.Run(_: ServerState<_, _>) : hcloud.Server.Server =
            Unchecked.defaultof<hcloud.Server.Server>
