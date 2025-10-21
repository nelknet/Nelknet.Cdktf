namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse">azurerm_data_factory_linked_service_synapse</a>.
    /// </summary>
    type DataFactoryLinkedServiceSynapseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceSynapseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSynapseState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceSynapseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSynapseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#connection_string-1">DataFactoryLinkedServiceSynapse#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceSynapseState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSynapseState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSynapseState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#data_factory_id-1">DataFactoryLinkedServiceSynapse#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, Missing, 'Name>, value: string) : DataFactoryLinkedServiceSynapseState<'ConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSynapseState<'ConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#name-1">DataFactoryLinkedServiceSynapse#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#additional_properties-1">DataFactoryLinkedServiceSynapse#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#annotations-1">DataFactoryLinkedServiceSynapse#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#description-1">DataFactoryLinkedServiceSynapse#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#id-1">DataFactoryLinkedServiceSynapse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#integration_runtime_name-1">DataFactoryLinkedServiceSynapse#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_password block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#key_vault_password-1">DataFactoryLinkedServiceSynapse#key_vault_password</a>
        /// </summary>
        [<CustomOperation "key_vault_password">]
        member _.KeyVaultPassword(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapseKeyVaultPassword) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultPassword <- value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#parameters-1">DataFactoryLinkedServiceSynapse#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_synapse#timeouts-1">DataFactoryLinkedServiceSynapse#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapseTimeouts) : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceSynapseState<'ConnectionString, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceSynapseState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapse =
            let config = azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceSynapse: missing required arguments. Must call: connection_string, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceSynapseState<_, _, _>) : azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapse =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceSynapse.DataFactoryLinkedServiceSynapse>
