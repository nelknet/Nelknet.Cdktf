namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ManagedApplication.ManagedApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application">azurerm_managed_application</a>.
    /// </summary>
    type ManagedApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagedApplicationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedApplicationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ManagedApplicationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedApplicationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#kind-1">ManagedApplication#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: ManagedApplicationState<Missing, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationState<Present, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            ({ assignments = state.assignments } : ManagedApplicationState<Present, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#location-1">ManagedApplication#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ManagedApplicationState<'Kind, Missing, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationState<'Kind, Present, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ManagedApplicationState<'Kind, Present, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#managed_resource_group_name-1">ManagedApplication#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: ManagedApplicationState<'Kind, 'Location, Missing, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationState<'Kind, 'Location, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            ({ assignments = state.assignments } : ManagedApplicationState<'Kind, 'Location, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#name-1">ManagedApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, Missing, 'ResourceGroupName>, value: string) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#resource_group_name-1">ManagedApplication#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, Missing>, value: string) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#application_definition_id-1">ManagedApplication#application_definition_id</a>.
        /// </summary>
        [<CustomOperation "application_definition_id">]
        member _.ApplicationDefinitionId(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationDefinitionId <- value)
            state : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#id-1">ManagedApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#parameter_values-1">ManagedApplication#parameter_values</a>.
        /// </summary>
        [<CustomOperation "parameter_values">]
        member _.ParameterValues(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ParameterValues <- value)
            state : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#plan-1">ManagedApplication#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: azurerm.ManagedApplication.ManagedApplicationPlan) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#tags-1">ManagedApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application#timeouts-1">ManagedApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>, value: azurerm.ManagedApplication.ManagedApplicationTimeouts) : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagedApplicationState<'Kind, 'Location, 'ManagedResourceGroupName, 'Name, 'ResourceGroupName>

        member _.Run(state: ManagedApplicationState<Present, Present, Present, Present, Present>) : azurerm.ManagedApplication.ManagedApplication =
            let config = azurerm.ManagedApplication.ManagedApplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagedApplication.ManagedApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managedApplication: missing required arguments. Must call: kind, location, managed_resource_group_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ManagedApplicationState<_, _, _, _, _>) : azurerm.ManagedApplication.ManagedApplication =
            Unchecked.defaultof<azurerm.ManagedApplication.ManagedApplication>
