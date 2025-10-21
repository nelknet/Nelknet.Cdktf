namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> = { assignments: ResizeArray<aws.GameliftGameServerGroup.GameliftGameServerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group">aws_gamelift_game_server_group</a>.
    /// </summary>
    type GameliftGameServerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : GameliftGameServerGroupState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftGameServerGroupState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GameliftGameServerGroupState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftGameServerGroupState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#game_server_group_name-1">GameliftGameServerGroup#game_server_group_name</a>.
        /// </summary>
        [<CustomOperation "game_server_group_name">]
        member _.GameServerGroupName(state: GameliftGameServerGroupState<Missing, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: string) : GameliftGameServerGroupState<Present, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.GameServerGroupName <- value)
            ({ assignments = state.assignments } : GameliftGameServerGroupState<Present, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>)

        /// <summary>
        /// instance_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#instance_definition-1">GameliftGameServerGroup#instance_definition</a> Accepts: aws.IResolvable | aws.GameliftGameServerGroup.GameliftGameServerGroupInstanceDefinition[]
        /// </summary>
        [<CustomOperation "instance_definition">]
        member _.InstanceDefinition(state: GameliftGameServerGroupState<'GameServerGroupName, Missing, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : GameliftGameServerGroupState<'GameServerGroupName, Present, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.InstanceDefinition <- value)
            ({ assignments = state.assignments } : GameliftGameServerGroupState<'GameServerGroupName, Present, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>)

        /// <summary>
        /// launch_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#launch_template-1">GameliftGameServerGroup#launch_template</a>
        /// </summary>
        [<CustomOperation "launch_template">]
        member _.LaunchTemplate(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, Missing, 'MaxSize, 'MinSize, 'RoleArn>, value: aws.GameliftGameServerGroup.GameliftGameServerGroupLaunchTemplate) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, Present, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.LaunchTemplate <- value)
            ({ assignments = state.assignments } : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, Present, 'MaxSize, 'MinSize, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#max_size-1">GameliftGameServerGroup#max_size</a>.
        /// </summary>
        [<CustomOperation "max_size">]
        member _.MaxSize(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, Missing, 'MinSize, 'RoleArn>, value: double) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, Present, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.MaxSize <- value)
            ({ assignments = state.assignments } : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, Present, 'MinSize, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#min_size-1">GameliftGameServerGroup#min_size</a>.
        /// </summary>
        [<CustomOperation "min_size">]
        member _.MinSize(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, Missing, 'RoleArn>, value: double) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.MinSize <- value)
            ({ assignments = state.assignments } : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#role_arn-1">GameliftGameServerGroup#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, Missing>, value: string) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, Present>)

        /// <summary>
        /// auto_scaling_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#auto_scaling_policy-1">GameliftGameServerGroup#auto_scaling_policy</a>
        /// </summary>
        [<CustomOperation "auto_scaling_policy">]
        member _.AutoScalingPolicy(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: aws.GameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicy) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.AutoScalingPolicy <- value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#balancing_strategy-1">GameliftGameServerGroup#balancing_strategy</a>.
        /// </summary>
        [<CustomOperation "balancing_strategy">]
        member _.BalancingStrategy(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: string) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.BalancingStrategy <- value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#game_server_protection_policy-1">GameliftGameServerGroup#game_server_protection_policy</a>.
        /// </summary>
        [<CustomOperation "game_server_protection_policy">]
        member _.GameServerProtectionPolicy(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: string) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.GameServerProtectionPolicy <- value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#id-1">GameliftGameServerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: string) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#tags-1">GameliftGameServerGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: seq<string * string>) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#tags_all-1">GameliftGameServerGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: seq<string * string>) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#timeouts-1">GameliftGameServerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: aws.GameliftGameServerGroup.GameliftGameServerGroupTimeouts) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#vpc_subnets-1">GameliftGameServerGroup#vpc_subnets</a>.
        /// </summary>
        [<CustomOperation "vpc_subnets">]
        member _.VpcSubnets(state: GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>, value: seq<string>) : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn> =
            state.assignments.Add(fun config -> config.VpcSubnets <- (value |> Seq.toArray))
            state : GameliftGameServerGroupState<'GameServerGroupName, 'InstanceDefinition, 'LaunchTemplate, 'MaxSize, 'MinSize, 'RoleArn>

        member _.Run(state: GameliftGameServerGroupState<Present, Present, Present, Present, Present, Present>) : aws.GameliftGameServerGroup.GameliftGameServerGroup =
            let config = aws.GameliftGameServerGroup.GameliftGameServerGroupConfig()
            for setter in state.assignments do
                setter config
            aws.GameliftGameServerGroup.GameliftGameServerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gameliftGameServerGroup: missing required arguments. Must call: game_server_group_name, instance_definition, launch_template, max_size, min_size, role_arn.", 9999, IsError = true)>]
        member _.Run(_: GameliftGameServerGroupState<_, _, _, _, _, _>) : aws.GameliftGameServerGroup.GameliftGameServerGroup =
            Unchecked.defaultof<aws.GameliftGameServerGroup.GameliftGameServerGroup>
