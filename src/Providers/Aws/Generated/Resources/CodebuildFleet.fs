namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> = { assignments: ResizeArray<aws.CodebuildFleet.CodebuildFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet">aws_codebuild_fleet</a>.
    /// </summary>
    type CodebuildFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodebuildFleetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildFleetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodebuildFleetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildFleetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#base_capacity-1">CodebuildFleet#base_capacity</a>.
        /// </summary>
        [<CustomOperation "base_capacity">]
        member _.BaseCapacity(state: CodebuildFleetState<Missing, 'ComputeType, 'EnvironmentType, 'Name>, value: double) : CodebuildFleetState<Present, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.BaseCapacity <- value)
            ({ assignments = state.assignments } : CodebuildFleetState<Present, 'ComputeType, 'EnvironmentType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#compute_type-1">CodebuildFleet#compute_type</a>.
        /// </summary>
        [<CustomOperation "compute_type">]
        member _.ComputeType(state: CodebuildFleetState<'BaseCapacity, Missing, 'EnvironmentType, 'Name>, value: string) : CodebuildFleetState<'BaseCapacity, Present, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.ComputeType <- value)
            ({ assignments = state.assignments } : CodebuildFleetState<'BaseCapacity, Present, 'EnvironmentType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#environment_type-1">CodebuildFleet#environment_type</a>.
        /// </summary>
        [<CustomOperation "environment_type">]
        member _.EnvironmentType(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, Missing, 'Name>, value: string) : CodebuildFleetState<'BaseCapacity, 'ComputeType, Present, 'Name> =
            state.assignments.Add(fun config -> config.EnvironmentType <- value)
            ({ assignments = state.assignments } : CodebuildFleetState<'BaseCapacity, 'ComputeType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#name-1">CodebuildFleet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, Missing>, value: string) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, Present>)

        /// <summary>
        /// compute_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#compute_configuration-1">CodebuildFleet#compute_configuration</a>
        /// </summary>
        [<CustomOperation "compute_configuration">]
        member _.ComputeConfiguration(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: aws.CodebuildFleet.CodebuildFleetComputeConfiguration) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.ComputeConfiguration <- value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#fleet_service_role-1">CodebuildFleet#fleet_service_role</a>.
        /// </summary>
        [<CustomOperation "fleet_service_role">]
        member _.FleetServiceRole(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: string) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.FleetServiceRole <- value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#image_id-1">CodebuildFleet#image_id</a>.
        /// </summary>
        [<CustomOperation "image_id">]
        member _.ImageId(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: string) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.ImageId <- value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#overflow_behavior-1">CodebuildFleet#overflow_behavior</a>.
        /// </summary>
        [<CustomOperation "overflow_behavior">]
        member _.OverflowBehavior(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: string) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.OverflowBehavior <- value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// scaling_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#scaling_configuration-1">CodebuildFleet#scaling_configuration</a>
        /// </summary>
        [<CustomOperation "scaling_configuration">]
        member _.ScalingConfiguration(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: aws.CodebuildFleet.CodebuildFleetScalingConfiguration) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.ScalingConfiguration <- value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#tags-1">CodebuildFleet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: seq<string * string>) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#tags_all-1">CodebuildFleet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: seq<string * string>) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#vpc_config-1">CodebuildFleet#vpc_config</a> Accepts: aws.IResolvable | aws.CodebuildFleet.CodebuildFleetVpcConfig[]
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : CodebuildFleetState<'BaseCapacity, 'ComputeType, 'EnvironmentType, 'Name>

        member _.Run(state: CodebuildFleetState<Present, Present, Present, Present>) : aws.CodebuildFleet.CodebuildFleet =
            let config = aws.CodebuildFleet.CodebuildFleetConfig()
            for setter in state.assignments do
                setter config
            aws.CodebuildFleet.CodebuildFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codebuildFleet: missing required arguments. Must call: base_capacity, compute_type, environment_type, name.", 9999, IsError = true)>]
        member _.Run(_: CodebuildFleetState<_, _, _, _>) : aws.CodebuildFleet.CodebuildFleet =
            Unchecked.defaultof<aws.CodebuildFleet.CodebuildFleet>
