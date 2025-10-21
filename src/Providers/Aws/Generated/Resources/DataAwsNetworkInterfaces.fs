namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkInterfacesState = { assignments: ResizeArray<aws.DataAwsNetworkInterfaces.DataAwsNetworkInterfacesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces">aws_network_interfaces</a>.
    /// </summary>
    type DataAwsNetworkInterfacesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkInterfacesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNetworkInterfacesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#filter-1">DataAwsNetworkInterfaces#filter</a> Accepts: aws.IResolvable | aws.DataAwsNetworkInterfaces.DataAwsNetworkInterfacesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsNetworkInterfacesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkInterfacesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsNetworkInterfacesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#id-1">DataAwsNetworkInterfaces#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkInterfacesState, value: string) : DataAwsNetworkInterfacesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkInterfacesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#tags-1">DataAwsNetworkInterfaces#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkInterfacesState, value: seq<string * string>) : DataAwsNetworkInterfacesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkInterfacesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#timeouts-1">DataAwsNetworkInterfaces#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsNetworkInterfacesState, value: aws.DataAwsNetworkInterfaces.DataAwsNetworkInterfacesTimeouts) : DataAwsNetworkInterfacesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsNetworkInterfacesState

        member _.Run(state: DataAwsNetworkInterfacesState) : aws.DataAwsNetworkInterfaces.DataAwsNetworkInterfaces =
            let config = aws.DataAwsNetworkInterfaces.DataAwsNetworkInterfacesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkInterfaces.DataAwsNetworkInterfaces(StackContext.get (), logicalId, config)
