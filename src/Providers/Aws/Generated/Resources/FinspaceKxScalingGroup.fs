namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name> = { assignments: ResizeArray<aws.FinspaceKxScalingGroup.FinspaceKxScalingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group">aws_finspace_kx_scaling_group</a>.
    /// </summary>
    type FinspaceKxScalingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxScalingGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxScalingGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FinspaceKxScalingGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxScalingGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#availability_zone_id-1">FinspaceKxScalingGroup#availability_zone_id</a>.
        /// </summary>
        [<CustomOperation "availability_zone_id">]
        member _.AvailabilityZoneId(state: FinspaceKxScalingGroupState<Missing, 'EnvironmentId, 'HostType, 'Name>, value: string) : FinspaceKxScalingGroupState<Present, 'EnvironmentId, 'HostType, 'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZoneId <- value)
            ({ assignments = state.assignments } : FinspaceKxScalingGroupState<Present, 'EnvironmentId, 'HostType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#environment_id-1">FinspaceKxScalingGroup#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, Missing, 'HostType, 'Name>, value: string) : FinspaceKxScalingGroupState<'AvailabilityZoneId, Present, 'HostType, 'Name> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : FinspaceKxScalingGroupState<'AvailabilityZoneId, Present, 'HostType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#host_type-1">FinspaceKxScalingGroup#host_type</a>.
        /// </summary>
        [<CustomOperation "host_type">]
        member _.HostType(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, Missing, 'Name>, value: string) : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, Present, 'Name> =
            state.assignments.Add(fun config -> config.HostType <- value)
            ({ assignments = state.assignments } : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#name-1">FinspaceKxScalingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, Missing>, value: string) : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#id-1">FinspaceKxScalingGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>, value: string) : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#tags-1">FinspaceKxScalingGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>, value: seq<string * string>) : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#tags_all-1">FinspaceKxScalingGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>, value: seq<string * string>) : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_scaling_group#timeouts-1">FinspaceKxScalingGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>, value: aws.FinspaceKxScalingGroup.FinspaceKxScalingGroupTimeouts) : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxScalingGroupState<'AvailabilityZoneId, 'EnvironmentId, 'HostType, 'Name>

        member _.Run(state: FinspaceKxScalingGroupState<Present, Present, Present, Present>) : aws.FinspaceKxScalingGroup.FinspaceKxScalingGroup =
            let config = aws.FinspaceKxScalingGroup.FinspaceKxScalingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxScalingGroup.FinspaceKxScalingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxScalingGroup: missing required arguments. Must call: availability_zone_id, environment_id, host_type, name.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxScalingGroupState<_, _, _, _>) : aws.FinspaceKxScalingGroup.FinspaceKxScalingGroup =
            Unchecked.defaultof<aws.FinspaceKxScalingGroup.FinspaceKxScalingGroup>
