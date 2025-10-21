namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform> = { assignments: ResizeArray<aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_block_reservation">aws_ec2_capacity_block_reservation</a>.
    /// </summary>
    type Ec2CapacityBlockReservationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2CapacityBlockReservationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2CapacityBlockReservationState<Missing, Missing>)

        member _.Zero(()) : Ec2CapacityBlockReservationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2CapacityBlockReservationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_block_reservation#capacity_block_offering_id-1">Ec2CapacityBlockReservation#capacity_block_offering_id</a>.
        /// </summary>
        [<CustomOperation "capacity_block_offering_id">]
        member _.CapacityBlockOfferingId(state: Ec2CapacityBlockReservationState<Missing, 'InstancePlatform>, value: string) : Ec2CapacityBlockReservationState<Present, 'InstancePlatform> =
            state.assignments.Add(fun config -> config.CapacityBlockOfferingId <- value)
            ({ assignments = state.assignments } : Ec2CapacityBlockReservationState<Present, 'InstancePlatform>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_block_reservation#instance_platform-1">Ec2CapacityBlockReservation#instance_platform</a>.
        /// </summary>
        [<CustomOperation "instance_platform">]
        member _.InstancePlatform(state: Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, Missing>, value: string) : Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, Present> =
            state.assignments.Add(fun config -> config.InstancePlatform <- value)
            ({ assignments = state.assignments } : Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_block_reservation#tags-1">Ec2CapacityBlockReservation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform>, value: seq<string * string>) : Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_block_reservation#timeouts-1">Ec2CapacityBlockReservation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform>, value: aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservationTimeouts) : Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2CapacityBlockReservationState<'CapacityBlockOfferingId, 'InstancePlatform>

        member _.Run(state: Ec2CapacityBlockReservationState<Present, Present>) : aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservation =
            let config = aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2CapacityBlockReservation: missing required arguments. Must call: capacity_block_offering_id, instance_platform.", 9999, IsError = true)>]
        member _.Run(_: Ec2CapacityBlockReservationState<_, _>) : aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservation =
            Unchecked.defaultof<aws.Ec2CapacityBlockReservation.Ec2CapacityBlockReservation>
