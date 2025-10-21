namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SshKeyState<'Name, 'PublicKey> = { assignments: ResizeArray<hcloud.SshKey.SshKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key">hcloud_ssh_key</a>.
    /// </summary>
    type SshKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SshKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SshKeyState<Missing, Missing>)

        member _.Zero(()) : SshKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SshKeyState<Missing, Missing>)

        /// <summary>
        /// Name of the SSH Key. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key#name-1">SshKey#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SshKeyState<Missing, 'PublicKey>, value: string) : SshKeyState<Present, 'PublicKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SshKeyState<Present, 'PublicKey>)

        /// <summary>
        /// Public key of the SSH Key pair. If this is a file, it can be read using the `file` interpolation function. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key#public_key-1">SshKey#public_key</a>
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: SshKeyState<'Name, Missing>, value: string) : SshKeyState<'Name, Present> =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            ({ assignments = state.assignments } : SshKeyState<'Name, Present>)

        /// <summary>
        /// User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key#labels-1">SshKey#labels</a>
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: SshKeyState<'Name, 'PublicKey>, value: seq<string * string>) : SshKeyState<'Name, 'PublicKey> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : SshKeyState<'Name, 'PublicKey>

        member _.Run(state: SshKeyState<Present, Present>) : hcloud.SshKey.SshKey =
            let config = hcloud.SshKey.SshKeyConfig()
            for setter in state.assignments do
                setter config
            hcloud.SshKey.SshKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.sshKey: missing required arguments. Must call: name, public_key.", 9999, IsError = true)>]
        member _.Run(_: SshKeyState<_, _>) : hcloud.SshKey.SshKey =
            Unchecked.defaultof<hcloud.SshKey.SshKey>
