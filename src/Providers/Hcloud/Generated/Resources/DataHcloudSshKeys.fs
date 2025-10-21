namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudSshKeysState = { assignments: ResizeArray<hcloud.DataHcloudSshKeys.DataHcloudSshKeysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_keys">hcloud_ssh_keys</a>.
    /// </summary>
    type DataHcloudSshKeysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudSshKeysState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudSshKeysState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_keys#id-1">DataHcloudSshKeys#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudSshKeysState, value: string) : DataHcloudSshKeysState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudSshKeysState

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_keys#with_selector-1">DataHcloudSshKeys#with_selector</a>
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudSshKeysState, value: string) : DataHcloudSshKeysState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudSshKeysState

        member _.Run(state: DataHcloudSshKeysState) : hcloud.DataHcloudSshKeys.DataHcloudSshKeys =
            let config = hcloud.DataHcloudSshKeys.DataHcloudSshKeysConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudSshKeys.DataHcloudSshKeys(StackContext.get (), logicalId, config)
