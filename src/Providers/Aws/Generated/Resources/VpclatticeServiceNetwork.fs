namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeServiceNetworkState<'Name> = { assignments: ResizeArray<aws.VpclatticeServiceNetwork.VpclatticeServiceNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network">aws_vpclattice_service_network</a>.
    /// </summary>
    type VpclatticeServiceNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeServiceNetworkState<Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkState<Missing>)

        member _.Zero(()) : VpclatticeServiceNetworkState<Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network#name-1">VpclatticeServiceNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeServiceNetworkState<Missing>, value: string) : VpclatticeServiceNetworkState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network#auth_type-1">VpclatticeServiceNetwork#auth_type</a>.
        /// </summary>
        [<CustomOperation "auth_type">]
        member _.AuthType(state: VpclatticeServiceNetworkState<'Name>, value: string) : VpclatticeServiceNetworkState<'Name> =
            state.assignments.Add(fun config -> config.AuthType <- value)
            state : VpclatticeServiceNetworkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network#id-1">VpclatticeServiceNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeServiceNetworkState<'Name>, value: string) : VpclatticeServiceNetworkState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeServiceNetworkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network#tags-1">VpclatticeServiceNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeServiceNetworkState<'Name>, value: seq<string * string>) : VpclatticeServiceNetworkState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeServiceNetworkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network#tags_all-1">VpclatticeServiceNetwork#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeServiceNetworkState<'Name>, value: seq<string * string>) : VpclatticeServiceNetworkState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeServiceNetworkState<'Name>

        member _.Run(state: VpclatticeServiceNetworkState<Present>) : aws.VpclatticeServiceNetwork.VpclatticeServiceNetwork =
            let config = aws.VpclatticeServiceNetwork.VpclatticeServiceNetworkConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeServiceNetwork.VpclatticeServiceNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeServiceNetwork: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeServiceNetworkState<_>) : aws.VpclatticeServiceNetwork.VpclatticeServiceNetwork =
            Unchecked.defaultof<aws.VpclatticeServiceNetwork.VpclatticeServiceNetwork>
