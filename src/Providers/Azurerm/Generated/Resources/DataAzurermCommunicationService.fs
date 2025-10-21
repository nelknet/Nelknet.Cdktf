namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCommunicationService.DataAzurermCommunicationServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service">azurerm_communication_service</a>.
    /// </summary>
    type DataAzurermCommunicationServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCommunicationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCommunicationServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCommunicationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCommunicationServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#name-1">DataAzurermCommunicationService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCommunicationServiceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermCommunicationServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCommunicationServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#resource_group_name-1">DataAzurermCommunicationService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCommunicationServiceState<'Name, Missing>, value: string) : DataAzurermCommunicationServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCommunicationServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#id-1">DataAzurermCommunicationService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#timeouts-1">DataAzurermCommunicationService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCommunicationService.DataAzurermCommunicationServiceTimeouts) : DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCommunicationServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCommunicationServiceState<Present, Present>) : azurerm.DataAzurermCommunicationService.DataAzurermCommunicationService =
            let config = azurerm.DataAzurermCommunicationService.DataAzurermCommunicationServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCommunicationService.DataAzurermCommunicationService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCommunicationService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCommunicationServiceState<_, _>) : azurerm.DataAzurermCommunicationService.DataAzurermCommunicationService =
            Unchecked.defaultof<azurerm.DataAzurermCommunicationService.DataAzurermCommunicationService>
