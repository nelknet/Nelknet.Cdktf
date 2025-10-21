namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerGlobalNetworksState = { assignments: ResizeArray<aws.DataAwsNetworkmanagerGlobalNetworks.DataAwsNetworkmanagerGlobalNetworksConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_networks">aws_networkmanager_global_networks</a>.
    /// </summary>
    type DataAwsNetworkmanagerGlobalNetworksBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerGlobalNetworksState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNetworkmanagerGlobalNetworksState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_networks#id-1">DataAwsNetworkmanagerGlobalNetworks#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerGlobalNetworksState, value: string) : DataAwsNetworkmanagerGlobalNetworksState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerGlobalNetworksState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_networks#tags-1">DataAwsNetworkmanagerGlobalNetworks#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerGlobalNetworksState, value: seq<string * string>) : DataAwsNetworkmanagerGlobalNetworksState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerGlobalNetworksState

        member _.Run(state: DataAwsNetworkmanagerGlobalNetworksState) : aws.DataAwsNetworkmanagerGlobalNetworks.DataAwsNetworkmanagerGlobalNetworks =
            let config = aws.DataAwsNetworkmanagerGlobalNetworks.DataAwsNetworkmanagerGlobalNetworksConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerGlobalNetworks.DataAwsNetworkmanagerGlobalNetworks(StackContext.get (), logicalId, config)
