namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment">azurerm_pim_active_role_assignment</a>.
    /// </summary>
    type PimActiveRoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : PimActiveRoleAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PimActiveRoleAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : PimActiveRoleAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PimActiveRoleAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Object ID of the principal for this role assignment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#principal_id-1">PimActiveRoleAssignment#principal_id</a>
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: PimActiveRoleAssignmentState<Missing, 'RoleDefinitionId, 'Scope>, value: string) : PimActiveRoleAssignmentState<Present, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : PimActiveRoleAssignmentState<Present, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Role definition ID for this role assignment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#role_definition_id-1">PimActiveRoleAssignment#role_definition_id</a>
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: PimActiveRoleAssignmentState<'PrincipalId, Missing, 'Scope>, value: string) : PimActiveRoleAssignmentState<'PrincipalId, Present, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : PimActiveRoleAssignmentState<'PrincipalId, Present, 'Scope>)

        /// <summary>
        /// Scope for this role assignment, should be a valid resource ID. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#scope-1">PimActiveRoleAssignment#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, Missing>, value: string) : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#id-1">PimActiveRoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// The justification for this role assignment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#justification-1">PimActiveRoleAssignment#justification</a>
        /// </summary>
        [<CustomOperation "justification">]
        member _.Justification(state: PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Justification <- value)
            state : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#schedule-1">PimActiveRoleAssignment#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentSchedule) : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// ticket block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#ticket-1">PimActiveRoleAssignment#ticket</a>
        /// </summary>
        [<CustomOperation "ticket">]
        member _.Ticket(state: PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentTicket) : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Ticket <- value)
            state : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#timeouts-1">PimActiveRoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentTimeouts) : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PimActiveRoleAssignmentState<'PrincipalId, 'RoleDefinitionId, 'Scope>

        member _.Run(state: PimActiveRoleAssignmentState<Present, Present, Present>) : azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment =
            let config = azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.pimActiveRoleAssignment: missing required arguments. Must call: principal_id, role_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: PimActiveRoleAssignmentState<_, _, _>) : azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment =
            Unchecked.defaultof<azurerm.PimActiveRoleAssignment.PimActiveRoleAssignment>
