namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventhubSasState<'ConnectionString, 'Expiry> = { assignments: ResizeArray<azurerm.DataAzurermEventhubSas.DataAzurermEventhubSasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_sas">azurerm_eventhub_sas</a>.
    /// </summary>
    type DataAzurermEventhubSasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventhubSasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubSasState<Missing, Missing>)

        member _.Zero(()) : DataAzurermEventhubSasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubSasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_sas#connection_string-1">DataAzurermEventhubSas#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataAzurermEventhubSasState<Missing, 'Expiry>, value: string) : DataAzurermEventhubSasState<Present, 'Expiry> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubSasState<Present, 'Expiry>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_sas#expiry-1">DataAzurermEventhubSas#expiry</a>.
        /// </summary>
        [<CustomOperation "expiry">]
        member _.Expiry(state: DataAzurermEventhubSasState<'ConnectionString, Missing>, value: string) : DataAzurermEventhubSasState<'ConnectionString, Present> =
            state.assignments.Add(fun config -> config.Expiry <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubSasState<'ConnectionString, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_sas#id-1">DataAzurermEventhubSas#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventhubSasState<'ConnectionString, 'Expiry>, value: string) : DataAzurermEventhubSasState<'ConnectionString, 'Expiry> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventhubSasState<'ConnectionString, 'Expiry>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_sas#timeouts-1">DataAzurermEventhubSas#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventhubSasState<'ConnectionString, 'Expiry>, value: azurerm.DataAzurermEventhubSas.DataAzurermEventhubSasTimeouts) : DataAzurermEventhubSasState<'ConnectionString, 'Expiry> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventhubSasState<'ConnectionString, 'Expiry>

        member _.Run(state: DataAzurermEventhubSasState<Present, Present>) : azurerm.DataAzurermEventhubSas.DataAzurermEventhubSas =
            let config = azurerm.DataAzurermEventhubSas.DataAzurermEventhubSasConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventhubSas.DataAzurermEventhubSas(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventhubSas: missing required arguments. Must call: connection_string, expiry.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventhubSasState<_, _>) : azurerm.DataAzurermEventhubSas.DataAzurermEventhubSas =
            Unchecked.defaultof<azurerm.DataAzurermEventhubSas.DataAzurermEventhubSas>
