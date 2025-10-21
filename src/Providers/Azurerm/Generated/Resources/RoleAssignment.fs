namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RoleAssignmentState<'PrincipalId, 'Scope> = { assignments: ResizeArray<azurerm.RoleAssignment.RoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment">azurerm_role_assignment</a>.
    /// </summary>
    type RoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : RoleAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RoleAssignmentState<Missing, Missing>)

        member _.Zero(()) : RoleAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RoleAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#principal_id-1">RoleAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: RoleAssignmentState<Missing, 'Scope>, value: string) : RoleAssignmentState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : RoleAssignmentState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#scope-1">RoleAssignment#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: RoleAssignmentState<'PrincipalId, Missing>, value: string) : RoleAssignmentState<'PrincipalId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : RoleAssignmentState<'PrincipalId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#condition-1">RoleAssignment#condition</a>.
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#condition_version-1">RoleAssignment#condition_version</a>.
        /// </summary>
        [<CustomOperation "condition_version">]
        member _.ConditionVersion(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.ConditionVersion <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#delegated_managed_identity_resource_id-1">RoleAssignment#delegated_managed_identity_resource_id</a>.
        /// </summary>
        [<CustomOperation "delegated_managed_identity_resource_id">]
        member _.DelegatedManagedIdentityResourceId(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.DelegatedManagedIdentityResourceId <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#description-1">RoleAssignment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#id-1">RoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#name-1">RoleAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#principal_type-1">RoleAssignment#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#role_definition_id-1">RoleAssignment#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#role_definition_name-1">RoleAssignment#role_definition_name</a>.
        /// </summary>
        [<CustomOperation "role_definition_name">]
        member _.RoleDefinitionName(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: string) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionName <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#skip_service_principal_aad_check-1">RoleAssignment#skip_service_principal_aad_check</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_service_principal_aad_check">]
        member _.SkipServicePrincipalAadCheck(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: bool) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.SkipServicePrincipalAadCheck <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#skip_service_principal_aad_check-1">RoleAssignment#skip_service_principal_aad_check</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_service_principal_aad_check">]
        member _.SkipServicePrincipalAadCheck(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: HashiCorp.Cdktf.IResolvable) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.SkipServicePrincipalAadCheck <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_assignment#timeouts-1">RoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RoleAssignmentState<'PrincipalId, 'Scope>, value: azurerm.RoleAssignment.RoleAssignmentTimeouts) : RoleAssignmentState<'PrincipalId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RoleAssignmentState<'PrincipalId, 'Scope>

        member _.Run(state: RoleAssignmentState<Present, Present>) : azurerm.RoleAssignment.RoleAssignment =
            let config = azurerm.RoleAssignment.RoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.RoleAssignment.RoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.roleAssignment: missing required arguments. Must call: principal_id, scope.", 9999, IsError = true)>]
        member _.Run(_: RoleAssignmentState<_, _>) : azurerm.RoleAssignment.RoleAssignment =
            Unchecked.defaultof<azurerm.RoleAssignment.RoleAssignment>
