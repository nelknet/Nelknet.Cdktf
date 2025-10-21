namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType> = { assignments: ResizeArray<aws.DataAwsEc2CapacityBlockOffering.DataAwsEc2CapacityBlockOfferingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_capacity_block_offering">aws_ec2_capacity_block_offering</a>.
    /// </summary>
    type DataAwsEc2CapacityBlockOfferingBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2CapacityBlockOfferingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2CapacityBlockOfferingState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsEc2CapacityBlockOfferingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2CapacityBlockOfferingState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_capacity_block_offering#capacity_duration_hours-1">DataAwsEc2CapacityBlockOffering#capacity_duration_hours</a>.
        /// </summary>
        [<CustomOperation "capacity_duration_hours">]
        member _.CapacityDurationHours(state: DataAwsEc2CapacityBlockOfferingState<Missing, 'InstanceCount, 'InstanceType>, value: double) : DataAwsEc2CapacityBlockOfferingState<Present, 'InstanceCount, 'InstanceType> =
            state.assignments.Add(fun config -> config.CapacityDurationHours <- value)
            ({ assignments = state.assignments } : DataAwsEc2CapacityBlockOfferingState<Present, 'InstanceCount, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_capacity_block_offering#instance_count-1">DataAwsEc2CapacityBlockOffering#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, Missing, 'InstanceType>, value: double) : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, Present, 'InstanceType> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            ({ assignments = state.assignments } : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, Present, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_capacity_block_offering#instance_type-1">DataAwsEc2CapacityBlockOffering#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, Missing>, value: string) : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, Present> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_capacity_block_offering#end_date_range-1">DataAwsEc2CapacityBlockOffering#end_date_range</a>.
        /// </summary>
        [<CustomOperation "end_date_range">]
        member _.EndDateRange(state: DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType>, value: string) : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType> =
            state.assignments.Add(fun config -> config.EndDateRange <- value)
            state : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_capacity_block_offering#start_date_range-1">DataAwsEc2CapacityBlockOffering#start_date_range</a>.
        /// </summary>
        [<CustomOperation "start_date_range">]
        member _.StartDateRange(state: DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType>, value: string) : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType> =
            state.assignments.Add(fun config -> config.StartDateRange <- value)
            state : DataAwsEc2CapacityBlockOfferingState<'CapacityDurationHours, 'InstanceCount, 'InstanceType>

        member _.Run(state: DataAwsEc2CapacityBlockOfferingState<Present, Present, Present>) : aws.DataAwsEc2CapacityBlockOffering.DataAwsEc2CapacityBlockOffering =
            let config = aws.DataAwsEc2CapacityBlockOffering.DataAwsEc2CapacityBlockOfferingConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2CapacityBlockOffering.DataAwsEc2CapacityBlockOffering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEc2CapacityBlockOffering: missing required arguments. Must call: capacity_duration_hours, instance_count, instance_type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEc2CapacityBlockOfferingState<_, _, _>) : aws.DataAwsEc2CapacityBlockOffering.DataAwsEc2CapacityBlockOffering =
            Unchecked.defaultof<aws.DataAwsEc2CapacityBlockOffering.DataAwsEc2CapacityBlockOffering>
