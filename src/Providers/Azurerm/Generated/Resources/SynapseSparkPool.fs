namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseSparkPool.SynapseSparkPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool">azurerm_synapse_spark_pool</a>.
    /// </summary>
    type SynapseSparkPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseSparkPoolState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSparkPoolState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseSparkPoolState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSparkPoolState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#name-1">SynapseSparkPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseSparkPoolState<Missing, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<Present, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseSparkPoolState<Present, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#node_size-1">SynapseSparkPool#node_size</a>.
        /// </summary>
        [<CustomOperation "node_size">]
        member _.NodeSize(state: SynapseSparkPoolState<'Name, Missing, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<'Name, Present, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.NodeSize <- value)
            ({ assignments = state.assignments } : SynapseSparkPoolState<'Name, Present, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#node_size_family-1">SynapseSparkPool#node_size_family</a>.
        /// </summary>
        [<CustomOperation "node_size_family">]
        member _.NodeSizeFamily(state: SynapseSparkPoolState<'Name, 'NodeSize, Missing, 'SparkVersion, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<'Name, 'NodeSize, Present, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.NodeSizeFamily <- value)
            ({ assignments = state.assignments } : SynapseSparkPoolState<'Name, 'NodeSize, Present, 'SparkVersion, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#spark_version-1">SynapseSparkPool#spark_version</a>.
        /// </summary>
        [<CustomOperation "spark_version">]
        member _.SparkVersion(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, Missing, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SparkVersion <- value)
            ({ assignments = state.assignments } : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#synapse_workspace_id-1">SynapseSparkPool#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, Missing>, value: string) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, Present>)

        /// <summary>
        /// auto_pause block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#auto_pause-1">SynapseSparkPool#auto_pause</a>
        /// </summary>
        [<CustomOperation "auto_pause">]
        member _.AutoPause(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: azurerm.SynapseSparkPool.SynapseSparkPoolAutoPause) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.AutoPause <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// auto_scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#auto_scale-1">SynapseSparkPool#auto_scale</a>
        /// </summary>
        [<CustomOperation "auto_scale">]
        member _.AutoScale(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: azurerm.SynapseSparkPool.SynapseSparkPoolAutoScale) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.AutoScale <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#cache_size-1">SynapseSparkPool#cache_size</a>.
        /// </summary>
        [<CustomOperation "cache_size">]
        member _.CacheSize(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: double) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.CacheSize <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#compute_isolation_enabled-1">SynapseSparkPool#compute_isolation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "compute_isolation_enabled">]
        member _.ComputeIsolationEnabled(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: bool) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.ComputeIsolationEnabled <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#compute_isolation_enabled-1">SynapseSparkPool#compute_isolation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "compute_isolation_enabled">]
        member _.ComputeIsolationEnabled(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.ComputeIsolationEnabled <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#dynamic_executor_allocation_enabled-1">SynapseSparkPool#dynamic_executor_allocation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_executor_allocation_enabled">]
        member _.DynamicExecutorAllocationEnabled(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: bool) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.DynamicExecutorAllocationEnabled <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#dynamic_executor_allocation_enabled-1">SynapseSparkPool#dynamic_executor_allocation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_executor_allocation_enabled">]
        member _.DynamicExecutorAllocationEnabled(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.DynamicExecutorAllocationEnabled <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#id-1">SynapseSparkPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// library_requirement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#library_requirement-1">SynapseSparkPool#library_requirement</a>
        /// </summary>
        [<CustomOperation "library_requirement">]
        member _.LibraryRequirement(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: azurerm.SynapseSparkPool.SynapseSparkPoolLibraryRequirement) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.LibraryRequirement <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#max_executors-1">SynapseSparkPool#max_executors</a>.
        /// </summary>
        [<CustomOperation "max_executors">]
        member _.MaxExecutors(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: double) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.MaxExecutors <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#min_executors-1">SynapseSparkPool#min_executors</a>.
        /// </summary>
        [<CustomOperation "min_executors">]
        member _.MinExecutors(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: double) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.MinExecutors <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#node_count-1">SynapseSparkPool#node_count</a>.
        /// </summary>
        [<CustomOperation "node_count">]
        member _.NodeCount(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: double) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.NodeCount <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#session_level_packages_enabled-1">SynapseSparkPool#session_level_packages_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "session_level_packages_enabled">]
        member _.SessionLevelPackagesEnabled(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: bool) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SessionLevelPackagesEnabled <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#session_level_packages_enabled-1">SynapseSparkPool#session_level_packages_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "session_level_packages_enabled">]
        member _.SessionLevelPackagesEnabled(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SessionLevelPackagesEnabled <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// spark_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#spark_config-1">SynapseSparkPool#spark_config</a>
        /// </summary>
        [<CustomOperation "spark_config">]
        member _.SparkConfig(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: azurerm.SynapseSparkPool.SynapseSparkPoolSparkConfig) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SparkConfig <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#spark_events_folder-1">SynapseSparkPool#spark_events_folder</a>.
        /// </summary>
        [<CustomOperation "spark_events_folder">]
        member _.SparkEventsFolder(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SparkEventsFolder <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#spark_log_folder-1">SynapseSparkPool#spark_log_folder</a>.
        /// </summary>
        [<CustomOperation "spark_log_folder">]
        member _.SparkLogFolder(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: string) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SparkLogFolder <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#tags-1">SynapseSparkPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: seq<string * string>) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#timeouts-1">SynapseSparkPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>, value: azurerm.SynapseSparkPool.SynapseSparkPoolTimeouts) : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseSparkPoolState<'Name, 'NodeSize, 'NodeSizeFamily, 'SparkVersion, 'SynapseWorkspaceId>

        member _.Run(state: SynapseSparkPoolState<Present, Present, Present, Present, Present>) : azurerm.SynapseSparkPool.SynapseSparkPool =
            let config = azurerm.SynapseSparkPool.SynapseSparkPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseSparkPool.SynapseSparkPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseSparkPool: missing required arguments. Must call: name, node_size, node_size_family, spark_version, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseSparkPoolState<_, _, _, _, _>) : azurerm.SynapseSparkPool.SynapseSparkPool =
            Unchecked.defaultof<azurerm.SynapseSparkPool.SynapseSparkPool>
