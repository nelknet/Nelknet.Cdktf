namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value> = { assignments: ResizeArray<azurerm.IothubEnrichment.IothubEnrichmentAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment">azurerm_iothub_enrichment</a>.
    /// </summary>
    type IothubEnrichmentABuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubEnrichmentAState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEnrichmentAState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubEnrichmentAState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEnrichmentAState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#endpoint_names-1">IothubEnrichmentA#endpoint_names</a>.
        /// </summary>
        [<CustomOperation "endpoint_names">]
        member _.EndpointNames(state: IothubEnrichmentAState<Missing, 'IothubName, 'Key, 'ResourceGroupName, 'Value>, value: seq<string>) : IothubEnrichmentAState<Present, 'IothubName, 'Key, 'ResourceGroupName, 'Value> =
            state.assignments.Add(fun config -> config.EndpointNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IothubEnrichmentAState<Present, 'IothubName, 'Key, 'ResourceGroupName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#iothub_name-1">IothubEnrichmentA#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: IothubEnrichmentAState<'EndpointNames, Missing, 'Key, 'ResourceGroupName, 'Value>, value: string) : IothubEnrichmentAState<'EndpointNames, Present, 'Key, 'ResourceGroupName, 'Value> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : IothubEnrichmentAState<'EndpointNames, Present, 'Key, 'ResourceGroupName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#key-1">IothubEnrichmentA#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: IothubEnrichmentAState<'EndpointNames, 'IothubName, Missing, 'ResourceGroupName, 'Value>, value: string) : IothubEnrichmentAState<'EndpointNames, 'IothubName, Present, 'ResourceGroupName, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : IothubEnrichmentAState<'EndpointNames, 'IothubName, Present, 'ResourceGroupName, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#resource_group_name-1">IothubEnrichmentA#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, Missing, 'Value>, value: string) : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, Present, 'Value> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#value-1">IothubEnrichmentA#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, Missing>, value: string) : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#id-1">IothubEnrichmentA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value>, value: string) : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_enrichment#timeouts-1">IothubEnrichmentA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value>, value: azurerm.IothubEnrichment.IothubEnrichmentTimeouts) : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubEnrichmentAState<'EndpointNames, 'IothubName, 'Key, 'ResourceGroupName, 'Value>

        member _.Run(state: IothubEnrichmentAState<Present, Present, Present, Present, Present>) : azurerm.IothubEnrichment.IothubEnrichmentA =
            let config = azurerm.IothubEnrichment.IothubEnrichmentAConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubEnrichment.IothubEnrichmentA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubEnrichmentA: missing required arguments. Must call: endpoint_names, iothub_name, key, resource_group_name, value.", 9999, IsError = true)>]
        member _.Run(_: IothubEnrichmentAState<_, _, _, _, _>) : azurerm.IothubEnrichment.IothubEnrichmentA =
            Unchecked.defaultof<azurerm.IothubEnrichment.IothubEnrichmentA>
