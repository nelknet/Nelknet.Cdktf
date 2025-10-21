namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.HealthcareWorkspace.HealthcareWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace">azurerm_healthcare_workspace</a>.
    /// </summary>
    type HealthcareWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthcareWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareWorkspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : HealthcareWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareWorkspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace#location-1">HealthcareWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthcareWorkspaceState<Missing, 'Name, 'ResourceGroupName>, value: string) : HealthcareWorkspaceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthcareWorkspaceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace#name-1">HealthcareWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthcareWorkspaceState<'Location, Missing, 'ResourceGroupName>, value: string) : HealthcareWorkspaceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthcareWorkspaceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace#resource_group_name-1">HealthcareWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HealthcareWorkspaceState<'Location, 'Name, Missing>, value: string) : HealthcareWorkspaceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HealthcareWorkspaceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace#id-1">HealthcareWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace#tags-1">HealthcareWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_workspace#timeouts-1">HealthcareWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.HealthcareWorkspace.HealthcareWorkspaceTimeouts) : HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthcareWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: HealthcareWorkspaceState<Present, Present, Present>) : azurerm.HealthcareWorkspace.HealthcareWorkspace =
            let config = azurerm.HealthcareWorkspace.HealthcareWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.HealthcareWorkspace.HealthcareWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthcareWorkspace: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: HealthcareWorkspaceState<_, _, _>) : azurerm.HealthcareWorkspace.HealthcareWorkspace =
            Unchecked.defaultof<azurerm.HealthcareWorkspace.HealthcareWorkspace>
