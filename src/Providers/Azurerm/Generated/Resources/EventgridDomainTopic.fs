namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventgridDomainTopic.EventgridDomainTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain_topic">azurerm_eventgrid_domain_topic</a>.
    /// </summary>
    type EventgridDomainTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventgridDomainTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridDomainTopicState<Missing, Missing, Missing>)

        member _.Zero(()) : EventgridDomainTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridDomainTopicState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain_topic#domain_name-1">EventgridDomainTopic#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: EventgridDomainTopicState<Missing, 'Name, 'ResourceGroupName>, value: string) : EventgridDomainTopicState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : EventgridDomainTopicState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain_topic#name-1">EventgridDomainTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventgridDomainTopicState<'DomainName, Missing, 'ResourceGroupName>, value: string) : EventgridDomainTopicState<'DomainName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventgridDomainTopicState<'DomainName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain_topic#resource_group_name-1">EventgridDomainTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventgridDomainTopicState<'DomainName, 'Name, Missing>, value: string) : EventgridDomainTopicState<'DomainName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventgridDomainTopicState<'DomainName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain_topic#id-1">EventgridDomainTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>, value: string) : EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain_topic#timeouts-1">EventgridDomainTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>, value: azurerm.EventgridDomainTopic.EventgridDomainTopicTimeouts) : EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>

        member _.Run(state: EventgridDomainTopicState<Present, Present, Present>) : azurerm.EventgridDomainTopic.EventgridDomainTopic =
            let config = azurerm.EventgridDomainTopic.EventgridDomainTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventgridDomainTopic.EventgridDomainTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventgridDomainTopic: missing required arguments. Must call: domain_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventgridDomainTopicState<_, _, _>) : azurerm.EventgridDomainTopic.EventgridDomainTopic =
            Unchecked.defaultof<azurerm.EventgridDomainTopic.EventgridDomainTopic>
