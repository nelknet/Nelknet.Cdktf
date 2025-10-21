namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisEnterpriseDatabaseState<'ClusterId> = { assignments: ResizeArray<azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database">azurerm_redis_enterprise_database</a>.
    /// </summary>
    type RedisEnterpriseDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisEnterpriseDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : RedisEnterpriseDatabaseState<Missing>)

        member _.Zero(()) : RedisEnterpriseDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : RedisEnterpriseDatabaseState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#cluster_id-1">RedisEnterpriseDatabase#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: RedisEnterpriseDatabaseState<Missing>, value: string) : RedisEnterpriseDatabaseState<Present> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : RedisEnterpriseDatabaseState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#client_protocol-1">RedisEnterpriseDatabase#client_protocol</a>.
        /// </summary>
        [<CustomOperation "client_protocol">]
        member _.ClientProtocol(state: RedisEnterpriseDatabaseState<'ClusterId>, value: string) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.ClientProtocol <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#clustering_policy-1">RedisEnterpriseDatabase#clustering_policy</a>.
        /// </summary>
        [<CustomOperation "clustering_policy">]
        member _.ClusteringPolicy(state: RedisEnterpriseDatabaseState<'ClusterId>, value: string) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.ClusteringPolicy <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#eviction_policy-1">RedisEnterpriseDatabase#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: RedisEnterpriseDatabaseState<'ClusterId>, value: string) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#id-1">RedisEnterpriseDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisEnterpriseDatabaseState<'ClusterId>, value: string) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#linked_database_group_nickname-1">RedisEnterpriseDatabase#linked_database_group_nickname</a>.
        /// </summary>
        [<CustomOperation "linked_database_group_nickname">]
        member _.LinkedDatabaseGroupNickname(state: RedisEnterpriseDatabaseState<'ClusterId>, value: string) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.LinkedDatabaseGroupNickname <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#linked_database_id-1">RedisEnterpriseDatabase#linked_database_id</a>.
        /// </summary>
        [<CustomOperation "linked_database_id">]
        member _.LinkedDatabaseId(state: RedisEnterpriseDatabaseState<'ClusterId>, value: seq<string>) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.LinkedDatabaseId <- (value |> Seq.toArray))
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// module block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#module-1">RedisEnterpriseDatabase#module</a> Accepts: azurerm.IResolvable | azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabaseModule[]
        /// </summary>
        [<CustomOperation "module">]
        member _.Module(state: RedisEnterpriseDatabaseState<'ClusterId>, value: HashiCorp.Cdktf.IResolvable) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.Module <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#name-1">RedisEnterpriseDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedisEnterpriseDatabaseState<'ClusterId>, value: string) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#port-1">RedisEnterpriseDatabase#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: RedisEnterpriseDatabaseState<'ClusterId>, value: double) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#timeouts-1">RedisEnterpriseDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisEnterpriseDatabaseState<'ClusterId>, value: azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabaseTimeouts) : RedisEnterpriseDatabaseState<'ClusterId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisEnterpriseDatabaseState<'ClusterId>

        member _.Run(state: RedisEnterpriseDatabaseState<Present>) : azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabase =
            let config = azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisEnterpriseDatabase: missing required arguments. Must call: cluster_id.", 9999, IsError = true)>]
        member _.Run(_: RedisEnterpriseDatabaseState<_>) : azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabase =
            Unchecked.defaultof<azurerm.RedisEnterpriseDatabase.RedisEnterpriseDatabase>
