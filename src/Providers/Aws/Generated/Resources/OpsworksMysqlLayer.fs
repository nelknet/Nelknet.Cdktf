namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksMysqlLayerState<'StackId> = { assignments: ResizeArray<aws.OpsworksMysqlLayer.OpsworksMysqlLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer">aws_opsworks_mysql_layer</a>.
    /// </summary>
    type OpsworksMysqlLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksMysqlLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksMysqlLayerState<Missing>)

        member _.Zero(()) : OpsworksMysqlLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksMysqlLayerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#stack_id-1">OpsworksMysqlLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksMysqlLayerState<Missing>, value: string) : OpsworksMysqlLayerState<Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksMysqlLayerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#auto_assign_elastic_ips-1">OpsworksMysqlLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#auto_assign_elastic_ips-1">OpsworksMysqlLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#auto_assign_public_ips-1">OpsworksMysqlLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#auto_assign_public_ips-1">OpsworksMysqlLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#auto_healing-1">OpsworksMysqlLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#auto_healing-1">OpsworksMysqlLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#cloudwatch_configuration-1">OpsworksMysqlLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksMysqlLayerState<'StackId>, value: aws.OpsworksMysqlLayer.OpsworksMysqlLayerCloudwatchConfiguration) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_configure_recipes-1">OpsworksMysqlLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_deploy_recipes-1">OpsworksMysqlLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_instance_profile_arn-1">OpsworksMysqlLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksMysqlLayerState<'StackId>, value: string) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_json-1">OpsworksMysqlLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksMysqlLayerState<'StackId>, value: string) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_security_group_ids-1">OpsworksMysqlLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_setup_recipes-1">OpsworksMysqlLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_shutdown_recipes-1">OpsworksMysqlLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#custom_undeploy_recipes-1">OpsworksMysqlLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#drain_elb_on_shutdown-1">OpsworksMysqlLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#drain_elb_on_shutdown-1">OpsworksMysqlLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#ebs_volume-1">OpsworksMysqlLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksMysqlLayer.OpsworksMysqlLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#elastic_load_balancer-1">OpsworksMysqlLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksMysqlLayerState<'StackId>, value: string) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#id-1">OpsworksMysqlLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksMysqlLayerState<'StackId>, value: string) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#install_updates_on_boot-1">OpsworksMysqlLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#install_updates_on_boot-1">OpsworksMysqlLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#instance_shutdown_timeout-1">OpsworksMysqlLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksMysqlLayerState<'StackId>, value: double) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#load_based_auto_scaling-1">OpsworksMysqlLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksMysqlLayerState<'StackId>, value: aws.OpsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScaling) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#name-1">OpsworksMysqlLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksMysqlLayerState<'StackId>, value: string) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#root_password-1">OpsworksMysqlLayer#root_password</a>.
        /// </summary>
        [<CustomOperation "root_password">]
        member _.RootPassword(state: OpsworksMysqlLayerState<'StackId>, value: string) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.RootPassword <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#root_password_on_all_instances-1">OpsworksMysqlLayer#root_password_on_all_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "root_password_on_all_instances">]
        member _.RootPasswordOnAllInstances(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.RootPasswordOnAllInstances <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#root_password_on_all_instances-1">OpsworksMysqlLayer#root_password_on_all_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "root_password_on_all_instances">]
        member _.RootPasswordOnAllInstances(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.RootPasswordOnAllInstances <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#system_packages-1">OpsworksMysqlLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksMysqlLayerState<'StackId>, value: seq<string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#tags-1">OpsworksMysqlLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksMysqlLayerState<'StackId>, value: seq<string * string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#tags_all-1">OpsworksMysqlLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksMysqlLayerState<'StackId>, value: seq<string * string>) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#use_ebs_optimized_instances-1">OpsworksMysqlLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksMysqlLayerState<'StackId>, value: bool) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksMysqlLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#use_ebs_optimized_instances-1">OpsworksMysqlLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksMysqlLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksMysqlLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksMysqlLayerState<'StackId>

        member _.Run(state: OpsworksMysqlLayerState<Present>) : aws.OpsworksMysqlLayer.OpsworksMysqlLayer =
            let config = aws.OpsworksMysqlLayer.OpsworksMysqlLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksMysqlLayer.OpsworksMysqlLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksMysqlLayer: missing required arguments. Must call: stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksMysqlLayerState<_>) : aws.OpsworksMysqlLayer.OpsworksMysqlLayer =
            Unchecked.defaultof<aws.OpsworksMysqlLayer.OpsworksMysqlLayer>
