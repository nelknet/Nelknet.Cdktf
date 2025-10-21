namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlManagedDatabaseState<'ManagedInstanceId, 'Name> = { assignments: ResizeArray<azurerm.MssqlManagedDatabase.MssqlManagedDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database">azurerm_mssql_managed_database</a>.
    /// </summary>
    type MssqlManagedDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlManagedDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedDatabaseState<Missing, Missing>)

        member _.Zero(()) : MssqlManagedDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#managed_instance_id-1">MssqlManagedDatabase#managed_instance_id</a>.
        /// </summary>
        [<CustomOperation "managed_instance_id">]
        member _.ManagedInstanceId(state: MssqlManagedDatabaseState<Missing, 'Name>, value: string) : MssqlManagedDatabaseState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagedInstanceId <- value)
            ({ assignments = state.assignments } : MssqlManagedDatabaseState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#name-1">MssqlManagedDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlManagedDatabaseState<'ManagedInstanceId, Missing>, value: string) : MssqlManagedDatabaseState<'ManagedInstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlManagedDatabaseState<'ManagedInstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#id-1">MssqlManagedDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>, value: string) : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>

        /// <summary>
        /// long_term_retention_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#long_term_retention_policy-1">MssqlManagedDatabase#long_term_retention_policy</a>
        /// </summary>
        [<CustomOperation "long_term_retention_policy">]
        member _.LongTermRetentionPolicy(state: MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>, value: azurerm.MssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy) : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name> =
            state.assignments.Add(fun config -> config.LongTermRetentionPolicy <- value)
            state : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>

        /// <summary>
        /// point_in_time_restore block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#point_in_time_restore-1">MssqlManagedDatabase#point_in_time_restore</a>
        /// </summary>
        [<CustomOperation "point_in_time_restore">]
        member _.PointInTimeRestore(state: MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>, value: azurerm.MssqlManagedDatabase.MssqlManagedDatabasePointInTimeRestore) : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name> =
            state.assignments.Add(fun config -> config.PointInTimeRestore <- value)
            state : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#short_term_retention_days-1">MssqlManagedDatabase#short_term_retention_days</a>.
        /// </summary>
        [<CustomOperation "short_term_retention_days">]
        member _.ShortTermRetentionDays(state: MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>, value: double) : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name> =
            state.assignments.Add(fun config -> config.ShortTermRetentionDays <- value)
            state : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#timeouts-1">MssqlManagedDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>, value: azurerm.MssqlManagedDatabase.MssqlManagedDatabaseTimeouts) : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlManagedDatabaseState<'ManagedInstanceId, 'Name>

        member _.Run(state: MssqlManagedDatabaseState<Present, Present>) : azurerm.MssqlManagedDatabase.MssqlManagedDatabase =
            let config = azurerm.MssqlManagedDatabase.MssqlManagedDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlManagedDatabase.MssqlManagedDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlManagedDatabase: missing required arguments. Must call: managed_instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: MssqlManagedDatabaseState<_, _>) : azurerm.MssqlManagedDatabase.MssqlManagedDatabase =
            Unchecked.defaultof<azurerm.MssqlManagedDatabase.MssqlManagedDatabase>
