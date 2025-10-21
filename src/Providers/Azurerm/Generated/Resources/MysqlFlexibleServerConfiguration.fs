namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value> = { assignments: ResizeArray<azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration">azurerm_mysql_flexible_server_configuration</a>.
    /// </summary>
    type MysqlFlexibleServerConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MysqlFlexibleServerConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MysqlFlexibleServerConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration#name-1">MysqlFlexibleServerConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MysqlFlexibleServerConfigurationState<Missing, 'ResourceGroupName, 'ServerName, 'Value>, value: string) : MysqlFlexibleServerConfigurationState<Present, 'ResourceGroupName, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerConfigurationState<Present, 'ResourceGroupName, 'ServerName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration#resource_group_name-1">MysqlFlexibleServerConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MysqlFlexibleServerConfigurationState<'Name, Missing, 'ServerName, 'Value>, value: string) : MysqlFlexibleServerConfigurationState<'Name, Present, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerConfigurationState<'Name, Present, 'ServerName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration#server_name-1">MysqlFlexibleServerConfiguration#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, Missing, 'Value>, value: string) : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, Present, 'Value> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration#value-1">MysqlFlexibleServerConfiguration#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, Missing>, value: string) : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration#id-1">MysqlFlexibleServerConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>, value: string) : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_configuration#timeouts-1">MysqlFlexibleServerConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>, value: azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfigurationTimeouts) : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MysqlFlexibleServerConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>

        member _.Run(state: MysqlFlexibleServerConfigurationState<Present, Present, Present, Present>) : azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfiguration =
            let config = azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mysqlFlexibleServerConfiguration: missing required arguments. Must call: name, resource_group_name, server_name, value.", 9999, IsError = true)>]
        member _.Run(_: MysqlFlexibleServerConfigurationState<_, _, _, _>) : azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfiguration =
            Unchecked.defaultof<azurerm.MysqlFlexibleServerConfiguration.MysqlFlexibleServerConfiguration>
