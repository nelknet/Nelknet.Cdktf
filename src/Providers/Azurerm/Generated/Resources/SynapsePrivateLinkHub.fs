namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub">azurerm_synapse_private_link_hub</a>.
    /// </summary>
    type SynapsePrivateLinkHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapsePrivateLinkHubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapsePrivateLinkHubState<Missing, Missing, Missing>)

        member _.Zero(()) : SynapsePrivateLinkHubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapsePrivateLinkHubState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub#location-1">SynapsePrivateLinkHub#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SynapsePrivateLinkHubState<Missing, 'Name, 'ResourceGroupName>, value: string) : SynapsePrivateLinkHubState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SynapsePrivateLinkHubState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub#name-1">SynapsePrivateLinkHub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapsePrivateLinkHubState<'Location, Missing, 'ResourceGroupName>, value: string) : SynapsePrivateLinkHubState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapsePrivateLinkHubState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub#resource_group_name-1">SynapsePrivateLinkHub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SynapsePrivateLinkHubState<'Location, 'Name, Missing>, value: string) : SynapsePrivateLinkHubState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SynapsePrivateLinkHubState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub#id-1">SynapsePrivateLinkHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName>, value: string) : SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub#tags-1">SynapsePrivateLinkHub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_private_link_hub#timeouts-1">SynapsePrivateLinkHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHubTimeouts) : SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapsePrivateLinkHubState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: SynapsePrivateLinkHubState<Present, Present, Present>) : azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHub =
            let config = azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHubConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapsePrivateLinkHub: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SynapsePrivateLinkHubState<_, _, _>) : azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHub =
            Unchecked.defaultof<azurerm.SynapsePrivateLinkHub.SynapsePrivateLinkHub>
