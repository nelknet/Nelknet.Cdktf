namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudSshKeyState = { assignments: ResizeArray<hcloud.DataHcloudSshKey.DataHcloudSshKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key">hcloud_ssh_key</a>.
    /// </summary>
    type DataHcloudSshKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudSshKeyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudSshKeyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Fingerprint of the SSH Key. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#fingerprint-1">DataHcloudSshKey#fingerprint</a>
        /// </summary>
        [<CustomOperation "fingerprint">]
        member _.Fingerprint(state: DataHcloudSshKeyState, value: string) : DataHcloudSshKeyState =
            state.assignments.Add(fun config -> config.Fingerprint <- value)
            state : DataHcloudSshKeyState

        /// <summary>
        /// ID of the SSH Key. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#id-1">DataHcloudSshKey#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudSshKeyState, value: double) : DataHcloudSshKeyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudSshKeyState

        /// <summary>
        /// Name of the SSH Key. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#name-1">DataHcloudSshKey#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudSshKeyState, value: string) : DataHcloudSshKeyState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudSshKeyState

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#selector-1">DataHcloudSshKey#selector</a>
        /// </summary>
        [<CustomOperation "selector">]
        member _.Selector(state: DataHcloudSshKeyState, value: string) : DataHcloudSshKeyState =
            state.assignments.Add(fun config -> config.Selector <- value)
            state : DataHcloudSshKeyState

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#with_selector-1">DataHcloudSshKey#with_selector</a>
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudSshKeyState, value: string) : DataHcloudSshKeyState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudSshKeyState

        member _.Run(state: DataHcloudSshKeyState) : hcloud.DataHcloudSshKey.DataHcloudSshKey =
            let config = hcloud.DataHcloudSshKey.DataHcloudSshKeyConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudSshKey.DataHcloudSshKey(StackContext.get (), logicalId, config)
