namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MarketplaceRoleAssignmentState<'PrincipalId> = { assignments: ResizeArray<azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment">azurerm_marketplace_role_assignment</a>.
    /// </summary>
    type MarketplaceRoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : MarketplaceRoleAssignmentState<Missing> =
            ({ assignments = ResizeArray() } : MarketplaceRoleAssignmentState<Missing>)

        member _.Zero(()) : MarketplaceRoleAssignmentState<Missing> =
            ({ assignments = ResizeArray() } : MarketplaceRoleAssignmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#principal_id-1">MarketplaceRoleAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: MarketplaceRoleAssignmentState<Missing>, value: string) : MarketplaceRoleAssignmentState<Present> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : MarketplaceRoleAssignmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#condition-1">MarketplaceRoleAssignment#condition</a>.
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#condition_version-1">MarketplaceRoleAssignment#condition_version</a>.
        /// </summary>
        [<CustomOperation "condition_version">]
        member _.ConditionVersion(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.ConditionVersion <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#delegated_managed_identity_resource_id-1">MarketplaceRoleAssignment#delegated_managed_identity_resource_id</a>.
        /// </summary>
        [<CustomOperation "delegated_managed_identity_resource_id">]
        member _.DelegatedManagedIdentityResourceId(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.DelegatedManagedIdentityResourceId <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#description-1">MarketplaceRoleAssignment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#id-1">MarketplaceRoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#name-1">MarketplaceRoleAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#role_definition_id-1">MarketplaceRoleAssignment#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#role_definition_name-1">MarketplaceRoleAssignment#role_definition_name</a>.
        /// </summary>
        [<CustomOperation "role_definition_name">]
        member _.RoleDefinitionName(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: string) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.RoleDefinitionName <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#skip_service_principal_aad_check-1">MarketplaceRoleAssignment#skip_service_principal_aad_check</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_service_principal_aad_check">]
        member _.SkipServicePrincipalAadCheck(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: bool) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.SkipServicePrincipalAadCheck <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#skip_service_principal_aad_check-1">MarketplaceRoleAssignment#skip_service_principal_aad_check</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_service_principal_aad_check">]
        member _.SkipServicePrincipalAadCheck(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: HashiCorp.Cdktf.IResolvable) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.SkipServicePrincipalAadCheck <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_role_assignment#timeouts-1">MarketplaceRoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MarketplaceRoleAssignmentState<'PrincipalId>, value: azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignmentTimeouts) : MarketplaceRoleAssignmentState<'PrincipalId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MarketplaceRoleAssignmentState<'PrincipalId>

        member _.Run(state: MarketplaceRoleAssignmentState<Present>) : azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignment =
            let config = azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.marketplaceRoleAssignment: missing required arguments. Must call: principal_id.", 9999, IsError = true)>]
        member _.Run(_: MarketplaceRoleAssignmentState<_>) : azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignment =
            Unchecked.defaultof<azurerm.MarketplaceRoleAssignment.MarketplaceRoleAssignment>
