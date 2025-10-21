namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksHaproxyLayerState<'StackId, 'StatsPassword> = { assignments: ResizeArray<aws.OpsworksHaproxyLayer.OpsworksHaproxyLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer">aws_opsworks_haproxy_layer</a>.
    /// </summary>
    type OpsworksHaproxyLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksHaproxyLayerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksHaproxyLayerState<Missing, Missing>)

        member _.Zero(()) : OpsworksHaproxyLayerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksHaproxyLayerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#stack_id-1">OpsworksHaproxyLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksHaproxyLayerState<Missing, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<Present, 'StatsPassword> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksHaproxyLayerState<Present, 'StatsPassword>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#stats_password-1">OpsworksHaproxyLayer#stats_password</a>.
        /// </summary>
        [<CustomOperation "stats_password">]
        member _.StatsPassword(state: OpsworksHaproxyLayerState<'StackId, Missing>, value: string) : OpsworksHaproxyLayerState<'StackId, Present> =
            state.assignments.Add(fun config -> config.StatsPassword <- value)
            ({ assignments = state.assignments } : OpsworksHaproxyLayerState<'StackId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#auto_assign_elastic_ips-1">OpsworksHaproxyLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#auto_assign_elastic_ips-1">OpsworksHaproxyLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#auto_assign_public_ips-1">OpsworksHaproxyLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#auto_assign_public_ips-1">OpsworksHaproxyLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#auto_healing-1">OpsworksHaproxyLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#auto_healing-1">OpsworksHaproxyLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#cloudwatch_configuration-1">OpsworksHaproxyLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: aws.OpsworksHaproxyLayer.OpsworksHaproxyLayerCloudwatchConfiguration) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_configure_recipes-1">OpsworksHaproxyLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_deploy_recipes-1">OpsworksHaproxyLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_instance_profile_arn-1">OpsworksHaproxyLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_json-1">OpsworksHaproxyLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_security_group_ids-1">OpsworksHaproxyLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_setup_recipes-1">OpsworksHaproxyLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_shutdown_recipes-1">OpsworksHaproxyLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#custom_undeploy_recipes-1">OpsworksHaproxyLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#drain_elb_on_shutdown-1">OpsworksHaproxyLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#drain_elb_on_shutdown-1">OpsworksHaproxyLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#ebs_volume-1">OpsworksHaproxyLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksHaproxyLayer.OpsworksHaproxyLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#elastic_load_balancer-1">OpsworksHaproxyLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#healthcheck_method-1">OpsworksHaproxyLayer#healthcheck_method</a>.
        /// </summary>
        [<CustomOperation "healthcheck_method">]
        member _.HealthcheckMethod(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.HealthcheckMethod <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#healthcheck_url-1">OpsworksHaproxyLayer#healthcheck_url</a>.
        /// </summary>
        [<CustomOperation "healthcheck_url">]
        member _.HealthcheckUrl(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.HealthcheckUrl <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#id-1">OpsworksHaproxyLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#install_updates_on_boot-1">OpsworksHaproxyLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#install_updates_on_boot-1">OpsworksHaproxyLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#instance_shutdown_timeout-1">OpsworksHaproxyLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: double) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#load_based_auto_scaling-1">OpsworksHaproxyLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: aws.OpsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScaling) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#name-1">OpsworksHaproxyLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#stats_enabled-1">OpsworksHaproxyLayer#stats_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "stats_enabled">]
        member _.StatsEnabled(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.StatsEnabled <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#stats_enabled-1">OpsworksHaproxyLayer#stats_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "stats_enabled">]
        member _.StatsEnabled(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.StatsEnabled <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#stats_url-1">OpsworksHaproxyLayer#stats_url</a>.
        /// </summary>
        [<CustomOperation "stats_url">]
        member _.StatsUrl(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.StatsUrl <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#stats_user-1">OpsworksHaproxyLayer#stats_user</a>.
        /// </summary>
        [<CustomOperation "stats_user">]
        member _.StatsUser(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: string) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.StatsUser <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#system_packages-1">OpsworksHaproxyLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#tags-1">OpsworksHaproxyLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string * string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#tags_all-1">OpsworksHaproxyLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: seq<string * string>) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#use_ebs_optimized_instances-1">OpsworksHaproxyLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: bool) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#use_ebs_optimized_instances-1">OpsworksHaproxyLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksHaproxyLayerState<'StackId, 'StatsPassword>, value: HashiCorp.Cdktf.IResolvable) : OpsworksHaproxyLayerState<'StackId, 'StatsPassword> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksHaproxyLayerState<'StackId, 'StatsPassword>

        member _.Run(state: OpsworksHaproxyLayerState<Present, Present>) : aws.OpsworksHaproxyLayer.OpsworksHaproxyLayer =
            let config = aws.OpsworksHaproxyLayer.OpsworksHaproxyLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksHaproxyLayer.OpsworksHaproxyLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksHaproxyLayer: missing required arguments. Must call: stack_id, stats_password.", 9999, IsError = true)>]
        member _.Run(_: OpsworksHaproxyLayerState<_, _>) : aws.OpsworksHaproxyLayer.OpsworksHaproxyLayer =
            Unchecked.defaultof<aws.OpsworksHaproxyLayer.OpsworksHaproxyLayer>
