namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkInterfaceState = { assignments: ResizeArray<aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface">aws_network_interface</a>.
    /// </summary>
    type DataAwsNetworkInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkInterfaceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNetworkInterfaceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#filter-1">DataAwsNetworkInterface#filter</a> Accepts: aws.IResolvable | aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsNetworkInterfaceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkInterfaceState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsNetworkInterfaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#id-1">DataAwsNetworkInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkInterfaceState, value: string) : DataAwsNetworkInterfaceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkInterfaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#tags-1">DataAwsNetworkInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkInterfaceState, value: seq<string * string>) : DataAwsNetworkInterfaceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkInterfaceState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#timeouts-1">DataAwsNetworkInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsNetworkInterfaceState, value: aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceTimeouts) : DataAwsNetworkInterfaceState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsNetworkInterfaceState

        member _.Run(state: DataAwsNetworkInterfaceState) : aws.DataAwsNetworkInterface.DataAwsNetworkInterface =
            let config = aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkInterface.DataAwsNetworkInterface(StackContext.get (), logicalId, config)
