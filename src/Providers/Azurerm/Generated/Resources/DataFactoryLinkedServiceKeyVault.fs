namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault">azurerm_data_factory_linked_service_key_vault</a>.
    /// </summary>
    type DataFactoryLinkedServiceKeyVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceKeyVaultState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceKeyVaultState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceKeyVaultState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceKeyVaultState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#data_factory_id-1">DataFactoryLinkedServiceKeyVault#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceKeyVaultState<Missing, 'KeyVaultId, 'Name>, value: string) : DataFactoryLinkedServiceKeyVaultState<Present, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKeyVaultState<Present, 'KeyVaultId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#key_vault_id-1">DataFactoryLinkedServiceKeyVault#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#name-1">DataFactoryLinkedServiceKeyVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, Missing>, value: string) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#additional_properties-1">DataFactoryLinkedServiceKeyVault#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#annotations-1">DataFactoryLinkedServiceKeyVault#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#description-1">DataFactoryLinkedServiceKeyVault#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: string) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#id-1">DataFactoryLinkedServiceKeyVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: string) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#integration_runtime_name-1">DataFactoryLinkedServiceKeyVault#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: string) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#parameters-1">DataFactoryLinkedServiceKeyVault#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_key_vault#timeouts-1">DataFactoryLinkedServiceKeyVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>, value: azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVaultTimeouts) : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceKeyVaultState<'DataFactoryId, 'KeyVaultId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceKeyVaultState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVault =
            let config = azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceKeyVault: missing required arguments. Must call: data_factory_id, key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceKeyVaultState<_, _, _>) : azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVault =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceKeyVault.DataFactoryLinkedServiceKeyVault>
