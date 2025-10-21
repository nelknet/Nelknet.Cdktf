namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerCoreNetworkState<'GlobalNetworkId> = { assignments: ResizeArray<aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network">aws_networkmanager_core_network</a>.
    /// </summary>
    type NetworkmanagerCoreNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerCoreNetworkState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerCoreNetworkState<Missing>)

        member _.Zero(()) : NetworkmanagerCoreNetworkState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerCoreNetworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#global_network_id-1">NetworkmanagerCoreNetwork#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerCoreNetworkState<Missing>, value: string) : NetworkmanagerCoreNetworkState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerCoreNetworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#base_policy_document-1">NetworkmanagerCoreNetwork#base_policy_document</a>.
        /// </summary>
        [<CustomOperation "base_policy_document">]
        member _.BasePolicyDocument(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: string) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.BasePolicyDocument <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#base_policy_region-1">NetworkmanagerCoreNetwork#base_policy_region</a>.
        /// </summary>
        [<CustomOperation "base_policy_region">]
        member _.BasePolicyRegion(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: string) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.BasePolicyRegion <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#base_policy_regions-1">NetworkmanagerCoreNetwork#base_policy_regions</a>.
        /// </summary>
        [<CustomOperation "base_policy_regions">]
        member _.BasePolicyRegions(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: seq<string>) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.BasePolicyRegions <- (value |> Seq.toArray))
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#create_base_policy-1">NetworkmanagerCoreNetwork#create_base_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_base_policy">]
        member _.CreateBasePolicy(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: bool) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.CreateBasePolicy <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#create_base_policy-1">NetworkmanagerCoreNetwork#create_base_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_base_policy">]
        member _.CreateBasePolicy(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: HashiCorp.Cdktf.IResolvable) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.CreateBasePolicy <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#description-1">NetworkmanagerCoreNetwork#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: string) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#id-1">NetworkmanagerCoreNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: string) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#tags-1">NetworkmanagerCoreNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#tags_all-1">NetworkmanagerCoreNetwork#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network#timeouts-1">NetworkmanagerCoreNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerCoreNetworkState<'GlobalNetworkId>, value: aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetworkTimeouts) : NetworkmanagerCoreNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerCoreNetworkState<'GlobalNetworkId>

        member _.Run(state: NetworkmanagerCoreNetworkState<Present>) : aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetwork =
            let config = aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetworkConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerCoreNetwork: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerCoreNetworkState<_>) : aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetwork =
            Unchecked.defaultof<aws.NetworkmanagerCoreNetwork.NetworkmanagerCoreNetwork>
