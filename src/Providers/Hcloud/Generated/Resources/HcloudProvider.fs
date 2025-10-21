namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HcloudProviderState = { assignments: ResizeArray<hcloud.Provider.HcloudProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs">hcloud</a>.
    /// </summary>
    type HcloudProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : HcloudProviderState =
            { assignments = ResizeArray() }

        member _.Zero(()) : HcloudProviderState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Alias name. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#alias-1">HcloudProvider#alias</a>
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: HcloudProviderState, value: string) : HcloudProviderState =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : HcloudProviderState

        /// <summary>
        /// The Hetzner Cloud API endpoint, can be used to override the default API Endpoint https://api.hetzner.cloud/v1. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#endpoint-1">HcloudProvider#endpoint</a>
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: HcloudProviderState, value: string) : HcloudProviderState =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : HcloudProviderState

        /// <summary>
        /// The type of function to be used during the polling. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_function-1">HcloudProvider#poll_function</a>
        /// </summary>
        [<CustomOperation "poll_function">]
        member _.PollFunction(state: HcloudProviderState, value: string) : HcloudProviderState =
            state.assignments.Add(fun config -> config.PollFunction <- value)
            state : HcloudProviderState

        /// <summary>
        /// The interval at which actions are polled by the client. Default `500ms`. Increase this interval if you run into rate limiting errors. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_interval-1">HcloudProvider#poll_interval</a>
        /// </summary>
        [<CustomOperation "poll_interval">]
        member _.PollInterval(state: HcloudProviderState, value: string) : HcloudProviderState =
            state.assignments.Add(fun config -> config.PollInterval <- value)
            state : HcloudProviderState

        /// <summary>
        /// The Hetzner Cloud API token, can also be specified with the HCLOUD_TOKEN environment variable. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#token-1">HcloudProvider#token</a>
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: HcloudProviderState, value: string) : HcloudProviderState =
            state.assignments.Add(fun config -> config.Token <- value)
            state : HcloudProviderState

        member _.Run(state: HcloudProviderState) : hcloud.Provider.HcloudProvider =
            let config = hcloud.Provider.HcloudProviderConfig()
            for setter in state.assignments do
                setter config
            hcloud.Provider.HcloudProvider(StackContext.get (), logicalId, config)
