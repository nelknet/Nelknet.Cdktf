namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql">azurerm_stream_analytics_output_mssql</a>.
    /// </summary>
    type StreamAnalyticsOutputMssqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputMssqlState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#database-1">StreamAnalyticsOutputMssql#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: StreamAnalyticsOutputMssqlState<Missing, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<Present, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Database <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputMssqlState<Present, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#name-1">StreamAnalyticsOutputMssql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputMssqlState<'Database, Missing, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, Present, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputMssqlState<'Database, Present, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#resource_group_name-1">StreamAnalyticsOutputMssql#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, Missing, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, Present, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputMssqlState<'Database, 'Name, Present, 'Server, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#server-1">StreamAnalyticsOutputMssql#server</a>.
        /// </summary>
        [<CustomOperation "server">]
        member _.Server(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, Missing, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, Present, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Server <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, Present, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#stream_analytics_job_name-1">StreamAnalyticsOutputMssql#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, Missing, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, Present, 'Table> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, Present, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#table-1">StreamAnalyticsOutputMssql#table</a>.
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.Table <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#authentication_mode-1">StreamAnalyticsOutputMssql#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#id-1">StreamAnalyticsOutputMssql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#max_batch_count-1">StreamAnalyticsOutputMssql#max_batch_count</a>.
        /// </summary>
        [<CustomOperation "max_batch_count">]
        member _.MaxBatchCount(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: double) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.MaxBatchCount <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#max_writer_count-1">StreamAnalyticsOutputMssql#max_writer_count</a>.
        /// </summary>
        [<CustomOperation "max_writer_count">]
        member _.MaxWriterCount(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: double) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.MaxWriterCount <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#password-1">StreamAnalyticsOutputMssql#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#timeouts-1">StreamAnalyticsOutputMssql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssqlTimeouts) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_mssql#user-1">StreamAnalyticsOutputMssql#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.User <- value)
            state : StreamAnalyticsOutputMssqlState<'Database, 'Name, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table>

        member _.Run(state: StreamAnalyticsOutputMssqlState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssql =
            let config = azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputMssql: missing required arguments. Must call: database, name, resource_group_name, server, stream_analytics_job_name, table.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputMssqlState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssql =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputMssql.StreamAnalyticsOutputMssql>
