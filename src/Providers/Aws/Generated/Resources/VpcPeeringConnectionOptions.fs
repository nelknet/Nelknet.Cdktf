namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId> = { assignments: ResizeArray<aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options">aws_vpc_peering_connection_options</a>.
    /// </summary>
    type VpcPeeringConnectionOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcPeeringConnectionOptionsState<Missing> =
            ({ assignments = ResizeArray() } : VpcPeeringConnectionOptionsState<Missing>)

        member _.Zero(()) : VpcPeeringConnectionOptionsState<Missing> =
            ({ assignments = ResizeArray() } : VpcPeeringConnectionOptionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options#vpc_peering_connection_id-1">VpcPeeringConnectionOptions#vpc_peering_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpc_peering_connection_id">]
        member _.VpcPeeringConnectionId(state: VpcPeeringConnectionOptionsState<Missing>, value: string) : VpcPeeringConnectionOptionsState<Present> =
            state.assignments.Add(fun config -> config.VpcPeeringConnectionId <- value)
            ({ assignments = state.assignments } : VpcPeeringConnectionOptionsState<Present>)

        /// <summary>
        /// accepter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options#accepter-1">VpcPeeringConnectionOptions#accepter</a>
        /// </summary>
        [<CustomOperation "accepter">]
        member _.Accepter(state: VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId>, value: aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsAccepter) : VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Accepter <- value)
            state : VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options#id-1">VpcPeeringConnectionOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId>, value: string) : VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId>

        /// <summary>
        /// requester block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options#requester-1">VpcPeeringConnectionOptions#requester</a>
        /// </summary>
        [<CustomOperation "requester">]
        member _.Requester(state: VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId>, value: aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequester) : VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId> =
            state.assignments.Add(fun config -> config.Requester <- value)
            state : VpcPeeringConnectionOptionsState<'VpcPeeringConnectionId>

        member _.Run(state: VpcPeeringConnectionOptionsState<Present>) : aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions =
            let config = aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcPeeringConnectionOptions: missing required arguments. Must call: vpc_peering_connection_id.", 9999, IsError = true)>]
        member _.Run(_: VpcPeeringConnectionOptionsState<_>) : aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions =
            Unchecked.defaultof<aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions>
