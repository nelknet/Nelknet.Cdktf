namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId> = { assignments: ResizeArray<aws.Ec2SubnetCidrReservation.Ec2SubnetCidrReservationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_subnet_cidr_reservation">aws_ec2_subnet_cidr_reservation</a>.
    /// </summary>
    type Ec2SubnetCidrReservationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2SubnetCidrReservationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2SubnetCidrReservationState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2SubnetCidrReservationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2SubnetCidrReservationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_subnet_cidr_reservation#cidr_block-1">Ec2SubnetCidrReservation#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: Ec2SubnetCidrReservationState<Missing, 'ReservationType, 'SubnetId>, value: string) : Ec2SubnetCidrReservationState<Present, 'ReservationType, 'SubnetId> =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            ({ assignments = state.assignments } : Ec2SubnetCidrReservationState<Present, 'ReservationType, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_subnet_cidr_reservation#reservation_type-1">Ec2SubnetCidrReservation#reservation_type</a>.
        /// </summary>
        [<CustomOperation "reservation_type">]
        member _.ReservationType(state: Ec2SubnetCidrReservationState<'CidrBlock, Missing, 'SubnetId>, value: string) : Ec2SubnetCidrReservationState<'CidrBlock, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ReservationType <- value)
            ({ assignments = state.assignments } : Ec2SubnetCidrReservationState<'CidrBlock, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_subnet_cidr_reservation#subnet_id-1">Ec2SubnetCidrReservation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, Missing>, value: string) : Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_subnet_cidr_reservation#description-1">Ec2SubnetCidrReservation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId>, value: string) : Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_subnet_cidr_reservation#id-1">Ec2SubnetCidrReservation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId>, value: string) : Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2SubnetCidrReservationState<'CidrBlock, 'ReservationType, 'SubnetId>

        member _.Run(state: Ec2SubnetCidrReservationState<Present, Present, Present>) : aws.Ec2SubnetCidrReservation.Ec2SubnetCidrReservation =
            let config = aws.Ec2SubnetCidrReservation.Ec2SubnetCidrReservationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2SubnetCidrReservation.Ec2SubnetCidrReservation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2SubnetCidrReservation: missing required arguments. Must call: cidr_block, reservation_type, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2SubnetCidrReservationState<_, _, _>) : aws.Ec2SubnetCidrReservation.Ec2SubnetCidrReservation =
            Unchecked.defaultof<aws.Ec2SubnetCidrReservation.Ec2SubnetCidrReservation>
