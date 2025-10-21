namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksGangliaLayerState<'Password, 'StackId> = { assignments: ResizeArray<aws.OpsworksGangliaLayer.OpsworksGangliaLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer">aws_opsworks_ganglia_layer</a>.
    /// </summary>
    type OpsworksGangliaLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksGangliaLayerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksGangliaLayerState<Missing, Missing>)

        member _.Zero(()) : OpsworksGangliaLayerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksGangliaLayerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#password-1">OpsworksGangliaLayer#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: OpsworksGangliaLayerState<Missing, 'StackId>, value: string) : OpsworksGangliaLayerState<Present, 'StackId> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : OpsworksGangliaLayerState<Present, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#stack_id-1">OpsworksGangliaLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksGangliaLayerState<'Password, Missing>, value: string) : OpsworksGangliaLayerState<'Password, Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksGangliaLayerState<'Password, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#auto_assign_elastic_ips-1">OpsworksGangliaLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: bool) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#auto_assign_elastic_ips-1">OpsworksGangliaLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#auto_assign_public_ips-1">OpsworksGangliaLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: bool) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#auto_assign_public_ips-1">OpsworksGangliaLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#auto_healing-1">OpsworksGangliaLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: bool) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#auto_healing-1">OpsworksGangliaLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#cloudwatch_configuration-1">OpsworksGangliaLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: aws.OpsworksGangliaLayer.OpsworksGangliaLayerCloudwatchConfiguration) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_configure_recipes-1">OpsworksGangliaLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_deploy_recipes-1">OpsworksGangliaLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_instance_profile_arn-1">OpsworksGangliaLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_json-1">OpsworksGangliaLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_security_group_ids-1">OpsworksGangliaLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_setup_recipes-1">OpsworksGangliaLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_shutdown_recipes-1">OpsworksGangliaLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#custom_undeploy_recipes-1">OpsworksGangliaLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#drain_elb_on_shutdown-1">OpsworksGangliaLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: bool) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#drain_elb_on_shutdown-1">OpsworksGangliaLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#ebs_volume-1">OpsworksGangliaLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksGangliaLayer.OpsworksGangliaLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#elastic_load_balancer-1">OpsworksGangliaLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#id-1">OpsworksGangliaLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#install_updates_on_boot-1">OpsworksGangliaLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: bool) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#install_updates_on_boot-1">OpsworksGangliaLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#instance_shutdown_timeout-1">OpsworksGangliaLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: double) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#load_based_auto_scaling-1">OpsworksGangliaLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: aws.OpsworksGangliaLayer.OpsworksGangliaLayerLoadBasedAutoScaling) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#name-1">OpsworksGangliaLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#system_packages-1">OpsworksGangliaLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#tags-1">OpsworksGangliaLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string * string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#tags_all-1">OpsworksGangliaLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: seq<string * string>) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#url-1">OpsworksGangliaLayer#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.Url <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#use_ebs_optimized_instances-1">OpsworksGangliaLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: bool) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#use_ebs_optimized_instances-1">OpsworksGangliaLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#username-1">OpsworksGangliaLayer#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: OpsworksGangliaLayerState<'Password, 'StackId>, value: string) : OpsworksGangliaLayerState<'Password, 'StackId> =
            state.assignments.Add(fun config -> config.Username <- value)
            state : OpsworksGangliaLayerState<'Password, 'StackId>

        member _.Run(state: OpsworksGangliaLayerState<Present, Present>) : aws.OpsworksGangliaLayer.OpsworksGangliaLayer =
            let config = aws.OpsworksGangliaLayer.OpsworksGangliaLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksGangliaLayer.OpsworksGangliaLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksGangliaLayer: missing required arguments. Must call: password, stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksGangliaLayerState<_, _>) : aws.OpsworksGangliaLayer.OpsworksGangliaLayer =
            Unchecked.defaultof<aws.OpsworksGangliaLayer.OpsworksGangliaLayer>
