namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CommunicationServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CommunicationService.CommunicationServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service">azurerm_communication_service</a>.
    /// </summary>
    type CommunicationServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : CommunicationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CommunicationServiceState<Missing, Missing>)

        member _.Zero(()) : CommunicationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CommunicationServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service#name-1">CommunicationService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CommunicationServiceState<Missing, 'ResourceGroupName>, value: string) : CommunicationServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CommunicationServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service#resource_group_name-1">CommunicationService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CommunicationServiceState<'Name, Missing>, value: string) : CommunicationServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CommunicationServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service#data_location-1">CommunicationService#data_location</a>.
        /// </summary>
        [<CustomOperation "data_location">]
        member _.DataLocation(state: CommunicationServiceState<'Name, 'ResourceGroupName>, value: string) : CommunicationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataLocation <- value)
            state : CommunicationServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service#id-1">CommunicationService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CommunicationServiceState<'Name, 'ResourceGroupName>, value: string) : CommunicationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CommunicationServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service#tags-1">CommunicationService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CommunicationServiceState<'Name, 'ResourceGroupName>, value: seq<string * string>) : CommunicationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CommunicationServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service#timeouts-1">CommunicationService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CommunicationServiceState<'Name, 'ResourceGroupName>, value: azurerm.CommunicationService.CommunicationServiceTimeouts) : CommunicationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CommunicationServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: CommunicationServiceState<Present, Present>) : azurerm.CommunicationService.CommunicationService =
            let config = azurerm.CommunicationService.CommunicationServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.CommunicationService.CommunicationService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.communicationService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CommunicationServiceState<_, _>) : azurerm.CommunicationService.CommunicationService =
            Unchecked.defaultof<azurerm.CommunicationService.CommunicationService>
