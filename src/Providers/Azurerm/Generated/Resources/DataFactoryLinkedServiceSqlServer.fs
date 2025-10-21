namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server">azurerm_data_factory_linked_service_sql_server</a>.
    /// </summary>
    type DataFactoryLinkedServiceSqlServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceSqlServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSqlServerState<Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceSqlServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSqlServerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#data_factory_id-1">DataFactoryLinkedServiceSqlServer#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceSqlServerState<Missing, 'Name>, value: string) : DataFactoryLinkedServiceSqlServerState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSqlServerState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#name-1">DataFactoryLinkedServiceSqlServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#additional_properties-1">DataFactoryLinkedServiceSqlServer#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#annotations-1">DataFactoryLinkedServiceSqlServer#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#connection_string-1">DataFactoryLinkedServiceSqlServer#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#description-1">DataFactoryLinkedServiceSqlServer#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#id-1">DataFactoryLinkedServiceSqlServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#integration_runtime_name-1">DataFactoryLinkedServiceSqlServer#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#key_vault_connection_string-1">DataFactoryLinkedServiceSqlServer#key_vault_connection_string</a>
        /// </summary>
        [<CustomOperation "key_vault_connection_string">]
        member _.KeyVaultConnectionString(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultConnectionString) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultConnectionString <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_password block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#key_vault_password-1">DataFactoryLinkedServiceSqlServer#key_vault_password</a>
        /// </summary>
        [<CustomOperation "key_vault_password">]
        member _.KeyVaultPassword(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultPassword) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultPassword <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#parameters-1">DataFactoryLinkedServiceSqlServer#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#timeouts-1">DataFactoryLinkedServiceSqlServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerTimeouts) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#user_name-1">DataFactoryLinkedServiceSqlServer#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : DataFactoryLinkedServiceSqlServerState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceSqlServerState<Present, Present>) : azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer =
            let config = azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceSqlServer: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceSqlServerState<_, _>) : azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer>
