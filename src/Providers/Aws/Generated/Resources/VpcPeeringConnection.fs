namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcPeeringConnectionState<'PeerVpcId, 'VpcId> = { assignments: ResizeArray<aws.VpcPeeringConnection.VpcPeeringConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection">aws_vpc_peering_connection</a>.
    /// </summary>
    type VpcPeeringConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcPeeringConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcPeeringConnectionState<Missing, Missing>)

        member _.Zero(()) : VpcPeeringConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcPeeringConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#peer_vpc_id-1">VpcPeeringConnection#peer_vpc_id</a>.
        /// </summary>
        [<CustomOperation "peer_vpc_id">]
        member _.PeerVpcId(state: VpcPeeringConnectionState<Missing, 'VpcId>, value: string) : VpcPeeringConnectionState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.PeerVpcId <- value)
            ({ assignments = state.assignments } : VpcPeeringConnectionState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#vpc_id-1">VpcPeeringConnection#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcPeeringConnectionState<'PeerVpcId, Missing>, value: string) : VpcPeeringConnectionState<'PeerVpcId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcPeeringConnectionState<'PeerVpcId, Present>)

        /// <summary>
        /// accepter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#accepter-1">VpcPeeringConnection#accepter</a>
        /// </summary>
        [<CustomOperation "accepter">]
        member _.Accepter(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: aws.VpcPeeringConnection.VpcPeeringConnectionAccepter) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.Accepter <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#auto_accept-1">VpcPeeringConnection#auto_accept</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_accept">]
        member _.AutoAccept(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: bool) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.AutoAccept <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#auto_accept-1">VpcPeeringConnection#auto_accept</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_accept">]
        member _.AutoAccept(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.AutoAccept <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#id-1">VpcPeeringConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: string) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#peer_owner_id-1">VpcPeeringConnection#peer_owner_id</a>.
        /// </summary>
        [<CustomOperation "peer_owner_id">]
        member _.PeerOwnerId(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: string) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.PeerOwnerId <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#peer_region-1">VpcPeeringConnection#peer_region</a>.
        /// </summary>
        [<CustomOperation "peer_region">]
        member _.PeerRegion(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: string) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.PeerRegion <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// requester block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#requester-1">VpcPeeringConnection#requester</a>
        /// </summary>
        [<CustomOperation "requester">]
        member _.Requester(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: aws.VpcPeeringConnection.VpcPeeringConnectionRequester) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.Requester <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#tags-1">VpcPeeringConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: seq<string * string>) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#tags_all-1">VpcPeeringConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: seq<string * string>) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection#timeouts-1">VpcPeeringConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcPeeringConnectionState<'PeerVpcId, 'VpcId>, value: aws.VpcPeeringConnection.VpcPeeringConnectionTimeouts) : VpcPeeringConnectionState<'PeerVpcId, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcPeeringConnectionState<'PeerVpcId, 'VpcId>

        member _.Run(state: VpcPeeringConnectionState<Present, Present>) : aws.VpcPeeringConnection.VpcPeeringConnection =
            let config = aws.VpcPeeringConnection.VpcPeeringConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.VpcPeeringConnection.VpcPeeringConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcPeeringConnection: missing required arguments. Must call: peer_vpc_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcPeeringConnectionState<_, _>) : aws.VpcPeeringConnection.VpcPeeringConnection =
            Unchecked.defaultof<aws.VpcPeeringConnection.VpcPeeringConnection>
