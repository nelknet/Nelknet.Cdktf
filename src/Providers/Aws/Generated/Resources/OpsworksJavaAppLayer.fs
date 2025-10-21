namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksJavaAppLayerState<'StackId> = { assignments: ResizeArray<aws.OpsworksJavaAppLayer.OpsworksJavaAppLayerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer">aws_opsworks_java_app_layer</a>.
    /// </summary>
    type OpsworksJavaAppLayerBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksJavaAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksJavaAppLayerState<Missing>)

        member _.Zero(()) : OpsworksJavaAppLayerState<Missing> =
            ({ assignments = ResizeArray() } : OpsworksJavaAppLayerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#stack_id-1">OpsworksJavaAppLayer#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksJavaAppLayerState<Missing>, value: string) : OpsworksJavaAppLayerState<Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksJavaAppLayerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#app_server-1">OpsworksJavaAppLayer#app_server</a>.
        /// </summary>
        [<CustomOperation "app_server">]
        member _.AppServer(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AppServer <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#app_server_version-1">OpsworksJavaAppLayer#app_server_version</a>.
        /// </summary>
        [<CustomOperation "app_server_version">]
        member _.AppServerVersion(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AppServerVersion <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#auto_assign_elastic_ips-1">OpsworksJavaAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksJavaAppLayerState<'StackId>, value: bool) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#auto_assign_elastic_ips-1">OpsworksJavaAppLayer#auto_assign_elastic_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_elastic_ips">]
        member _.AutoAssignElasticIps(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignElasticIps <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#auto_assign_public_ips-1">OpsworksJavaAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksJavaAppLayerState<'StackId>, value: bool) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#auto_assign_public_ips-1">OpsworksJavaAppLayer#auto_assign_public_ips</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_assign_public_ips">]
        member _.AutoAssignPublicIps(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoAssignPublicIps <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#auto_healing-1">OpsworksJavaAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksJavaAppLayerState<'StackId>, value: bool) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#auto_healing-1">OpsworksJavaAppLayer#auto_healing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_healing">]
        member _.AutoHealing(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.AutoHealing <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// cloudwatch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#cloudwatch_configuration-1">OpsworksJavaAppLayer#cloudwatch_configuration</a>
        /// </summary>
        [<CustomOperation "cloudwatch_configuration">]
        member _.CloudwatchConfiguration(state: OpsworksJavaAppLayerState<'StackId>, value: aws.OpsworksJavaAppLayer.OpsworksJavaAppLayerCloudwatchConfiguration) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CloudwatchConfiguration <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_configure_recipes-1">OpsworksJavaAppLayer#custom_configure_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_configure_recipes">]
        member _.CustomConfigureRecipes(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomConfigureRecipes <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_deploy_recipes-1">OpsworksJavaAppLayer#custom_deploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_deploy_recipes">]
        member _.CustomDeployRecipes(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomDeployRecipes <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_instance_profile_arn-1">OpsworksJavaAppLayer#custom_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "custom_instance_profile_arn">]
        member _.CustomInstanceProfileArn(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomInstanceProfileArn <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_json-1">OpsworksJavaAppLayer#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_security_group_ids-1">OpsworksJavaAppLayer#custom_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "custom_security_group_ids">]
        member _.CustomSecurityGroupIds(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_setup_recipes-1">OpsworksJavaAppLayer#custom_setup_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_setup_recipes">]
        member _.CustomSetupRecipes(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomSetupRecipes <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_shutdown_recipes-1">OpsworksJavaAppLayer#custom_shutdown_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_shutdown_recipes">]
        member _.CustomShutdownRecipes(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomShutdownRecipes <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#custom_undeploy_recipes-1">OpsworksJavaAppLayer#custom_undeploy_recipes</a>.
        /// </summary>
        [<CustomOperation "custom_undeploy_recipes">]
        member _.CustomUndeployRecipes(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.CustomUndeployRecipes <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#drain_elb_on_shutdown-1">OpsworksJavaAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksJavaAppLayerState<'StackId>, value: bool) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#drain_elb_on_shutdown-1">OpsworksJavaAppLayer#drain_elb_on_shutdown</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drain_elb_on_shutdown">]
        member _.DrainElbOnShutdown(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.DrainElbOnShutdown <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// ebs_volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#ebs_volume-1">OpsworksJavaAppLayer#ebs_volume</a> Accepts: aws.IResolvable | aws.OpsworksJavaAppLayer.OpsworksJavaAppLayerEbsVolume[]
        /// </summary>
        [<CustomOperation "ebs_volume">]
        member _.EbsVolume(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.EbsVolume <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#elastic_load_balancer-1">OpsworksJavaAppLayer#elastic_load_balancer</a>.
        /// </summary>
        [<CustomOperation "elastic_load_balancer">]
        member _.ElasticLoadBalancer(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.ElasticLoadBalancer <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#id-1">OpsworksJavaAppLayer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#install_updates_on_boot-1">OpsworksJavaAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksJavaAppLayerState<'StackId>, value: bool) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#install_updates_on_boot-1">OpsworksJavaAppLayer#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#instance_shutdown_timeout-1">OpsworksJavaAppLayer#instance_shutdown_timeout</a>.
        /// </summary>
        [<CustomOperation "instance_shutdown_timeout">]
        member _.InstanceShutdownTimeout(state: OpsworksJavaAppLayerState<'StackId>, value: double) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.InstanceShutdownTimeout <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#jvm_options-1">OpsworksJavaAppLayer#jvm_options</a>.
        /// </summary>
        [<CustomOperation "jvm_options">]
        member _.JvmOptions(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.JvmOptions <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#jvm_type-1">OpsworksJavaAppLayer#jvm_type</a>.
        /// </summary>
        [<CustomOperation "jvm_type">]
        member _.JvmType(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.JvmType <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#jvm_version-1">OpsworksJavaAppLayer#jvm_version</a>.
        /// </summary>
        [<CustomOperation "jvm_version">]
        member _.JvmVersion(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.JvmVersion <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// load_based_auto_scaling block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#load_based_auto_scaling-1">OpsworksJavaAppLayer#load_based_auto_scaling</a>
        /// </summary>
        [<CustomOperation "load_based_auto_scaling">]
        member _.LoadBasedAutoScaling(state: OpsworksJavaAppLayerState<'StackId>, value: aws.OpsworksJavaAppLayer.OpsworksJavaAppLayerLoadBasedAutoScaling) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.LoadBasedAutoScaling <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#name-1">OpsworksJavaAppLayer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksJavaAppLayerState<'StackId>, value: string) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#system_packages-1">OpsworksJavaAppLayer#system_packages</a>.
        /// </summary>
        [<CustomOperation "system_packages">]
        member _.SystemPackages(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.SystemPackages <- (value |> Seq.toArray))
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#tags-1">OpsworksJavaAppLayer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string * string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#tags_all-1">OpsworksJavaAppLayer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksJavaAppLayerState<'StackId>, value: seq<string * string>) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#use_ebs_optimized_instances-1">OpsworksJavaAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksJavaAppLayerState<'StackId>, value: bool) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#use_ebs_optimized_instances-1">OpsworksJavaAppLayer#use_ebs_optimized_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_ebs_optimized_instances">]
        member _.UseEbsOptimizedInstances(state: OpsworksJavaAppLayerState<'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksJavaAppLayerState<'StackId> =
            state.assignments.Add(fun config -> config.UseEbsOptimizedInstances <- value)
            state : OpsworksJavaAppLayerState<'StackId>

        member _.Run(state: OpsworksJavaAppLayerState<Present>) : aws.OpsworksJavaAppLayer.OpsworksJavaAppLayer =
            let config = aws.OpsworksJavaAppLayer.OpsworksJavaAppLayerConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksJavaAppLayer.OpsworksJavaAppLayer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksJavaAppLayer: missing required arguments. Must call: stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksJavaAppLayerState<_>) : aws.OpsworksJavaAppLayer.OpsworksJavaAppLayer =
            Unchecked.defaultof<aws.OpsworksJavaAppLayer.OpsworksJavaAppLayer>
