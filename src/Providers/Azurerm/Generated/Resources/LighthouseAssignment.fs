namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.LighthouseAssignment.LighthouseAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_assignment">azurerm_lighthouse_assignment</a>.
    /// </summary>
    type LighthouseAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LighthouseAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LighthouseAssignmentState<Missing, Missing>)

        member _.Zero(()) : LighthouseAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LighthouseAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_assignment#lighthouse_definition_id-1">LighthouseAssignment#lighthouse_definition_id</a>.
        /// </summary>
        [<CustomOperation "lighthouse_definition_id">]
        member _.LighthouseDefinitionId(state: LighthouseAssignmentState<Missing, 'Scope>, value: string) : LighthouseAssignmentState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.LighthouseDefinitionId <- value)
            ({ assignments = state.assignments } : LighthouseAssignmentState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_assignment#scope-1">LighthouseAssignment#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: LighthouseAssignmentState<'LighthouseDefinitionId, Missing>, value: string) : LighthouseAssignmentState<'LighthouseDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : LighthouseAssignmentState<'LighthouseDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_assignment#id-1">LighthouseAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope>, value: string) : LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_assignment#name-1">LighthouseAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope>, value: string) : LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_assignment#timeouts-1">LighthouseAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope>, value: azurerm.LighthouseAssignment.LighthouseAssignmentTimeouts) : LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LighthouseAssignmentState<'LighthouseDefinitionId, 'Scope>

        member _.Run(state: LighthouseAssignmentState<Present, Present>) : azurerm.LighthouseAssignment.LighthouseAssignment =
            let config = azurerm.LighthouseAssignment.LighthouseAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.LighthouseAssignment.LighthouseAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lighthouseAssignment: missing required arguments. Must call: lighthouse_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: LighthouseAssignmentState<_, _>) : azurerm.LighthouseAssignment.LighthouseAssignment =
            Unchecked.defaultof<azurerm.LighthouseAssignment.LighthouseAssignment>
