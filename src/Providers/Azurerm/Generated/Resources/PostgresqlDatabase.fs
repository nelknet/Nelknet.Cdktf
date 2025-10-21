namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> = { assignments: ResizeArray<azurerm.PostgresqlDatabase.PostgresqlDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database">azurerm_postgresql_database</a>.
    /// </summary>
    type PostgresqlDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlDatabaseState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlDatabaseState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlDatabaseState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlDatabaseState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#charset-1">PostgresqlDatabase#charset</a>.
        /// </summary>
        [<CustomOperation "charset">]
        member _.Charset(state: PostgresqlDatabaseState<Missing, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>, value: string) : PostgresqlDatabaseState<Present, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Charset <- value)
            ({ assignments = state.assignments } : PostgresqlDatabaseState<Present, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#collation-1">PostgresqlDatabase#collation</a>.
        /// </summary>
        [<CustomOperation "collation">]
        member _.Collation(state: PostgresqlDatabaseState<'Charset, Missing, 'Name, 'ResourceGroupName, 'ServerName>, value: string) : PostgresqlDatabaseState<'Charset, Present, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Collation <- value)
            ({ assignments = state.assignments } : PostgresqlDatabaseState<'Charset, Present, 'Name, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#name-1">PostgresqlDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlDatabaseState<'Charset, 'Collation, Missing, 'ResourceGroupName, 'ServerName>, value: string) : PostgresqlDatabaseState<'Charset, 'Collation, Present, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlDatabaseState<'Charset, 'Collation, Present, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#resource_group_name-1">PostgresqlDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlDatabaseState<'Charset, 'Collation, 'Name, Missing, 'ServerName>, value: string) : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, Present, 'ServerName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, Present, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#server_name-1">PostgresqlDatabase#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, Missing>, value: string) : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#id-1">PostgresqlDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>, value: string) : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_database#timeouts-1">PostgresqlDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>, value: azurerm.PostgresqlDatabase.PostgresqlDatabaseTimeouts) : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>

        member _.Run(state: PostgresqlDatabaseState<Present, Present, Present, Present, Present>) : azurerm.PostgresqlDatabase.PostgresqlDatabase =
            let config = azurerm.PostgresqlDatabase.PostgresqlDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlDatabase.PostgresqlDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlDatabase: missing required arguments. Must call: charset, collation, name, resource_group_name, server_name.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlDatabaseState<_, _, _, _, _>) : azurerm.PostgresqlDatabase.PostgresqlDatabase =
            Unchecked.defaultof<azurerm.PostgresqlDatabase.PostgresqlDatabase>
