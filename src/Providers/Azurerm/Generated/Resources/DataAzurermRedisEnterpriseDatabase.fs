namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_enterprise_database">azurerm_redis_enterprise_database</a>.
    /// </summary>
    type DataAzurermRedisEnterpriseDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRedisEnterpriseDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRedisEnterpriseDatabaseState<Missing, Missing>)

        member _.Zero(()) : DataAzurermRedisEnterpriseDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRedisEnterpriseDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_enterprise_database#cluster_id-1">DataAzurermRedisEnterpriseDatabase#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: DataAzurermRedisEnterpriseDatabaseState<Missing, 'Name>, value: string) : DataAzurermRedisEnterpriseDatabaseState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : DataAzurermRedisEnterpriseDatabaseState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_enterprise_database#name-1">DataAzurermRedisEnterpriseDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermRedisEnterpriseDatabaseState<'ClusterId, Missing>, value: string) : DataAzurermRedisEnterpriseDatabaseState<'ClusterId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermRedisEnterpriseDatabaseState<'ClusterId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_enterprise_database#id-1">DataAzurermRedisEnterpriseDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name>, value: string) : DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_enterprise_database#timeouts-1">DataAzurermRedisEnterpriseDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name>, value: azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabaseTimeouts) : DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRedisEnterpriseDatabaseState<'ClusterId, 'Name>

        member _.Run(state: DataAzurermRedisEnterpriseDatabaseState<Present, Present>) : azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabase =
            let config = azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermRedisEnterpriseDatabase: missing required arguments. Must call: cluster_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermRedisEnterpriseDatabaseState<_, _>) : azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabase =
            Unchecked.defaultof<azurerm.DataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabase>
