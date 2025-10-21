namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> = { assignments: ResizeArray<aws.OpsworksCustomLayer.OpsworksCustomLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer">aws_opsworks_custom_layer</a>.
    /// </summary>
    type OpsworksCustomLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksCustomLayerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksCustomLayerState<Missing, Missing, Missing>)

        member _.Zero(()) : OpsworksCustomLayerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksCustomLayerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#name-1">OpsworksCustomLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksCustomLayerState<Missing, 'ShortName, 'StackId>, value: string) : OpsworksCustomLayerState<Present, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpsworksCustomLayerState<Present, 'ShortName, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#short_name-1">OpsworksCustomLayer#short_name</a>.
        /// </summary>
        [<CustomOperation "short_name">]
        member _.ShortName(state: OpsworksCustomLayerState<'Name, Missing, 'StackId>, value: string) : OpsworksCustomLayerState<'Name, Present, 'StackId> =
            state.assignments.Add(fun config -> config.ShortName <- value)
            ({ assignments = state.assignments } : OpsworksCustomLayerState<'Name, Present, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#stack_id-1">OpsworksCustomLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksCustomLayerState<'Name, 'ShortName, Missing>, value: string) : OpsworksCustomLayerState<'Name, 'ShortName, Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksCustomLayerState<'Name, 'ShortName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#auto_assign_elastic_ips-1">OpsworksCustomLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: bool) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#auto_assign_elastic_ips-1">OpsworksCustomLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#auto_assign_public_ips-1">OpsworksCustomLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: bool) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#auto_assign_public_ips-1">OpsworksCustomLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#auto_healing-1">OpsworksCustomLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: bool) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#auto_healing-1">OpsworksCustomLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#cloudwatch_configuration-1">OpsworksCustomLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: aws.OpsworksCustomLayer.OpsworksCustomLayerCloudwatchConfiguration) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_configure_recipes-1">OpsworksCustomLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_deploy_recipes-1">OpsworksCustomLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_instance_profile_arn-1">OpsworksCustomLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: string) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_json-1">OpsworksCustomLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: string) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_security_group_ids-1">OpsworksCustomLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_setup_recipes-1">OpsworksCustomLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_shutdown_recipes-1">OpsworksCustomLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#custom_undeploy_recipes-1">OpsworksCustomLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#drain_elb_on_shutdown-1">OpsworksCustomLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: bool) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#drain_elb_on_shutdown-1">OpsworksCustomLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#ebs_volume-1">OpsworksCustomLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksCustomLayer.OpsworksCustomLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#elastic_load_balancer-1">OpsworksCustomLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: string) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#id-1">OpsworksCustomLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: string) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#install_updates_on_boot-1">OpsworksCustomLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: bool) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#install_updates_on_boot-1">OpsworksCustomLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#instance_shutdown_timeout-1">OpsworksCustomLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: double) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#load_based_auto_scaling-1">OpsworksCustomLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: aws.OpsworksCustomLayer.OpsworksCustomLayerLoadBasedAutoScaling) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#system_packages-1">OpsworksCustomLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#tags-1">OpsworksCustomLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string * string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#tags_all-1">OpsworksCustomLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: seq<string * string>) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#use_ebs_optimized_instances-1">OpsworksCustomLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: bool) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_custom_layer#use_ebs_optimized_instances-1">OpsworksCustomLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksCustomLayerState<'Name, 'ShortName, 'StackId>

        member _.Run(state: OpsworksCustomLayerState<Present, Present, Present>) : aws.OpsworksCustomLayer.OpsworksCustomLayer =
            let config = aws.OpsworksCustomLayer.OpsworksCustomLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksCustomLayer.OpsworksCustomLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksCustomLayer: missing required arguments. Must call: name, short_name, stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksCustomLayerState<_, _, _>) : aws.OpsworksCustomLayer.OpsworksCustomLayer =
            Unchecked.defaultof<aws.OpsworksCustomLayer.OpsworksCustomLayer>
