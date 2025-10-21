namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflakeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake">azurerm_data_factory_linked_service_snowflake</a>.
    /// </summary>
    type DataFactoryLinkedServiceSnowflakeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceSnowflakeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSnowflakeState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceSnowflakeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSnowflakeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#connection_string-1">DataFactoryLinkedServiceSnowflake#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceSnowflakeState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSnowflakeState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSnowflakeState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#data_factory_id-1">DataFactoryLinkedServiceSnowflake#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, Missing, 'Name>, value: string) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#name-1">DataFactoryLinkedServiceSnowflake#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#additional_properties-1">DataFactoryLinkedServiceSnowflake#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#annotations-1">DataFactoryLinkedServiceSnowflake#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#description-1">DataFactoryLinkedServiceSnowflake#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#id-1">DataFactoryLinkedServiceSnowflake#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#integration_runtime_name-1">DataFactoryLinkedServiceSnowflake#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_password block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#key_vault_password-1">DataFactoryLinkedServiceSnowflake#key_vault_password</a>
        /// </summary>
        [<CustomOperation "key_vault_password">]
        member _.KeyVaultPassword(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflakeKeyVaultPassword) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultPassword <- value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#parameters-1">DataFactoryLinkedServiceSnowflake#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_snowflake#timeouts-1">DataFactoryLinkedServiceSnowflake#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflakeTimeouts) : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceSnowflakeState<'ConnectionString, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceSnowflakeState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflake =
            let config = azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflakeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflake(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceSnowflake: missing required arguments. Must call: connection_string, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceSnowflakeState<_, _, _>) : azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflake =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceSnowflake.DataFactoryLinkedServiceSnowflake>
