namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> = { assignments: ResizeArray<aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer">aws_opsworks_ecs_cluster_layer</a>.
    /// </summary>
    type OpsworksEcsClusterLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksEcsClusterLayerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksEcsClusterLayerState<Missing, Missing>)

        member _.Zero(()) : OpsworksEcsClusterLayerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksEcsClusterLayerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#ecs_cluster_arn-1">OpsworksEcsClusterLayer#ecs_cluster_arn</a>.
        /// </summary>
        [<CustomOperation "ecs_cluster_arn">]
        member _.EcsClusterArn(state: OpsworksEcsClusterLayerState<Missing, 'StackId>, value: string) : OpsworksEcsClusterLayerState<Present, 'StackId> =
            state.assignments.Add(fun config -> config.EcsClusterArn <- value)
            ({ assignments = state.assignments } : OpsworksEcsClusterLayerState<Present, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#stack_id-1">OpsworksEcsClusterLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksEcsClusterLayerState<'EcsClusterArn, Missing>, value: string) : OpsworksEcsClusterLayerState<'EcsClusterArn, Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksEcsClusterLayerState<'EcsClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#auto_assign_elastic_ips-1">OpsworksEcsClusterLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: bool) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#auto_assign_elastic_ips-1">OpsworksEcsClusterLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#auto_assign_public_ips-1">OpsworksEcsClusterLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: bool) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#auto_assign_public_ips-1">OpsworksEcsClusterLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#auto_healing-1">OpsworksEcsClusterLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: bool) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#auto_healing-1">OpsworksEcsClusterLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#cloudwatch_configuration-1">OpsworksEcsClusterLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayerCloudwatchConfiguration) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_configure_recipes-1">OpsworksEcsClusterLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_deploy_recipes-1">OpsworksEcsClusterLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_instance_profile_arn-1">OpsworksEcsClusterLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: string) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_json-1">OpsworksEcsClusterLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: string) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_security_group_ids-1">OpsworksEcsClusterLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_setup_recipes-1">OpsworksEcsClusterLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_shutdown_recipes-1">OpsworksEcsClusterLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#custom_undeploy_recipes-1">OpsworksEcsClusterLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#drain_elb_on_shutdown-1">OpsworksEcsClusterLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: bool) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#drain_elb_on_shutdown-1">OpsworksEcsClusterLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#ebs_volume-1">OpsworksEcsClusterLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#elastic_load_balancer-1">OpsworksEcsClusterLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: string) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#id-1">OpsworksEcsClusterLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: string) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#install_updates_on_boot-1">OpsworksEcsClusterLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: bool) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#install_updates_on_boot-1">OpsworksEcsClusterLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#instance_shutdown_timeout-1">OpsworksEcsClusterLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: double) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#load_based_auto_scaling-1">OpsworksEcsClusterLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScaling) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#name-1">OpsworksEcsClusterLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: string) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#system_packages-1">OpsworksEcsClusterLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#tags-1">OpsworksEcsClusterLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string * string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#tags_all-1">OpsworksEcsClusterLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: seq<string * string>) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#use_ebs_optimized_instances-1">OpsworksEcsClusterLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: bool) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#use_ebs_optimized_instances-1">OpsworksEcsClusterLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksEcsClusterLayerState<'EcsClusterArn, 'StackId>

        member _.Run(state: OpsworksEcsClusterLayerState<Present, Present>) : aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayer =
            let config = aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksEcsClusterLayer: missing required arguments. Must call: ecs_cluster_arn, stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksEcsClusterLayerState<_, _>) : aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayer =
            Unchecked.defaultof<aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayer>
