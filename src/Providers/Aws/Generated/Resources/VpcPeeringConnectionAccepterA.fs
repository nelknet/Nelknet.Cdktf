namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> = { assignments: ResizeArray<aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter">aws_vpc_peering_connection_accepter</a>.
    /// </summary>
    type VpcPeeringConnectionAccepterABuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcPeeringConnectionAccepterAState<Missing> =
            ({ assignments = ResizeArray() } : VpcPeeringConnectionAccepterAState<Missing>)

        member _.Zero(()) : VpcPeeringConnectionAccepterAState<Missing> =
            ({ assignments = ResizeArray() } : VpcPeeringConnectionAccepterAState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#vpc_peering_connection_id-1">VpcPeeringConnectionAccepterA#vpc_peering_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpc_peering_connection_id">]
        member _.VpcPeeringConnectionId(state: VpcPeeringConnectionAccepterAState<Missing>, value: string) : VpcPeeringConnectionAccepterAState<Present> =
            state.assignments.Add(fun config -> config.VpcPeeringConnectionId <- value)
            ({ assignments = state.assignments } : VpcPeeringConnectionAccepterAState<Present>)

        /// <summary>
        /// accepter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#accepter-1">VpcPeeringConnectionAccepterA#accepter</a>
        /// </summary>
        [<CustomOperation "accepter">]
        member _.Accepter(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAccepter) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Accepter <- value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#auto_accept-1">VpcPeeringConnectionAccepterA#auto_accept</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_accept">]
        member _.AutoAccept(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: bool) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.AutoAccept <- value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#auto_accept-1">VpcPeeringConnectionAccepterA#auto_accept</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_accept">]
        member _.AutoAccept(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: HashiCorp.Cdktf.IResolvable) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.AutoAccept <- value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#id-1">VpcPeeringConnectionAccepterA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: string) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// requester block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#requester-1">VpcPeeringConnectionAccepterA#requester</a>
        /// </summary>
        [<CustomOperation "requester">]
        member _.Requester(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequester) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Requester <- value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#tags-1">VpcPeeringConnectionAccepterA#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: seq<string * string>) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#tags_all-1">VpcPeeringConnectionAccepterA#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: seq<string * string>) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#timeouts-1">VpcPeeringConnectionAccepterA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>, value: aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterTimeouts) : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcPeeringConnectionAccepterAState<'VpcPeeringConnectionId>

        member _.Run(state: VpcPeeringConnectionAccepterAState<Present>) : aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA =
            let config = aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAConfig()
            for setter in state.assignments do
                setter config
            aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcPeeringConnectionAccepterA: missing required arguments. Must call: vpc_peering_connection_id.", 9999, IsError = true)>]
        member _.Run(_: VpcPeeringConnectionAccepterAState<_>) : aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA =
            Unchecked.defaultof<aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA>
