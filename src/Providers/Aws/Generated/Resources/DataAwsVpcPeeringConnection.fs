namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcPeeringConnectionState = { assignments: ResizeArray<aws.DataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection">aws_vpc_peering_connection</a>.
    /// </summary>
    type DataAwsVpcPeeringConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcPeeringConnectionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcPeeringConnectionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#cidr_block-1">DataAwsVpcPeeringConnection#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#filter-1">DataAwsVpcPeeringConnection#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcPeeringConnectionState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#id-1">DataAwsVpcPeeringConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#owner_id-1">DataAwsVpcPeeringConnection#owner_id</a>.
        /// </summary>
        [<CustomOperation "owner_id">]
        member _.OwnerId(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.OwnerId <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#peer_cidr_block-1">DataAwsVpcPeeringConnection#peer_cidr_block</a>.
        /// </summary>
        [<CustomOperation "peer_cidr_block">]
        member _.PeerCidrBlock(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.PeerCidrBlock <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#peer_owner_id-1">DataAwsVpcPeeringConnection#peer_owner_id</a>.
        /// </summary>
        [<CustomOperation "peer_owner_id">]
        member _.PeerOwnerId(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.PeerOwnerId <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#peer_region-1">DataAwsVpcPeeringConnection#peer_region</a>.
        /// </summary>
        [<CustomOperation "peer_region">]
        member _.PeerRegion(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.PeerRegion <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#peer_vpc_id-1">DataAwsVpcPeeringConnection#peer_vpc_id</a>.
        /// </summary>
        [<CustomOperation "peer_vpc_id">]
        member _.PeerVpcId(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.PeerVpcId <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#region-1">DataAwsVpcPeeringConnection#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#status-1">DataAwsVpcPeeringConnection#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#tags-1">DataAwsVpcPeeringConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcPeeringConnectionState, value: seq<string * string>) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#timeouts-1">DataAwsVpcPeeringConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcPeeringConnectionState, value: aws.DataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionTimeouts) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcPeeringConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#vpc_id-1">DataAwsVpcPeeringConnection#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsVpcPeeringConnectionState, value: string) : DataAwsVpcPeeringConnectionState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsVpcPeeringConnectionState

        member _.Run(state: DataAwsVpcPeeringConnectionState) : aws.DataAwsVpcPeeringConnection.DataAwsVpcPeeringConnection =
            let config = aws.DataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcPeeringConnection.DataAwsVpcPeeringConnection(StackContext.get (), logicalId, config)
