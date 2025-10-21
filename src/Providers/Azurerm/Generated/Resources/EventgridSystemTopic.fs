namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> = { assignments: ResizeArray<azurerm.EventgridSystemTopic.EventgridSystemTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic">azurerm_eventgrid_system_topic</a>.
    /// </summary>
    type EventgridSystemTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventgridSystemTopicState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridSystemTopicState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventgridSystemTopicState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridSystemTopicState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#location-1">EventgridSystemTopic#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: EventgridSystemTopicState<Missing, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>, value: string) : EventgridSystemTopicState<Present, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicState<Present, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#name-1">EventgridSystemTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventgridSystemTopicState<'Location, Missing, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>, value: string) : EventgridSystemTopicState<'Location, Present, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicState<'Location, Present, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#resource_group_name-1">EventgridSystemTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventgridSystemTopicState<'Location, 'Name, Missing, 'SourceArmResourceId, 'TopicType>, value: string) : EventgridSystemTopicState<'Location, 'Name, Present, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicState<'Location, 'Name, Present, 'SourceArmResourceId, 'TopicType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#source_arm_resource_id-1">EventgridSystemTopic#source_arm_resource_id</a>.
        /// </summary>
        [<CustomOperation "source_arm_resource_id">]
        member _.SourceArmResourceId(state: EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, Missing, 'TopicType>, value: string) : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, Present, 'TopicType> =
            state.assignments.Add(fun config -> config.SourceArmResourceId <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, Present, 'TopicType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#topic_type-1">EventgridSystemTopic#topic_type</a>.
        /// </summary>
        [<CustomOperation "topic_type">]
        member _.TopicType(state: EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, Missing>, value: string) : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, Present> =
            state.assignments.Add(fun config -> config.TopicType <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#id-1">EventgridSystemTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>, value: string) : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#identity-1">EventgridSystemTopic#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>, value: azurerm.EventgridSystemTopic.EventgridSystemTopicIdentity) : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#tags-1">EventgridSystemTopic#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>, value: seq<string * string>) : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic#timeouts-1">EventgridSystemTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>, value: azurerm.EventgridSystemTopic.EventgridSystemTopicTimeouts) : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventgridSystemTopicState<'Location, 'Name, 'ResourceGroupName, 'SourceArmResourceId, 'TopicType>

        member _.Run(state: EventgridSystemTopicState<Present, Present, Present, Present, Present>) : azurerm.EventgridSystemTopic.EventgridSystemTopic =
            let config = azurerm.EventgridSystemTopic.EventgridSystemTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventgridSystemTopic.EventgridSystemTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventgridSystemTopic: missing required arguments. Must call: location, name, resource_group_name, source_arm_resource_id, topic_type.", 9999, IsError = true)>]
        member _.Run(_: EventgridSystemTopicState<_, _, _, _, _>) : azurerm.EventgridSystemTopic.EventgridSystemTopic =
            Unchecked.defaultof<azurerm.EventgridSystemTopic.EventgridSystemTopic>
