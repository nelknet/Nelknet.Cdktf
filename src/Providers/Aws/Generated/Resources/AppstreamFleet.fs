namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> = { assignments: ResizeArray<aws.AppstreamFleet.AppstreamFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet">aws_appstream_fleet</a>.
    /// </summary>
    type AppstreamFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamFleetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamFleetState<Missing, Missing, Missing>)

        member _.Zero(()) : AppstreamFleetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamFleetState<Missing, Missing, Missing>)

        /// <summary>
        /// compute_capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#compute_capacity-1">AppstreamFleet#compute_capacity</a>
        /// </summary>
        [<CustomOperation "compute_capacity">]
        member _.ComputeCapacity(state: AppstreamFleetState<Missing, 'InstanceType, 'Name>, value: aws.AppstreamFleet.AppstreamFleetComputeCapacity) : AppstreamFleetState<Present, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ComputeCapacity <- value)
            ({ assignments = state.assignments } : AppstreamFleetState<Present, 'InstanceType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#instance_type-1">AppstreamFleet#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: AppstreamFleetState<'ComputeCapacity, Missing, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : AppstreamFleetState<'ComputeCapacity, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#name-1">AppstreamFleet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, Missing>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppstreamFleetState<'ComputeCapacity, 'InstanceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#description-1">AppstreamFleet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#disconnect_timeout_in_seconds-1">AppstreamFleet#disconnect_timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "disconnect_timeout_in_seconds">]
        member _.DisconnectTimeoutInSeconds(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: double) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.DisconnectTimeoutInSeconds <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#display_name-1">AppstreamFleet#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// domain_join_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#domain_join_info-1">AppstreamFleet#domain_join_info</a>
        /// </summary>
        [<CustomOperation "domain_join_info">]
        member _.DomainJoinInfo(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: aws.AppstreamFleet.AppstreamFleetDomainJoinInfo) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.DomainJoinInfo <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#enable_default_internet_access-1">AppstreamFleet#enable_default_internet_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_default_internet_access">]
        member _.EnableDefaultInternetAccess(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: bool) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.EnableDefaultInternetAccess <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#enable_default_internet_access-1">AppstreamFleet#enable_default_internet_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_default_internet_access">]
        member _.EnableDefaultInternetAccess(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.EnableDefaultInternetAccess <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#fleet_type-1">AppstreamFleet#fleet_type</a>.
        /// </summary>
        [<CustomOperation "fleet_type">]
        member _.FleetType(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.FleetType <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#iam_role_arn-1">AppstreamFleet#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#id-1">AppstreamFleet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#idle_disconnect_timeout_in_seconds-1">AppstreamFleet#idle_disconnect_timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "idle_disconnect_timeout_in_seconds">]
        member _.IdleDisconnectTimeoutInSeconds(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: double) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.IdleDisconnectTimeoutInSeconds <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#image_arn-1">AppstreamFleet#image_arn</a>.
        /// </summary>
        [<CustomOperation "image_arn">]
        member _.ImageArn(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ImageArn <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#image_name-1">AppstreamFleet#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#max_sessions_per_instance-1">AppstreamFleet#max_sessions_per_instance</a>.
        /// </summary>
        [<CustomOperation "max_sessions_per_instance">]
        member _.MaxSessionsPerInstance(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: double) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.MaxSessionsPerInstance <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#max_user_duration_in_seconds-1">AppstreamFleet#max_user_duration_in_seconds</a>.
        /// </summary>
        [<CustomOperation "max_user_duration_in_seconds">]
        member _.MaxUserDurationInSeconds(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: double) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.MaxUserDurationInSeconds <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#stream_view-1">AppstreamFleet#stream_view</a>.
        /// </summary>
        [<CustomOperation "stream_view">]
        member _.StreamView(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: string) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.StreamView <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#tags-1">AppstreamFleet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: seq<string * string>) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#tags_all-1">AppstreamFleet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: seq<string * string>) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#vpc_config-1">AppstreamFleet#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>, value: aws.AppstreamFleet.AppstreamFleetVpcConfig) : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : AppstreamFleetState<'ComputeCapacity, 'InstanceType, 'Name>

        member _.Run(state: AppstreamFleetState<Present, Present, Present>) : aws.AppstreamFleet.AppstreamFleet =
            let config = aws.AppstreamFleet.AppstreamFleetConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamFleet.AppstreamFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamFleet: missing required arguments. Must call: compute_capacity, instance_type, name.", 9999, IsError = true)>]
        member _.Run(_: AppstreamFleetState<_, _, _>) : aws.AppstreamFleet.AppstreamFleet =
            Unchecked.defaultof<aws.AppstreamFleet.AppstreamFleet>
