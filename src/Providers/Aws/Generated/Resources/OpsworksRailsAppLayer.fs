namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksRailsAppLayerState<'StackId> = { assignments: ResizeArray<aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer">aws_opsworks_rails_app_layer</a>.
    /// </summary>
    type OpsworksRailsAppLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksRailsAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksRailsAppLayerState<Missing>)

        member _.Zero(()) : OpsworksRailsAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksRailsAppLayerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#stack_id-1">OpsworksRailsAppLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksRailsAppLayerState<Missing>, value: string) : OpsworksRailsAppLayerState<Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksRailsAppLayerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#app_server-1">OpsworksRailsAppLayer#app_server</a>.
        /// </summary>
        [<CustomOperation "app_server">]
        member _.AppServer(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AppServer <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#auto_assign_elastic_ips-1">OpsworksRailsAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#auto_assign_elastic_ips-1">OpsworksRailsAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#auto_assign_public_ips-1">OpsworksRailsAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#auto_assign_public_ips-1">OpsworksRailsAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#auto_healing-1">OpsworksRailsAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#auto_healing-1">OpsworksRailsAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#bundler_version-1">OpsworksRailsAppLayer#bundler_version</a>.
        /// </summary>
        [<CustomOperation "bundler_version">]
        member _.BundlerVersion(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.BundlerVersion <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#cloudwatch_configuration-1">OpsworksRailsAppLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksRailsAppLayerState<'StackId>, value: aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerCloudwatchConfiguration) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_configure_recipes-1">OpsworksRailsAppLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_deploy_recipes-1">OpsworksRailsAppLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_instance_profile_arn-1">OpsworksRailsAppLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_json-1">OpsworksRailsAppLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_security_group_ids-1">OpsworksRailsAppLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_setup_recipes-1">OpsworksRailsAppLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_shutdown_recipes-1">OpsworksRailsAppLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#custom_undeploy_recipes-1">OpsworksRailsAppLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#drain_elb_on_shutdown-1">OpsworksRailsAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#drain_elb_on_shutdown-1">OpsworksRailsAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#ebs_volume-1">OpsworksRailsAppLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#elastic_load_balancer-1">OpsworksRailsAppLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#id-1">OpsworksRailsAppLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#install_updates_on_boot-1">OpsworksRailsAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#install_updates_on_boot-1">OpsworksRailsAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#instance_shutdown_timeout-1">OpsworksRailsAppLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksRailsAppLayerState<'StackId>, value: double) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#load_based_auto_scaling-1">OpsworksRailsAppLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksRailsAppLayerState<'StackId>, value: aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScaling) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#manage_bundler-1">OpsworksRailsAppLayer#manage_bundler</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_bundler">]
        member _.ManageBundler(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ManageBundler <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#manage_bundler-1">OpsworksRailsAppLayer#manage_bundler</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_bundler">]
        member _.ManageBundler(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ManageBundler <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#name-1">OpsworksRailsAppLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#passenger_version-1">OpsworksRailsAppLayer#passenger_version</a>.
        /// </summary>
        [<CustomOperation "passenger_version">]
        member _.PassengerVersion(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.PassengerVersion <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#rubygems_version-1">OpsworksRailsAppLayer#rubygems_version</a>.
        /// </summary>
        [<CustomOperation "rubygems_version">]
        member _.RubygemsVersion(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.RubygemsVersion <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#ruby_version-1">OpsworksRailsAppLayer#ruby_version</a>.
        /// </summary>
        [<CustomOperation "ruby_version">]
        member _.RubyVersion(state: OpsworksRailsAppLayerState<'StackId>, value: string) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.RubyVersion <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#system_packages-1">OpsworksRailsAppLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#tags-1">OpsworksRailsAppLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string * string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#tags_all-1">OpsworksRailsAppLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksRailsAppLayerState<'StackId>, value: seq<string * string>) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#use_ebs_optimized_instances-1">OpsworksRailsAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksRailsAppLayerState<'StackId>, value: bool) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rails_app_layer#use_ebs_optimized_instances-1">OpsworksRailsAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksRailsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksRailsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksRailsAppLayerState<'StackId>

        member _.Run(state: OpsworksRailsAppLayerState<Present>) : aws.OpsworksRailsAppLayer.OpsworksRailsAppLayer =
            let config = aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksRailsAppLayer.OpsworksRailsAppLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksRailsAppLayer: missing required arguments. Must call: stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksRailsAppLayerState<_>) : aws.OpsworksRailsAppLayer.OpsworksRailsAppLayer =
            Unchecked.defaultof<aws.OpsworksRailsAppLayer.OpsworksRailsAppLayer>
