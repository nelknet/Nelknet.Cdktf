namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAttestationProviderState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider">azurerm_attestation_provider</a>.
    /// </summary>
    type DataAzurermAttestationProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAttestationProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAttestationProviderState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAttestationProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAttestationProviderState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#name-1">DataAzurermAttestationProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAttestationProviderState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAttestationProviderState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAttestationProviderState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#resource_group_name-1">DataAzurermAttestationProvider#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAttestationProviderState<'Name, Missing>, value: string) : DataAzurermAttestationProviderState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAttestationProviderState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#id-1">DataAzurermAttestationProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAttestationProviderState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAttestationProviderState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAttestationProviderState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#timeouts-1">DataAzurermAttestationProvider#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAttestationProviderState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProviderTimeouts) : DataAzurermAttestationProviderState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAttestationProviderState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAttestationProviderState<Present, Present>) : azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProvider =
            let config = azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProviderConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAttestationProvider: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAttestationProviderState<_, _>) : azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProvider =
            Unchecked.defaultof<azurerm.DataAzurermAttestationProvider.DataAzurermAttestationProvider>
