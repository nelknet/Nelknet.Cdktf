namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database">azurerm_data_factory_linked_service_azure_sql_database</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureSqlDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureSqlDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureSqlDatabaseState<Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureSqlDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureSqlDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#data_factory_id-1">DataFactoryLinkedServiceAzureSqlDatabase#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureSqlDatabaseState<Missing, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureSqlDatabaseState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#name-1">DataFactoryLinkedServiceAzureSqlDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#additional_properties-1">DataFactoryLinkedServiceAzureSqlDatabase#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#annotations-1">DataFactoryLinkedServiceAzureSqlDatabase#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#connection_string-1">DataFactoryLinkedServiceAzureSqlDatabase#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#description-1">DataFactoryLinkedServiceAzureSqlDatabase#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#id-1">DataFactoryLinkedServiceAzureSqlDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#integration_runtime_name-1">DataFactoryLinkedServiceAzureSqlDatabase#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#key_vault_connection_string-1">DataFactoryLinkedServiceAzureSqlDatabase#key_vault_connection_string</a>
        /// </summary>
        [<CustomOperation "key_vault_connection_string">]
        member _.KeyVaultConnectionString(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultConnectionString <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_password block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#key_vault_password-1">DataFactoryLinkedServiceAzureSqlDatabase#key_vault_password</a>
        /// </summary>
        [<CustomOperation "key_vault_password">]
        member _.KeyVaultPassword(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseKeyVaultPassword) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultPassword <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#parameters-1">DataFactoryLinkedServiceAzureSqlDatabase#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#service_principal_id-1">DataFactoryLinkedServiceAzureSqlDatabase#service_principal_id</a>.
        /// </summary>
        [<CustomOperation "service_principal_id">]
        member _.ServicePrincipalId(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalId <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#service_principal_key-1">DataFactoryLinkedServiceAzureSqlDatabase#service_principal_key</a>.
        /// </summary>
        [<CustomOperation "service_principal_key">]
        member _.ServicePrincipalKey(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalKey <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#tenant_id-1">DataFactoryLinkedServiceAzureSqlDatabase#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#timeouts-1">DataFactoryLinkedServiceAzureSqlDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseTimeouts) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#use_managed_identity-1">DataFactoryLinkedServiceAzureSqlDatabase#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: bool) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#use_managed_identity-1">DataFactoryLinkedServiceAzureSqlDatabase#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceAzureSqlDatabaseState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceAzureSqlDatabaseState<Present, Present>) : azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabase =
            let config = azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureSqlDatabase: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureSqlDatabaseState<_, _>) : azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabase =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabase>
