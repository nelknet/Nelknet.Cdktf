namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.GraphServicesAccount.GraphServicesAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account">azurerm_graph_services_account</a>.
    /// </summary>
    type GraphServicesAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : GraphServicesAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GraphServicesAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : GraphServicesAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GraphServicesAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account#application_id-1">GraphServicesAccount#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: GraphServicesAccountState<Missing, 'Name, 'ResourceGroupName>, value: string) : GraphServicesAccountState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : GraphServicesAccountState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account#name-1">GraphServicesAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GraphServicesAccountState<'ApplicationId, Missing, 'ResourceGroupName>, value: string) : GraphServicesAccountState<'ApplicationId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GraphServicesAccountState<'ApplicationId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account#resource_group_name-1">GraphServicesAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: GraphServicesAccountState<'ApplicationId, 'Name, Missing>, value: string) : GraphServicesAccountState<'ApplicationId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : GraphServicesAccountState<'ApplicationId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account#id-1">GraphServicesAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName>, value: string) : GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account#tags-1">GraphServicesAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName>, value: seq<string * string>) : GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/graph_services_account#timeouts-1">GraphServicesAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName>, value: azurerm.GraphServicesAccount.GraphServicesAccountTimeouts) : GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GraphServicesAccountState<'ApplicationId, 'Name, 'ResourceGroupName>

        member _.Run(state: GraphServicesAccountState<Present, Present, Present>) : azurerm.GraphServicesAccount.GraphServicesAccount =
            let config = azurerm.GraphServicesAccount.GraphServicesAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.GraphServicesAccount.GraphServicesAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.graphServicesAccount: missing required arguments. Must call: application_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: GraphServicesAccountState<_, _, _>) : azurerm.GraphServicesAccount.GraphServicesAccount =
            Unchecked.defaultof<azurerm.GraphServicesAccount.GraphServicesAccount>
