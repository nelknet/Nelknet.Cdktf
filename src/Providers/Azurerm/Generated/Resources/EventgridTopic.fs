namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventgridTopicState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventgridTopic.EventgridTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic">azurerm_eventgrid_topic</a>.
    /// </summary>
    type EventgridTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventgridTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridTopicState<Missing, Missing, Missing>)

        member _.Zero(()) : EventgridTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridTopicState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#location-1">EventgridTopic#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: EventgridTopicState<Missing, 'Name, 'ResourceGroupName>, value: string) : EventgridTopicState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : EventgridTopicState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#name-1">EventgridTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventgridTopicState<'Location, Missing, 'ResourceGroupName>, value: string) : EventgridTopicState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventgridTopicState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#resource_group_name-1">EventgridTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventgridTopicState<'Location, 'Name, Missing>, value: string) : EventgridTopicState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventgridTopicState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#id-1">EventgridTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: string) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#identity-1">EventgridTopic#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridTopic.EventgridTopicIdentity) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#inbound_ip_rule-1">EventgridTopic#inbound_ip_rule</a>. Accepts: azurerm.IResolvable | azurerm.EventgridTopic.EventgridTopicInboundIpRule[]
        /// </summary>
        [<CustomOperation "inbound_ip_rule">]
        member _.InboundIpRule(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InboundIpRule <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// input_mapping_default_values block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#input_mapping_default_values-1">EventgridTopic#input_mapping_default_values</a>
        /// </summary>
        [<CustomOperation "input_mapping_default_values">]
        member _.InputMappingDefaultValues(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridTopic.EventgridTopicInputMappingDefaultValues) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InputMappingDefaultValues <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// input_mapping_fields block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#input_mapping_fields-1">EventgridTopic#input_mapping_fields</a>
        /// </summary>
        [<CustomOperation "input_mapping_fields">]
        member _.InputMappingFields(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridTopic.EventgridTopicInputMappingFields) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InputMappingFields <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#input_schema-1">EventgridTopic#input_schema</a>.
        /// </summary>
        [<CustomOperation "input_schema">]
        member _.InputSchema(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: string) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InputSchema <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#local_auth_enabled-1">EventgridTopic#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: bool) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#local_auth_enabled-1">EventgridTopic#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#public_network_access_enabled-1">EventgridTopic#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: bool) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#public_network_access_enabled-1">EventgridTopic#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#tags-1">EventgridTopic#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#timeouts-1">EventgridTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventgridTopicState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridTopic.EventgridTopicTimeouts) : EventgridTopicState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventgridTopicState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: EventgridTopicState<Present, Present, Present>) : azurerm.EventgridTopic.EventgridTopic =
            let config = azurerm.EventgridTopic.EventgridTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventgridTopic.EventgridTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventgridTopic: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventgridTopicState<_, _, _>) : azurerm.EventgridTopic.EventgridTopic =
            Unchecked.defaultof<azurerm.EventgridTopic.EventgridTopic>
