namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RoleManagementPolicyState<'RoleDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.RoleManagementPolicy.RoleManagementPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy">azurerm_role_management_policy</a>.
    /// </summary>
    type RoleManagementPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : RoleManagementPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RoleManagementPolicyState<Missing, Missing>)

        member _.Zero(()) : RoleManagementPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RoleManagementPolicyState<Missing, Missing>)

        /// <summary>
        /// ID of the Azure Role to which this policy is assigned. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#role_definition_id-1">RoleManagementPolicy#role_definition_id</a>
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: RoleManagementPolicyState<Missing, 'Scope>, value: string) : RoleManagementPolicyState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : RoleManagementPolicyState<Present, 'Scope>)

        /// <summary>
        /// The scope of the role to which this policy will apply. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#scope-1">RoleManagementPolicy#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: RoleManagementPolicyState<'RoleDefinitionId, Missing>, value: string) : RoleManagementPolicyState<'RoleDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : RoleManagementPolicyState<'RoleDefinitionId, Present>)

        /// <summary>
        /// activation_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#activation_rules-1">RoleManagementPolicy#activation_rules</a>
        /// </summary>
        [<CustomOperation "activation_rules">]
        member _.ActivationRules(state: RoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: azurerm.RoleManagementPolicy.RoleManagementPolicyActivationRules) : RoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.ActivationRules <- value)
            state : RoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        /// <summary>
        /// active_assignment_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#active_assignment_rules-1">RoleManagementPolicy#active_assignment_rules</a>
        /// </summary>
        [<CustomOperation "active_assignment_rules">]
        member _.ActiveAssignmentRules(state: RoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: azurerm.RoleManagementPolicy.RoleManagementPolicyActiveAssignmentRules) : RoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.ActiveAssignmentRules <- value)
            state : RoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        /// <summary>
        /// eligible_assignment_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#eligible_assignment_rules-1">RoleManagementPolicy#eligible_assignment_rules</a>
        /// </summary>
        [<CustomOperation "eligible_assignment_rules">]
        member _.EligibleAssignmentRules(state: RoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: azurerm.RoleManagementPolicy.RoleManagementPolicyEligibleAssignmentRules) : RoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.EligibleAssignmentRules <- value)
            state : RoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#id-1">RoleManagementPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: string) : RoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        /// <summary>
        /// notification_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#notification_rules-1">RoleManagementPolicy#notification_rules</a>
        /// </summary>
        [<CustomOperation "notification_rules">]
        member _.NotificationRules(state: RoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: azurerm.RoleManagementPolicy.RoleManagementPolicyNotificationRules) : RoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.NotificationRules <- value)
            state : RoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#timeouts-1">RoleManagementPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: azurerm.RoleManagementPolicy.RoleManagementPolicyTimeouts) : RoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        member _.Run(state: RoleManagementPolicyState<Present, Present>) : azurerm.RoleManagementPolicy.RoleManagementPolicy =
            let config = azurerm.RoleManagementPolicy.RoleManagementPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.RoleManagementPolicy.RoleManagementPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.roleManagementPolicy: missing required arguments. Must call: role_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: RoleManagementPolicyState<_, _>) : azurerm.RoleManagementPolicy.RoleManagementPolicy =
            Unchecked.defaultof<azurerm.RoleManagementPolicy.RoleManagementPolicy>
