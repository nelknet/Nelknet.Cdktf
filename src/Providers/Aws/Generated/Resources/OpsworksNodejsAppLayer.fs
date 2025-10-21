namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksNodejsAppLayerState<'StackId> = { assignments: ResizeArray<aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer">aws_opsworks_nodejs_app_layer</a>.
    /// </summary>
    type OpsworksNodejsAppLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksNodejsAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksNodejsAppLayerState<Missing>)

        member _.Zero(()) : OpsworksNodejsAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksNodejsAppLayerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#stack_id-1">OpsworksNodejsAppLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksNodejsAppLayerState<Missing>, value: string) : OpsworksNodejsAppLayerState<Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksNodejsAppLayerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#auto_assign_elastic_ips-1">OpsworksNodejsAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksNodejsAppLayerState<'StackId>, value: bool) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#auto_assign_elastic_ips-1">OpsworksNodejsAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#auto_assign_public_ips-1">OpsworksNodejsAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksNodejsAppLayerState<'StackId>, value: bool) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#auto_assign_public_ips-1">OpsworksNodejsAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#auto_healing-1">OpsworksNodejsAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksNodejsAppLayerState<'StackId>, value: bool) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#auto_healing-1">OpsworksNodejsAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#cloudwatch_configuration-1">OpsworksNodejsAppLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksNodejsAppLayerState<'StackId>, value: aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerCloudwatchConfiguration) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_configure_recipes-1">OpsworksNodejsAppLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_deploy_recipes-1">OpsworksNodejsAppLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_instance_profile_arn-1">OpsworksNodejsAppLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksNodejsAppLayerState<'StackId>, value: string) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_json-1">OpsworksNodejsAppLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksNodejsAppLayerState<'StackId>, value: string) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_security_group_ids-1">OpsworksNodejsAppLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_setup_recipes-1">OpsworksNodejsAppLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_shutdown_recipes-1">OpsworksNodejsAppLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#custom_undeploy_recipes-1">OpsworksNodejsAppLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#drain_elb_on_shutdown-1">OpsworksNodejsAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksNodejsAppLayerState<'StackId>, value: bool) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#drain_elb_on_shutdown-1">OpsworksNodejsAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#ebs_volume-1">OpsworksNodejsAppLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#elastic_load_balancer-1">OpsworksNodejsAppLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksNodejsAppLayerState<'StackId>, value: string) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#id-1">OpsworksNodejsAppLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksNodejsAppLayerState<'StackId>, value: string) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#install_updates_on_boot-1">OpsworksNodejsAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksNodejsAppLayerState<'StackId>, value: bool) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#install_updates_on_boot-1">OpsworksNodejsAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#instance_shutdown_timeout-1">OpsworksNodejsAppLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksNodejsAppLayerState<'StackId>, value: double) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#load_based_auto_scaling-1">OpsworksNodejsAppLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksNodejsAppLayerState<'StackId>, value: aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScaling) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#name-1">OpsworksNodejsAppLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksNodejsAppLayerState<'StackId>, value: string) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#nodejs_version-1">OpsworksNodejsAppLayer#nodejs_version</a>.
        /// </summary>
        [<CustomOperation "nodejs_version">]
        member _.NodejsVersion(state: OpsworksNodejsAppLayerState<'StackId>, value: string) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.NodejsVersion <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#system_packages-1">OpsworksNodejsAppLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#tags-1">OpsworksNodejsAppLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string * string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#tags_all-1">OpsworksNodejsAppLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksNodejsAppLayerState<'StackId>, value: seq<string * string>) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#use_ebs_optimized_instances-1">OpsworksNodejsAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksNodejsAppLayerState<'StackId>, value: bool) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#use_ebs_optimized_instances-1">OpsworksNodejsAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksNodejsAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksNodejsAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksNodejsAppLayerState<'StackId>

        member _.Run(state: OpsworksNodejsAppLayerState<Present>) : aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayer =
            let config = aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksNodejsAppLayer: missing required arguments. Must call: stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksNodejsAppLayerState<_>) : aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayer =
            Unchecked.defaultof<aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayer>
