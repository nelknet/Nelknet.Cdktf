namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function">azurerm_data_factory_linked_service_azure_function</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureFunctionState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureFunctionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#data_factory_id-1">DataFactoryLinkedServiceAzureFunction#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureFunctionState<Missing, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceAzureFunctionState<Present, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureFunctionState<Present, 'Name, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#name-1">DataFactoryLinkedServiceAzureFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, Missing, 'Url>, value: string) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, Present, 'Url> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#url-1">DataFactoryLinkedServiceAzureFunction#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, Missing>, value: string) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#additional_properties-1">DataFactoryLinkedServiceAzureFunction#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#annotations-1">DataFactoryLinkedServiceAzureFunction#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: seq<string>) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#description-1">DataFactoryLinkedServiceAzureFunction#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#id-1">DataFactoryLinkedServiceAzureFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#integration_runtime_name-1">DataFactoryLinkedServiceAzureFunction#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#key-1">DataFactoryLinkedServiceAzureFunction#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Key <- value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// key_vault_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#key_vault_key-1">DataFactoryLinkedServiceAzureFunction#key_vault_key</a>
        /// </summary>
        [<CustomOperation "key_vault_key">]
        member _.KeyVaultKey(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunctionKeyVaultKey) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.KeyVaultKey <- value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#parameters-1">DataFactoryLinkedServiceAzureFunction#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_function#timeouts-1">DataFactoryLinkedServiceAzureFunction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>, value: azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunctionTimeouts) : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureFunctionState<'DataFactoryId, 'Name, 'Url>

        member _.Run(state: DataFactoryLinkedServiceAzureFunctionState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunction =
            let config = azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunctionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureFunction: missing required arguments. Must call: data_factory_id, name, url.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureFunctionState<_, _, _>) : azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunction =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureFunction.DataFactoryLinkedServiceAzureFunction>
