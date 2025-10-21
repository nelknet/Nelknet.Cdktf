namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerGlobalNetwork.DataAwsNetworkmanagerGlobalNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_network">aws_networkmanager_global_network</a>.
    /// </summary>
    type DataAwsNetworkmanagerGlobalNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerGlobalNetworkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerGlobalNetworkState<Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerGlobalNetworkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerGlobalNetworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_network#global_network_id-1">DataAwsNetworkmanagerGlobalNetwork#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerGlobalNetworkState<Missing>, value: string) : DataAwsNetworkmanagerGlobalNetworkState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerGlobalNetworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_network#id-1">DataAwsNetworkmanagerGlobalNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_global_network#tags-1">DataAwsNetworkmanagerGlobalNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerGlobalNetworkState<'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerGlobalNetworkState<Present>) : aws.DataAwsNetworkmanagerGlobalNetwork.DataAwsNetworkmanagerGlobalNetwork =
            let config = aws.DataAwsNetworkmanagerGlobalNetwork.DataAwsNetworkmanagerGlobalNetworkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerGlobalNetwork.DataAwsNetworkmanagerGlobalNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerGlobalNetwork: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerGlobalNetworkState<_>) : aws.DataAwsNetworkmanagerGlobalNetwork.DataAwsNetworkmanagerGlobalNetwork =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerGlobalNetwork.DataAwsNetworkmanagerGlobalNetwork>
