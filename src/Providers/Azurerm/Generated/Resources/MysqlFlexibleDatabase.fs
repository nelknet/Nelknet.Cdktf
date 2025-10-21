namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> = { assignments: ResizeArray<azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database">azurerm_mysql_flexible_database</a>.
    /// </summary>
    type MysqlFlexibleDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : MysqlFlexibleDatabaseState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleDatabaseState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MysqlFlexibleDatabaseState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleDatabaseState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#charset-1">MysqlFlexibleDatabase#charset</a>.
        /// </summary>
        [<CustomOperation "charset">]
        member _.Charset(state: MysqlFlexibleDatabaseState<Missing, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>, value: string) : MysqlFlexibleDatabaseState<Present, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Charset <- value)
            ({ assignments = state.assignments } : MysqlFlexibleDatabaseState<Present, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#collation-1">MysqlFlexibleDatabase#collation</a>.
        /// </summary>
        [<CustomOperation "collation">]
        member _.Collation(state: MysqlFlexibleDatabaseState<'Charset, Missing, 'Name, 'ResourceGroupName, 'ServerName>, value: string) : MysqlFlexibleDatabaseState<'Charset, Present, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Collation <- value)
            ({ assignments = state.assignments } : MysqlFlexibleDatabaseState<'Charset, Present, 'Name, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#name-1">MysqlFlexibleDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MysqlFlexibleDatabaseState<'Charset, 'Collation, Missing, 'ResourceGroupName, 'ServerName>, value: string) : MysqlFlexibleDatabaseState<'Charset, 'Collation, Present, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MysqlFlexibleDatabaseState<'Charset, 'Collation, Present, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#resource_group_name-1">MysqlFlexibleDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, Missing, 'ServerName>, value: string) : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, Present, 'ServerName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, Present, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#server_name-1">MysqlFlexibleDatabase#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, Missing>, value: string) : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#id-1">MysqlFlexibleDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>, value: string) : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_database#timeouts-1">MysqlFlexibleDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>, value: azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabaseTimeouts) : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MysqlFlexibleDatabaseState<'Charset, 'Collation, 'Name, 'ResourceGroupName, 'ServerName>

        member _.Run(state: MysqlFlexibleDatabaseState<Present, Present, Present, Present, Present>) : azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabase =
            let config = azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mysqlFlexibleDatabase: missing required arguments. Must call: charset, collation, name, resource_group_name, server_name.", 9999, IsError = true)>]
        member _.Run(_: MysqlFlexibleDatabaseState<_, _, _, _, _>) : azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabase =
            Unchecked.defaultof<azurerm.MysqlFlexibleDatabase.MysqlFlexibleDatabase>
