namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksPhpAppLayerState<'StackId> = { assignments: ResizeArray<aws.OpsworksPhpAppLayer.OpsworksPhpAppLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer">aws_opsworks_php_app_layer</a>.
    /// </summary>
    type OpsworksPhpAppLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksPhpAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksPhpAppLayerState<Missing>)

        member _.Zero(()) : OpsworksPhpAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksPhpAppLayerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#stack_id-1">OpsworksPhpAppLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksPhpAppLayerState<Missing>, value: string) : OpsworksPhpAppLayerState<Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksPhpAppLayerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#auto_assign_elastic_ips-1">OpsworksPhpAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksPhpAppLayerState<'StackId>, value: bool) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#auto_assign_elastic_ips-1">OpsworksPhpAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#auto_assign_public_ips-1">OpsworksPhpAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksPhpAppLayerState<'StackId>, value: bool) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#auto_assign_public_ips-1">OpsworksPhpAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#auto_healing-1">OpsworksPhpAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksPhpAppLayerState<'StackId>, value: bool) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#auto_healing-1">OpsworksPhpAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#cloudwatch_configuration-1">OpsworksPhpAppLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksPhpAppLayerState<'StackId>, value: aws.OpsworksPhpAppLayer.OpsworksPhpAppLayerCloudwatchConfiguration) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_configure_recipes-1">OpsworksPhpAppLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_deploy_recipes-1">OpsworksPhpAppLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_instance_profile_arn-1">OpsworksPhpAppLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksPhpAppLayerState<'StackId>, value: string) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_json-1">OpsworksPhpAppLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksPhpAppLayerState<'StackId>, value: string) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_security_group_ids-1">OpsworksPhpAppLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_setup_recipes-1">OpsworksPhpAppLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_shutdown_recipes-1">OpsworksPhpAppLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#custom_undeploy_recipes-1">OpsworksPhpAppLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#drain_elb_on_shutdown-1">OpsworksPhpAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksPhpAppLayerState<'StackId>, value: bool) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#drain_elb_on_shutdown-1">OpsworksPhpAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#ebs_volume-1">OpsworksPhpAppLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksPhpAppLayer.OpsworksPhpAppLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#elastic_load_balancer-1">OpsworksPhpAppLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksPhpAppLayerState<'StackId>, value: string) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#id-1">OpsworksPhpAppLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksPhpAppLayerState<'StackId>, value: string) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#install_updates_on_boot-1">OpsworksPhpAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksPhpAppLayerState<'StackId>, value: bool) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#install_updates_on_boot-1">OpsworksPhpAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#instance_shutdown_timeout-1">OpsworksPhpAppLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksPhpAppLayerState<'StackId>, value: double) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#load_based_auto_scaling-1">OpsworksPhpAppLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksPhpAppLayerState<'StackId>, value: aws.OpsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScaling) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#name-1">OpsworksPhpAppLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksPhpAppLayerState<'StackId>, value: string) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#system_packages-1">OpsworksPhpAppLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#tags-1">OpsworksPhpAppLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string * string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#tags_all-1">OpsworksPhpAppLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksPhpAppLayerState<'StackId>, value: seq<string * string>) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#use_ebs_optimized_instances-1">OpsworksPhpAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksPhpAppLayerState<'StackId>, value: bool) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#use_ebs_optimized_instances-1">OpsworksPhpAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksPhpAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPhpAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksPhpAppLayerState<'StackId>

        member _.Run(state: OpsworksPhpAppLayerState<Present>) : aws.OpsworksPhpAppLayer.OpsworksPhpAppLayer =
            let config = aws.OpsworksPhpAppLayer.OpsworksPhpAppLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksPhpAppLayer.OpsworksPhpAppLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksPhpAppLayer: missing required arguments. Must call: stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksPhpAppLayerState<_>) : aws.OpsworksPhpAppLayer.OpsworksPhpAppLayer =
            Unchecked.defaultof<aws.OpsworksPhpAppLayer.OpsworksPhpAppLayer>
