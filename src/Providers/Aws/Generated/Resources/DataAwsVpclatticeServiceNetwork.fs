namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier> = { assignments: ResizeArray<aws.DataAwsVpclatticeServiceNetwork.DataAwsVpclatticeServiceNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service_network">aws_vpclattice_service_network</a>.
    /// </summary>
    type DataAwsVpclatticeServiceNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpclatticeServiceNetworkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeServiceNetworkState<Missing>)

        member _.Zero(()) : DataAwsVpclatticeServiceNetworkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeServiceNetworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service_network#service_network_identifier-1">DataAwsVpclatticeServiceNetwork#service_network_identifier</a>.
        /// </summary>
        [<CustomOperation "service_network_identifier">]
        member _.ServiceNetworkIdentifier(state: DataAwsVpclatticeServiceNetworkState<Missing>, value: string) : DataAwsVpclatticeServiceNetworkState<Present> =
            state.assignments.Add(fun config -> config.ServiceNetworkIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsVpclatticeServiceNetworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service_network#id-1">DataAwsVpclatticeServiceNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier>, value: string) : DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service_network#tags-1">DataAwsVpclatticeServiceNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier>, value: seq<string * string>) : DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpclatticeServiceNetworkState<'ServiceNetworkIdentifier>

        member _.Run(state: DataAwsVpclatticeServiceNetworkState<Present>) : aws.DataAwsVpclatticeServiceNetwork.DataAwsVpclatticeServiceNetwork =
            let config = aws.DataAwsVpclatticeServiceNetwork.DataAwsVpclatticeServiceNetworkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpclatticeServiceNetwork.DataAwsVpclatticeServiceNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpclatticeServiceNetwork: missing required arguments. Must call: service_network_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpclatticeServiceNetworkState<_>) : aws.DataAwsVpclatticeServiceNetwork.DataAwsVpclatticeServiceNetwork =
            Unchecked.defaultof<aws.DataAwsVpclatticeServiceNetwork.DataAwsVpclatticeServiceNetwork>
