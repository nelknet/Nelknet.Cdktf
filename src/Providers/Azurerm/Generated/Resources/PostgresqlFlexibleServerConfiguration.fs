namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value> = { assignments: ResizeArray<azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_configuration">azurerm_postgresql_flexible_server_configuration</a>.
    /// </summary>
    type PostgresqlFlexibleServerConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlFlexibleServerConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlFlexibleServerConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_configuration#name-1">PostgresqlFlexibleServerConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlFlexibleServerConfigurationState<Missing, 'ServerId, 'Value>, value: string) : PostgresqlFlexibleServerConfigurationState<Present, 'ServerId, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerConfigurationState<Present, 'ServerId, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_configuration#server_id-1">PostgresqlFlexibleServerConfiguration#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: PostgresqlFlexibleServerConfigurationState<'Name, Missing, 'Value>, value: string) : PostgresqlFlexibleServerConfigurationState<'Name, Present, 'Value> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerConfigurationState<'Name, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_configuration#value-1">PostgresqlFlexibleServerConfiguration#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, Missing>, value: string) : PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_configuration#id-1">PostgresqlFlexibleServerConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value>, value: string) : PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_configuration#timeouts-1">PostgresqlFlexibleServerConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value>, value: azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfigurationTimeouts) : PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlFlexibleServerConfigurationState<'Name, 'ServerId, 'Value>

        member _.Run(state: PostgresqlFlexibleServerConfigurationState<Present, Present, Present>) : azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfiguration =
            let config = azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlFlexibleServerConfiguration: missing required arguments. Must call: name, server_id, value.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlFlexibleServerConfigurationState<_, _, _>) : azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfiguration =
            Unchecked.defaultof<azurerm.PostgresqlFlexibleServerConfiguration.PostgresqlFlexibleServerConfiguration>
