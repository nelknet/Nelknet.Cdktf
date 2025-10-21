namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AthenaCapacityReservationState<'Name, 'TargetDpus> = { assignments: ResizeArray<aws.AthenaCapacityReservation.AthenaCapacityReservationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_capacity_reservation">aws_athena_capacity_reservation</a>.
    /// </summary>
    type AthenaCapacityReservationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AthenaCapacityReservationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaCapacityReservationState<Missing, Missing>)

        member _.Zero(()) : AthenaCapacityReservationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaCapacityReservationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_capacity_reservation#name-1">AthenaCapacityReservation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AthenaCapacityReservationState<Missing, 'TargetDpus>, value: string) : AthenaCapacityReservationState<Present, 'TargetDpus> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AthenaCapacityReservationState<Present, 'TargetDpus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_capacity_reservation#target_dpus-1">AthenaCapacityReservation#target_dpus</a>.
        /// </summary>
        [<CustomOperation "target_dpus">]
        member _.TargetDpus(state: AthenaCapacityReservationState<'Name, Missing>, value: double) : AthenaCapacityReservationState<'Name, Present> =
            state.assignments.Add(fun config -> config.TargetDpus <- value)
            ({ assignments = state.assignments } : AthenaCapacityReservationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_capacity_reservation#tags-1">AthenaCapacityReservation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AthenaCapacityReservationState<'Name, 'TargetDpus>, value: seq<string * string>) : AthenaCapacityReservationState<'Name, 'TargetDpus> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AthenaCapacityReservationState<'Name, 'TargetDpus>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_capacity_reservation#timeouts-1">AthenaCapacityReservation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AthenaCapacityReservationState<'Name, 'TargetDpus>, value: aws.AthenaCapacityReservation.AthenaCapacityReservationTimeouts) : AthenaCapacityReservationState<'Name, 'TargetDpus> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AthenaCapacityReservationState<'Name, 'TargetDpus>

        member _.Run(state: AthenaCapacityReservationState<Present, Present>) : aws.AthenaCapacityReservation.AthenaCapacityReservation =
            let config = aws.AthenaCapacityReservation.AthenaCapacityReservationConfig()
            for setter in state.assignments do
                setter config
            aws.AthenaCapacityReservation.AthenaCapacityReservation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.athenaCapacityReservation: missing required arguments. Must call: name, target_dpus.", 9999, IsError = true)>]
        member _.Run(_: AthenaCapacityReservationState<_, _>) : aws.AthenaCapacityReservation.AthenaCapacityReservation =
            Unchecked.defaultof<aws.AthenaCapacityReservation.AthenaCapacityReservation>
