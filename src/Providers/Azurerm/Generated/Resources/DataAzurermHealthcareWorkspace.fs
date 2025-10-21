namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace">azurerm_healthcare_workspace</a>.
    /// </summary>
    type DataAzurermHealthcareWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermHealthcareWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermHealthcareWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace#name-1">DataAzurermHealthcareWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermHealthcareWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermHealthcareWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace#resource_group_name-1">DataAzurermHealthcareWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermHealthcareWorkspaceState<'Name, Missing>, value: string) : DataAzurermHealthcareWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace#id-1">DataAzurermHealthcareWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_workspace#timeouts-1">DataAzurermHealthcareWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspaceTimeouts) : DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermHealthcareWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermHealthcareWorkspaceState<Present, Present>) : azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspace =
            let config = azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermHealthcareWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermHealthcareWorkspaceState<_, _>) : azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermHealthcareWorkspace.DataAzurermHealthcareWorkspace>
