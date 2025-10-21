namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> = { assignments: ResizeArray<azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql">azurerm_stream_analytics_reference_input_mssql</a>.
    /// </summary>
    type StreamAnalyticsReferenceInputMssqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsReferenceInputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsReferenceInputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsReferenceInputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsReferenceInputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#database-1">StreamAnalyticsReferenceInputMssql#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: StreamAnalyticsReferenceInputMssqlState<Missing, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<Present, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Database <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<Present, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#full_snapshot_query-1">StreamAnalyticsReferenceInputMssql#full_snapshot_query</a>.
        /// </summary>
        [<CustomOperation "full_snapshot_query">]
        member _.FullSnapshotQuery(state: StreamAnalyticsReferenceInputMssqlState<'Database, Missing, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, Present, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.FullSnapshotQuery <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, Present, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#name-1">StreamAnalyticsReferenceInputMssql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, Missing, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, Present, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, Present, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#password-1">StreamAnalyticsReferenceInputMssql#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, Missing, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, Present, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, Present, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#refresh_type-1">StreamAnalyticsReferenceInputMssql#refresh_type</a>.
        /// </summary>
        [<CustomOperation "refresh_type">]
        member _.RefreshType(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, Missing, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, Present, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.RefreshType <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, Present, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#resource_group_name-1">StreamAnalyticsReferenceInputMssql#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, Missing, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, Present, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, Present, 'Server, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#server-1">StreamAnalyticsReferenceInputMssql#server</a>.
        /// </summary>
        [<CustomOperation "server">]
        member _.Server(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, Missing, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, Present, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Server <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, Present, 'StreamAnalyticsJobName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#stream_analytics_job_name-1">StreamAnalyticsReferenceInputMssql#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, Missing, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, Present, 'Username> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#username-1">StreamAnalyticsReferenceInputMssql#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#delta_snapshot_query-1">StreamAnalyticsReferenceInputMssql#delta_snapshot_query</a>.
        /// </summary>
        [<CustomOperation "delta_snapshot_query">]
        member _.DeltaSnapshotQuery(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.DeltaSnapshotQuery <- value)
            state : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#id-1">StreamAnalyticsReferenceInputMssql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#refresh_interval_duration-1">StreamAnalyticsReferenceInputMssql#refresh_interval_duration</a>.
        /// </summary>
        [<CustomOperation "refresh_interval_duration">]
        member _.RefreshIntervalDuration(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.RefreshIntervalDuration <- value)
            state : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#table-1">StreamAnalyticsReferenceInputMssql#table</a>.
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: string) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Table <- value)
            state : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_mssql#timeouts-1">StreamAnalyticsReferenceInputMssql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>, value: azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlTimeouts) : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsReferenceInputMssqlState<'Database, 'FullSnapshotQuery, 'Name, 'Password, 'RefreshType, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Username>

        member _.Run(state: StreamAnalyticsReferenceInputMssqlState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssql =
            let config = azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsReferenceInputMssql: missing required arguments. Must call: database, full_snapshot_query, name, password, refresh_type, resource_group_name, server, stream_analytics_job_name, username.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsReferenceInputMssqlState<_, _, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssql =
            Unchecked.defaultof<azurerm.StreamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssql>
