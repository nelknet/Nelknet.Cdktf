namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcPeeringConnectionsState = { assignments: ResizeArray<aws.DataAwsVpcPeeringConnections.DataAwsVpcPeeringConnectionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connections">aws_vpc_peering_connections</a>.
    /// </summary>
    type DataAwsVpcPeeringConnectionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcPeeringConnectionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcPeeringConnectionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connections#filter-1">DataAwsVpcPeeringConnections#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcPeeringConnections.DataAwsVpcPeeringConnectionsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcPeeringConnectionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcPeeringConnectionsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcPeeringConnectionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connections#id-1">DataAwsVpcPeeringConnections#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcPeeringConnectionsState, value: string) : DataAwsVpcPeeringConnectionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcPeeringConnectionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connections#tags-1">DataAwsVpcPeeringConnections#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcPeeringConnectionsState, value: seq<string * string>) : DataAwsVpcPeeringConnectionsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcPeeringConnectionsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connections#timeouts-1">DataAwsVpcPeeringConnections#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcPeeringConnectionsState, value: aws.DataAwsVpcPeeringConnections.DataAwsVpcPeeringConnectionsTimeouts) : DataAwsVpcPeeringConnectionsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcPeeringConnectionsState

        member _.Run(state: DataAwsVpcPeeringConnectionsState) : aws.DataAwsVpcPeeringConnections.DataAwsVpcPeeringConnections =
            let config = aws.DataAwsVpcPeeringConnections.DataAwsVpcPeeringConnectionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcPeeringConnections.DataAwsVpcPeeringConnections(StackContext.get (), logicalId, config)
