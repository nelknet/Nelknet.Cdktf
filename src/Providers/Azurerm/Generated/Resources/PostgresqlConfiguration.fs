namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value> = { assignments: ResizeArray<azurerm.PostgresqlConfiguration.PostgresqlConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration">azurerm_postgresql_configuration</a>.
    /// </summary>
    type PostgresqlConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration#name-1">PostgresqlConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlConfigurationState<Missing, 'ResourceGroupName, 'ServerName, 'Value>, value: string) : PostgresqlConfigurationState<Present, 'ResourceGroupName, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlConfigurationState<Present, 'ResourceGroupName, 'ServerName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration#resource_group_name-1">PostgresqlConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlConfigurationState<'Name, Missing, 'ServerName, 'Value>, value: string) : PostgresqlConfigurationState<'Name, Present, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlConfigurationState<'Name, Present, 'ServerName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration#server_name-1">PostgresqlConfiguration#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: PostgresqlConfigurationState<'Name, 'ResourceGroupName, Missing, 'Value>, value: string) : PostgresqlConfigurationState<'Name, 'ResourceGroupName, Present, 'Value> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : PostgresqlConfigurationState<'Name, 'ResourceGroupName, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration#value-1">PostgresqlConfiguration#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, Missing>, value: string) : PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration#id-1">PostgresqlConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>, value: string) : PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_configuration#timeouts-1">PostgresqlConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>, value: azurerm.PostgresqlConfiguration.PostgresqlConfigurationTimeouts) : PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlConfigurationState<'Name, 'ResourceGroupName, 'ServerName, 'Value>

        member _.Run(state: PostgresqlConfigurationState<Present, Present, Present, Present>) : azurerm.PostgresqlConfiguration.PostgresqlConfiguration =
            let config = azurerm.PostgresqlConfiguration.PostgresqlConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlConfiguration.PostgresqlConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlConfiguration: missing required arguments. Must call: name, resource_group_name, server_name, value.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlConfigurationState<_, _, _, _>) : azurerm.PostgresqlConfiguration.PostgresqlConfiguration =
            Unchecked.defaultof<azurerm.PostgresqlConfiguration.PostgresqlConfiguration>
