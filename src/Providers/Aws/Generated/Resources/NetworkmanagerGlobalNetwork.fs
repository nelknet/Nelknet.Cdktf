namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerGlobalNetworkState = { assignments: ResizeArray<aws.NetworkmanagerGlobalNetwork.NetworkmanagerGlobalNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_global_network">aws_networkmanager_global_network</a>.
    /// </summary>
    type NetworkmanagerGlobalNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerGlobalNetworkState =
            { assignments = ResizeArray() }

        member _.Zero(()) : NetworkmanagerGlobalNetworkState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_global_network#description-1">NetworkmanagerGlobalNetwork#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkmanagerGlobalNetworkState, value: string) : NetworkmanagerGlobalNetworkState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkmanagerGlobalNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_global_network#id-1">NetworkmanagerGlobalNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerGlobalNetworkState, value: string) : NetworkmanagerGlobalNetworkState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerGlobalNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_global_network#tags-1">NetworkmanagerGlobalNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerGlobalNetworkState, value: seq<string * string>) : NetworkmanagerGlobalNetworkState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerGlobalNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_global_network#tags_all-1">NetworkmanagerGlobalNetwork#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerGlobalNetworkState, value: seq<string * string>) : NetworkmanagerGlobalNetworkState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerGlobalNetworkState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_global_network#timeouts-1">NetworkmanagerGlobalNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerGlobalNetworkState, value: aws.NetworkmanagerGlobalNetwork.NetworkmanagerGlobalNetworkTimeouts) : NetworkmanagerGlobalNetworkState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerGlobalNetworkState

        member _.Run(state: NetworkmanagerGlobalNetworkState) : aws.NetworkmanagerGlobalNetwork.NetworkmanagerGlobalNetwork =
            let config = aws.NetworkmanagerGlobalNetwork.NetworkmanagerGlobalNetworkConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerGlobalNetwork.NetworkmanagerGlobalNetwork(StackContext.get (), logicalId, config)
