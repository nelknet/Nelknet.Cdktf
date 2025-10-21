namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> = { assignments: ResizeArray<aws.FinspaceKxCluster.FinspaceKxClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster">aws_finspace_kx_cluster</a>.
    /// </summary>
    type FinspaceKxClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FinspaceKxClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#az_mode-1">FinspaceKxCluster#az_mode</a>.
        /// </summary>
        [<CustomOperation "az_mode">]
        member _.AzMode(state: FinspaceKxClusterState<Missing, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<Present, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.AzMode <- value)
            ({ assignments = state.assignments } : FinspaceKxClusterState<Present, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#environment_id-1">FinspaceKxCluster#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: FinspaceKxClusterState<'AzMode, Missing, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, Present, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : FinspaceKxClusterState<'AzMode, Present, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#name-1">FinspaceKxCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, Missing, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, Present, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxClusterState<'AzMode, 'EnvironmentId, Present, 'ReleaseLabel, 'Type, 'VpcConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#release_label-1">FinspaceKxCluster#release_label</a>.
        /// </summary>
        [<CustomOperation "release_label">]
        member _.ReleaseLabel(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, Missing, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, Present, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.ReleaseLabel <- value)
            ({ assignments = state.assignments } : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, Present, 'Type, 'VpcConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#type-1">FinspaceKxCluster#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, Missing, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, Present, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, Present, 'VpcConfiguration>)

        /// <summary>
        /// vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#vpc_configuration-1">FinspaceKxCluster#vpc_configuration</a>
        /// </summary>
        [<CustomOperation "vpc_configuration">]
        member _.VpcConfiguration(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, Missing>, value: aws.FinspaceKxCluster.FinspaceKxClusterVpcConfiguration) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, Present> =
            state.assignments.Add(fun config -> config.VpcConfiguration <- value)
            ({ assignments = state.assignments } : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, Present>)

        /// <summary>
        /// auto_scaling_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#auto_scaling_configuration-1">FinspaceKxCluster#auto_scaling_configuration</a>
        /// </summary>
        [<CustomOperation "auto_scaling_configuration">]
        member _.AutoScalingConfiguration(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: aws.FinspaceKxCluster.FinspaceKxClusterAutoScalingConfiguration) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.AutoScalingConfiguration <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#availability_zone_id-1">FinspaceKxCluster#availability_zone_id</a>.
        /// </summary>
        [<CustomOperation "availability_zone_id">]
        member _.AvailabilityZoneId(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.AvailabilityZoneId <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// cache_storage_configurations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cache_storage_configurations-1">FinspaceKxCluster#cache_storage_configurations</a> Accepts: aws.IResolvable | aws.FinspaceKxCluster.FinspaceKxClusterCacheStorageConfigurations[]
        /// </summary>
        [<CustomOperation "cache_storage_configurations">]
        member _.CacheStorageConfigurations(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.CacheStorageConfigurations <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// capacity_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#capacity_configuration-1">FinspaceKxCluster#capacity_configuration</a>
        /// </summary>
        [<CustomOperation "capacity_configuration">]
        member _.CapacityConfiguration(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: aws.FinspaceKxCluster.FinspaceKxClusterCapacityConfiguration) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.CapacityConfiguration <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// code block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#code-1">FinspaceKxCluster#code</a>
        /// </summary>
        [<CustomOperation "code">]
        member _.Code(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: aws.FinspaceKxCluster.FinspaceKxClusterCode) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Code <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#command_line_arguments-1">FinspaceKxCluster#command_line_arguments</a>.
        /// </summary>
        [<CustomOperation "command_line_arguments">]
        member _.CommandLineArguments(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: seq<string * string>) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.CommandLineArguments <- dict value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#database-1">FinspaceKxCluster#database</a> Accepts: aws.IResolvable | aws.FinspaceKxCluster.FinspaceKxClusterDatabase[]
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Database <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#description-1">FinspaceKxCluster#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#execution_role-1">FinspaceKxCluster#execution_role</a>.
        /// </summary>
        [<CustomOperation "execution_role">]
        member _.ExecutionRole(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.ExecutionRole <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#id-1">FinspaceKxCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#initialization_script-1">FinspaceKxCluster#initialization_script</a>.
        /// </summary>
        [<CustomOperation "initialization_script">]
        member _.InitializationScript(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: string) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.InitializationScript <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// savedown_storage_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#savedown_storage_configuration-1">FinspaceKxCluster#savedown_storage_configuration</a>
        /// </summary>
        [<CustomOperation "savedown_storage_configuration">]
        member _.SavedownStorageConfiguration(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: aws.FinspaceKxCluster.FinspaceKxClusterSavedownStorageConfiguration) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.SavedownStorageConfiguration <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// scaling_group_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#scaling_group_configuration-1">FinspaceKxCluster#scaling_group_configuration</a>
        /// </summary>
        [<CustomOperation "scaling_group_configuration">]
        member _.ScalingGroupConfiguration(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: aws.FinspaceKxCluster.FinspaceKxClusterScalingGroupConfiguration) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.ScalingGroupConfiguration <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#tags-1">FinspaceKxCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: seq<string * string>) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#tags_all-1">FinspaceKxCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: seq<string * string>) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// tickerplant_log_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#tickerplant_log_configuration-1">FinspaceKxCluster#tickerplant_log_configuration</a> Accepts: aws.IResolvable | aws.FinspaceKxCluster.FinspaceKxClusterTickerplantLogConfiguration[]
        /// </summary>
        [<CustomOperation "tickerplant_log_configuration">]
        member _.TickerplantLogConfiguration(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.TickerplantLogConfiguration <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#timeouts-1">FinspaceKxCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>, value: aws.FinspaceKxCluster.FinspaceKxClusterTimeouts) : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxClusterState<'AzMode, 'EnvironmentId, 'Name, 'ReleaseLabel, 'Type, 'VpcConfiguration>

        member _.Run(state: FinspaceKxClusterState<Present, Present, Present, Present, Present, Present>) : aws.FinspaceKxCluster.FinspaceKxCluster =
            let config = aws.FinspaceKxCluster.FinspaceKxClusterConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxCluster.FinspaceKxCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxCluster: missing required arguments. Must call: az_mode, environment_id, name, release_label, type, vpc_configuration.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxClusterState<_, _, _, _, _, _>) : aws.FinspaceKxCluster.FinspaceKxCluster =
            Unchecked.defaultof<aws.FinspaceKxCluster.FinspaceKxCluster>
