namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks">azurerm_data_factory_linked_service_azure_databricks</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureDatabricksBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureDatabricksState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureDatabricksState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureDatabricksState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureDatabricksState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#adb_domain-1">DataFactoryLinkedServiceAzureDatabricks#adb_domain</a>.
        /// </summary>
        [<CustomOperation "adb_domain">]
        member _.AdbDomain(state: DataFactoryLinkedServiceAzureDatabricksState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdbDomain <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureDatabricksState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#data_factory_id-1">DataFactoryLinkedServiceAzureDatabricks#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, Missing, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#name-1">DataFactoryLinkedServiceAzureDatabricks#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#access_token-1">DataFactoryLinkedServiceAzureDatabricks#access_token</a>.
        /// </summary>
        [<CustomOperation "access_token">]
        member _.AccessToken(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AccessToken <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#additional_properties-1">DataFactoryLinkedServiceAzureDatabricks#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#annotations-1">DataFactoryLinkedServiceAzureDatabricks#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#description-1">DataFactoryLinkedServiceAzureDatabricks#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#existing_cluster_id-1">DataFactoryLinkedServiceAzureDatabricks#existing_cluster_id</a>.
        /// </summary>
        [<CustomOperation "existing_cluster_id">]
        member _.ExistingClusterId(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ExistingClusterId <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#id-1">DataFactoryLinkedServiceAzureDatabricks#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// instance_pool block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#instance_pool-1">DataFactoryLinkedServiceAzureDatabricks#instance_pool</a>
        /// </summary>
        [<CustomOperation "instance_pool">]
        member _.InstancePool(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksInstancePool) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.InstancePool <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#integration_runtime_name-1">DataFactoryLinkedServiceAzureDatabricks#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_password block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#key_vault_password-1">DataFactoryLinkedServiceAzureDatabricks#key_vault_password</a>
        /// </summary>
        [<CustomOperation "key_vault_password">]
        member _.KeyVaultPassword(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksKeyVaultPassword) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultPassword <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#msi_work_space_resource_id-1">DataFactoryLinkedServiceAzureDatabricks#msi_work_space_resource_id</a>.
        /// </summary>
        [<CustomOperation "msi_work_space_resource_id">]
        member _.MsiWorkSpaceResourceId(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.MsiWorkSpaceResourceId <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// new_cluster_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#new_cluster_config-1">DataFactoryLinkedServiceAzureDatabricks#new_cluster_config</a>
        /// </summary>
        [<CustomOperation "new_cluster_config">]
        member _.NewClusterConfig(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksNewClusterConfig) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.NewClusterConfig <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#parameters-1">DataFactoryLinkedServiceAzureDatabricks#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#timeouts-1">DataFactoryLinkedServiceAzureDatabricks#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksTimeouts) : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureDatabricksState<'AdbDomain, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceAzureDatabricksState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricks =
            let config = azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricks(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureDatabricks: missing required arguments. Must call: adb_domain, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureDatabricksState<_, _, _>) : azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricks =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricks>
