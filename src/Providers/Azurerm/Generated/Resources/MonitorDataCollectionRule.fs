namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule">azurerm_monitor_data_collection_rule</a>.
    /// </summary>
    type MonitorDataCollectionRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorDataCollectionRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorDataCollectionRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorDataCollectionRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorDataCollectionRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// data_flow block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#data_flow-1">MonitorDataCollectionRule#data_flow</a> Accepts: azurerm.IResolvable | azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataFlow[]
        /// </summary>
        [<CustomOperation "data_flow">]
        member _.DataFlow(state: MonitorDataCollectionRuleState<Missing, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MonitorDataCollectionRuleState<Present, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataFlow <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionRuleState<Present, 'Destinations, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// destinations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#destinations-1">MonitorDataCollectionRule#destinations</a>
        /// </summary>
        [<CustomOperation "destinations">]
        member _.Destinations(state: MonitorDataCollectionRuleState<'DataFlow, Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinations) : MonitorDataCollectionRuleState<'DataFlow, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Destinations <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionRuleState<'DataFlow, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#location-1">MonitorDataCollectionRule#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, Missing, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name-1">MonitorDataCollectionRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, Missing, 'ResourceGroupName>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#resource_group_name-1">MonitorDataCollectionRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, Missing>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#data_collection_endpoint_id-1">MonitorDataCollectionRule#data_collection_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "data_collection_endpoint_id">]
        member _.DataCollectionEndpointId(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataCollectionEndpointId <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// data_sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#data_sources-1">MonitorDataCollectionRule#data_sources</a>
        /// </summary>
        [<CustomOperation "data_sources">]
        member _.DataSources(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSources) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataSources <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#description-1">MonitorDataCollectionRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#id-1">MonitorDataCollectionRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#identity-1">MonitorDataCollectionRule#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleIdentity) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#kind-1">MonitorDataCollectionRule#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// stream_declaration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#stream_declaration-1">MonitorDataCollectionRule#stream_declaration</a> Accepts: azurerm.IResolvable | azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleStreamDeclaration[]
        /// </summary>
        [<CustomOperation "stream_declaration">]
        member _.StreamDeclaration(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StreamDeclaration <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#tags-1">MonitorDataCollectionRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#timeouts-1">MonitorDataCollectionRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleTimeouts) : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorDataCollectionRuleState<'DataFlow, 'Destinations, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: MonitorDataCollectionRuleState<Present, Present, Present, Present, Present>) : azurerm.MonitorDataCollectionRule.MonitorDataCollectionRule =
            let config = azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorDataCollectionRule.MonitorDataCollectionRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorDataCollectionRule: missing required arguments. Must call: data_flow, destinations, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorDataCollectionRuleState<_, _, _, _, _>) : azurerm.MonitorDataCollectionRule.MonitorDataCollectionRule =
            Unchecked.defaultof<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRule>
