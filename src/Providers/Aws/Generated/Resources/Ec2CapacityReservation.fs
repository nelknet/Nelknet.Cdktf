namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> = { assignments: ResizeArray<aws.Ec2CapacityReservation.Ec2CapacityReservationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation">aws_ec2_capacity_reservation</a>.
    /// </summary>
    type Ec2CapacityReservationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2CapacityReservationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2CapacityReservationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Ec2CapacityReservationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2CapacityReservationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#availability_zone-1">Ec2CapacityReservation#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: Ec2CapacityReservationState<Missing, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<Present, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : Ec2CapacityReservationState<Present, 'InstanceCount, 'InstancePlatform, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#instance_count-1">Ec2CapacityReservation#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: Ec2CapacityReservationState<'AvailabilityZone, Missing, 'InstancePlatform, 'InstanceType>, value: double) : Ec2CapacityReservationState<'AvailabilityZone, Present, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            ({ assignments = state.assignments } : Ec2CapacityReservationState<'AvailabilityZone, Present, 'InstancePlatform, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#instance_platform-1">Ec2CapacityReservation#instance_platform</a>.
        /// </summary>
        [<CustomOperation "instance_platform">]
        member _.InstancePlatform(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, Missing, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, Present, 'InstanceType> =
            state.assignments.Add(fun config -> config.InstancePlatform <- value)
            ({ assignments = state.assignments } : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, Present, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#instance_type-1">Ec2CapacityReservation#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, Missing>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, Present> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#ebs_optimized-1">Ec2CapacityReservation#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: bool) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#ebs_optimized-1">Ec2CapacityReservation#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#end_date-1">Ec2CapacityReservation#end_date</a>.
        /// </summary>
        [<CustomOperation "end_date">]
        member _.EndDate(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.EndDate <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#end_date_type-1">Ec2CapacityReservation#end_date_type</a>.
        /// </summary>
        [<CustomOperation "end_date_type">]
        member _.EndDateType(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.EndDateType <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#ephemeral_storage-1">Ec2CapacityReservation#ephemeral_storage</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ephemeral_storage">]
        member _.EphemeralStorage(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: bool) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.EphemeralStorage <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#ephemeral_storage-1">Ec2CapacityReservation#ephemeral_storage</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ephemeral_storage">]
        member _.EphemeralStorage(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.EphemeralStorage <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#id-1">Ec2CapacityReservation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#instance_match_criteria-1">Ec2CapacityReservation#instance_match_criteria</a>.
        /// </summary>
        [<CustomOperation "instance_match_criteria">]
        member _.InstanceMatchCriteria(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.InstanceMatchCriteria <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#outpost_arn-1">Ec2CapacityReservation#outpost_arn</a>.
        /// </summary>
        [<CustomOperation "outpost_arn">]
        member _.OutpostArn(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.OutpostArn <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#placement_group_arn-1">Ec2CapacityReservation#placement_group_arn</a>.
        /// </summary>
        [<CustomOperation "placement_group_arn">]
        member _.PlacementGroupArn(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.PlacementGroupArn <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#tags-1">Ec2CapacityReservation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: seq<string * string>) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#tags_all-1">Ec2CapacityReservation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: seq<string * string>) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#tenancy-1">Ec2CapacityReservation#tenancy</a>.
        /// </summary>
        [<CustomOperation "tenancy">]
        member _.Tenancy(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: string) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.Tenancy <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_capacity_reservation#timeouts-1">Ec2CapacityReservation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>, value: aws.Ec2CapacityReservation.Ec2CapacityReservationTimeouts) : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2CapacityReservationState<'AvailabilityZone, 'InstanceCount, 'InstancePlatform, 'InstanceType>

        member _.Run(state: Ec2CapacityReservationState<Present, Present, Present, Present>) : aws.Ec2CapacityReservation.Ec2CapacityReservation =
            let config = aws.Ec2CapacityReservation.Ec2CapacityReservationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2CapacityReservation.Ec2CapacityReservation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2CapacityReservation: missing required arguments. Must call: availability_zone, instance_count, instance_platform, instance_type.", 9999, IsError = true)>]
        member _.Run(_: Ec2CapacityReservationState<_, _, _, _>) : aws.Ec2CapacityReservation.Ec2CapacityReservation =
            Unchecked.defaultof<aws.Ec2CapacityReservation.Ec2CapacityReservation>
