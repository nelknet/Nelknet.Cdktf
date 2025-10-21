namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment">azurerm_pim_eligible_role_assignment</a>.
    /// </summary>
    type PimEligibleRoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : PimEligibleRoleAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PimEligibleRoleAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : PimEligibleRoleAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PimEligibleRoleAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Object ID of the principal for this eligible role assignment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#principal_id-1">PimEligibleRoleAssignment#principal_id</a>
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: PimEligibleRoleAssignmentState<Missing, 'RoleDefinitionId, 'Scope>, value: string) : PimEligibleRoleAssignmentState<Present, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : PimEligibleRoleAssignmentState<Present, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Role definition ID for this eligible role assignment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#role_definition_id-1">PimEligibleRoleAssignment#role_definition_id</a>
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: PimEligibleRoleAssignmentState<'PrincipalId, Missing, 'Scope>, value: string) : PimEligibleRoleAssignmentState<'PrincipalId, Present, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : PimEligibleRoleAssignmentState<'PrincipalId, Present, 'Scope>)

        /// <summary>
        /// Scope for this eligible role assignment, should be a valid resource ID. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#scope-1">PimEligibleRoleAssignment#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, Missing>, value: string) : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#id-1">PimEligibleRoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// The justification for this eligible role assignment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#justification-1">PimEligibleRoleAssignment#justification</a>
        /// </summary>
        [<CustomOperation "justification">]
        member _.Justification(state: PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Justification <- value)
            state : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#schedule-1">PimEligibleRoleAssignment#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule) : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// ticket block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#ticket-1">PimEligibleRoleAssignment#ticket</a>
        /// </summary>
        [<CustomOperation "ticket">]
        member _.Ticket(state: PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket) : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Ticket <- value)
            state : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#timeouts-1">PimEligibleRoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentTimeouts) : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PimEligibleRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        member _.Run(state: PimEligibleRoleAssignmentState<Present, Present, Present>) : azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment =
            let config = azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.pimEligibleRoleAssignment: missing required arguments. Must call: principal_id, role_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: PimEligibleRoleAssignmentState<_, _, _>) : azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment =
            Unchecked.defaultof<azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignment>
