namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EmailCommunicationService.EmailCommunicationServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service">azurerm_email_communication_service</a>.
    /// </summary>
    type EmailCommunicationServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmailCommunicationServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmailCommunicationServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : EmailCommunicationServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmailCommunicationServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service#data_location-1">EmailCommunicationService#data_location</a>.
        /// </summary>
        [<CustomOperation "data_location">]
        member _.DataLocation(state: EmailCommunicationServiceState<Missing, 'Name, 'ResourceGroupName>, value: string) : EmailCommunicationServiceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataLocation <- value)
            ({ assignments = state.assignments } : EmailCommunicationServiceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service#name-1">EmailCommunicationService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmailCommunicationServiceState<'DataLocation, Missing, 'ResourceGroupName>, value: string) : EmailCommunicationServiceState<'DataLocation, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmailCommunicationServiceState<'DataLocation, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service#resource_group_name-1">EmailCommunicationService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EmailCommunicationServiceState<'DataLocation, 'Name, Missing>, value: string) : EmailCommunicationServiceState<'DataLocation, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EmailCommunicationServiceState<'DataLocation, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service#id-1">EmailCommunicationService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName>, value: string) : EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service#tags-1">EmailCommunicationService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName>, value: seq<string * string>) : EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service#timeouts-1">EmailCommunicationService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName>, value: azurerm.EmailCommunicationService.EmailCommunicationServiceTimeouts) : EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EmailCommunicationServiceState<'DataLocation, 'Name, 'ResourceGroupName>

        member _.Run(state: EmailCommunicationServiceState<Present, Present, Present>) : azurerm.EmailCommunicationService.EmailCommunicationService =
            let config = azurerm.EmailCommunicationService.EmailCommunicationServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.EmailCommunicationService.EmailCommunicationService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.emailCommunicationService: missing required arguments. Must call: data_location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EmailCommunicationServiceState<_, _, _>) : azurerm.EmailCommunicationService.EmailCommunicationService =
            Unchecked.defaultof<azurerm.EmailCommunicationService.EmailCommunicationService>
