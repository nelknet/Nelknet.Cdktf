namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> = { assignments: ResizeArray<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group">aws_codedeploy_deployment_group</a>.
    /// </summary>
    type CodedeployDeploymentGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodedeployDeploymentGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodedeployDeploymentGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : CodedeployDeploymentGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodedeployDeploymentGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#app_name-1">CodedeployDeploymentGroup#app_name</a>.
        /// </summary>
        [<CustomOperation "app_name">]
        member _.AppName(state: CodedeployDeploymentGroupState<Missing, 'DeploymentGroupName, 'ServiceRoleArn>, value: string) : CodedeployDeploymentGroupState<Present, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.AppName <- value)
            ({ assignments = state.assignments } : CodedeployDeploymentGroupState<Present, 'DeploymentGroupName, 'ServiceRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#deployment_group_name-1">CodedeployDeploymentGroup#deployment_group_name</a>.
        /// </summary>
        [<CustomOperation "deployment_group_name">]
        member _.DeploymentGroupName(state: CodedeployDeploymentGroupState<'AppName, Missing, 'ServiceRoleArn>, value: string) : CodedeployDeploymentGroupState<'AppName, Present, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DeploymentGroupName <- value)
            ({ assignments = state.assignments } : CodedeployDeploymentGroupState<'AppName, Present, 'ServiceRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#service_role_arn-1">CodedeployDeploymentGroup#service_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_role_arn">]
        member _.ServiceRoleArn(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, Missing>, value: string) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceRoleArn <- value)
            ({ assignments = state.assignments } : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, Present>)

        /// <summary>
        /// alarm_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#alarm_configuration-1">CodedeployDeploymentGroup#alarm_configuration</a>
        /// </summary>
        [<CustomOperation "alarm_configuration">]
        member _.AlarmConfiguration(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfiguration) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.AlarmConfiguration <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// auto_rollback_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#auto_rollback_configuration-1">CodedeployDeploymentGroup#auto_rollback_configuration</a>
        /// </summary>
        [<CustomOperation "auto_rollback_configuration">]
        member _.AutoRollbackConfiguration(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfiguration) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.AutoRollbackConfiguration <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#autoscaling_groups-1">CodedeployDeploymentGroup#autoscaling_groups</a>.
        /// </summary>
        [<CustomOperation "autoscaling_groups">]
        member _.AutoscalingGroups(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: seq<string>) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.AutoscalingGroups <- (value |> Seq.toArray))
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// blue_green_deployment_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#blue_green_deployment_config-1">CodedeployDeploymentGroup#blue_green_deployment_config</a>
        /// </summary>
        [<CustomOperation "blue_green_deployment_config">]
        member _.BlueGreenDeploymentConfig(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfig) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.BlueGreenDeploymentConfig <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#deployment_config_name-1">CodedeployDeploymentGroup#deployment_config_name</a>.
        /// </summary>
        [<CustomOperation "deployment_config_name">]
        member _.DeploymentConfigName(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: string) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DeploymentConfigName <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// deployment_style block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#deployment_style-1">CodedeployDeploymentGroup#deployment_style</a>
        /// </summary>
        [<CustomOperation "deployment_style">]
        member _.DeploymentStyle(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyle) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DeploymentStyle <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// ec2_tag_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#ec2_tag_filter-1">CodedeployDeploymentGroup#ec2_tag_filter</a> Accepts: aws.IResolvable | aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilter[]
        /// </summary>
        [<CustomOperation "ec2_tag_filter">]
        member _.Ec2TagFilter(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Ec2TagFilter <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// ec2_tag_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#ec2_tag_set-1">CodedeployDeploymentGroup#ec2_tag_set</a> Accepts: aws.IResolvable | aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSet[]
        /// </summary>
        [<CustomOperation "ec2_tag_set">]
        member _.Ec2TagSet(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Ec2TagSet <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// ecs_service block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#ecs_service-1">CodedeployDeploymentGroup#ecs_service</a>
        /// </summary>
        [<CustomOperation "ecs_service">]
        member _.EcsService(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEcsService) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.EcsService <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#id-1">CodedeployDeploymentGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: string) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// load_balancer_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#load_balancer_info-1">CodedeployDeploymentGroup#load_balancer_info</a>
        /// </summary>
        [<CustomOperation "load_balancer_info">]
        member _.LoadBalancerInfo(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfo) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.LoadBalancerInfo <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// on_premises_instance_tag_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#on_premises_instance_tag_filter-1">CodedeployDeploymentGroup#on_premises_instance_tag_filter</a> Accepts: aws.IResolvable | aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilter[]
        /// </summary>
        [<CustomOperation "on_premises_instance_tag_filter">]
        member _.OnPremisesInstanceTagFilter(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.OnPremisesInstanceTagFilter <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#outdated_instances_strategy-1">CodedeployDeploymentGroup#outdated_instances_strategy</a>.
        /// </summary>
        [<CustomOperation "outdated_instances_strategy">]
        member _.OutdatedInstancesStrategy(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: string) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.OutdatedInstancesStrategy <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#tags-1">CodedeployDeploymentGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: seq<string * string>) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#tags_all-1">CodedeployDeploymentGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: seq<string * string>) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#termination_hook_enabled-1">CodedeployDeploymentGroup#termination_hook_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_hook_enabled">]
        member _.TerminationHookEnabled(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: bool) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.TerminationHookEnabled <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#termination_hook_enabled-1">CodedeployDeploymentGroup#termination_hook_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_hook_enabled">]
        member _.TerminationHookEnabled(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.TerminationHookEnabled <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        /// <summary>
        /// trigger_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#trigger_configuration-1">CodedeployDeploymentGroup#trigger_configuration</a> Accepts: aws.IResolvable | aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfiguration[]
        /// </summary>
        [<CustomOperation "trigger_configuration">]
        member _.TriggerConfiguration(state: CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.TriggerConfiguration <- value)
            state : CodedeployDeploymentGroupState<'AppName, 'DeploymentGroupName, 'ServiceRoleArn>

        member _.Run(state: CodedeployDeploymentGroupState<Present, Present, Present>) : aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup =
            let config = aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codedeployDeploymentGroup: missing required arguments. Must call: app_name, deployment_group_name, service_role_arn.", 9999, IsError = true)>]
        member _.Run(_: CodedeployDeploymentGroupState<_, _, _>) : aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup =
            Unchecked.defaultof<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup>
