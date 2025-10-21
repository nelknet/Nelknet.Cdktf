namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventgridDomainState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventgridDomain.EventgridDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain">azurerm_eventgrid_domain</a>.
    /// </summary>
    type EventgridDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventgridDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridDomainState<Missing, Missing, Missing>)

        member _.Zero(()) : EventgridDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridDomainState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#location-1">EventgridDomain#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: EventgridDomainState<Missing, 'Name, 'ResourceGroupName>, value: string) : EventgridDomainState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : EventgridDomainState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#name-1">EventgridDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventgridDomainState<'Location, Missing, 'ResourceGroupName>, value: string) : EventgridDomainState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventgridDomainState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#resource_group_name-1">EventgridDomain#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventgridDomainState<'Location, 'Name, Missing>, value: string) : EventgridDomainState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventgridDomainState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#auto_create_topic_with_first_subscription-1">EventgridDomain#auto_create_topic_with_first_subscription</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_create_topic_with_first_subscription">]
        member _.AutoCreateTopicWithFirstSubscription(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: bool) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoCreateTopicWithFirstSubscription <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#auto_create_topic_with_first_subscription-1">EventgridDomain#auto_create_topic_with_first_subscription</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_create_topic_with_first_subscription">]
        member _.AutoCreateTopicWithFirstSubscription(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoCreateTopicWithFirstSubscription <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#auto_delete_topic_with_last_subscription-1">EventgridDomain#auto_delete_topic_with_last_subscription</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_delete_topic_with_last_subscription">]
        member _.AutoDeleteTopicWithLastSubscription(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: bool) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoDeleteTopicWithLastSubscription <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#auto_delete_topic_with_last_subscription-1">EventgridDomain#auto_delete_topic_with_last_subscription</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_delete_topic_with_last_subscription">]
        member _.AutoDeleteTopicWithLastSubscription(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoDeleteTopicWithLastSubscription <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#id-1">EventgridDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: string) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#identity-1">EventgridDomain#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridDomain.EventgridDomainIdentity) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#inbound_ip_rule-1">EventgridDomain#inbound_ip_rule</a>. Accepts: azurerm.IResolvable | azurerm.EventgridDomain.EventgridDomainInboundIpRule[]
        /// </summary>
        [<CustomOperation "inbound_ip_rule">]
        member _.InboundIpRule(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InboundIpRule <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// input_mapping_default_values block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#input_mapping_default_values-1">EventgridDomain#input_mapping_default_values</a>
        /// </summary>
        [<CustomOperation "input_mapping_default_values">]
        member _.InputMappingDefaultValues(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridDomain.EventgridDomainInputMappingDefaultValues) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InputMappingDefaultValues <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// input_mapping_fields block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#input_mapping_fields-1">EventgridDomain#input_mapping_fields</a>
        /// </summary>
        [<CustomOperation "input_mapping_fields">]
        member _.InputMappingFields(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridDomain.EventgridDomainInputMappingFields) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InputMappingFields <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#input_schema-1">EventgridDomain#input_schema</a>.
        /// </summary>
        [<CustomOperation "input_schema">]
        member _.InputSchema(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: string) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InputSchema <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#local_auth_enabled-1">EventgridDomain#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: bool) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#local_auth_enabled-1">EventgridDomain#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#public_network_access_enabled-1">EventgridDomain#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: bool) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#public_network_access_enabled-1">EventgridDomain#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#tags-1">EventgridDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#timeouts-1">EventgridDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventgridDomainState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.EventgridDomain.EventgridDomainTimeouts) : EventgridDomainState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventgridDomainState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: EventgridDomainState<Present, Present, Present>) : azurerm.EventgridDomain.EventgridDomain =
            let config = azurerm.EventgridDomain.EventgridDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventgridDomain.EventgridDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventgridDomain: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventgridDomainState<_, _, _>) : azurerm.EventgridDomain.EventgridDomain =
            Unchecked.defaultof<azurerm.EventgridDomain.EventgridDomain>
