namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseRoleAssignmentState<'PrincipalId, 'RoleName> = { assignments: ResizeArray<azurerm.SynapseRoleAssignment.SynapseRoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment">azurerm_synapse_role_assignment</a>.
    /// </summary>
    type SynapseRoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseRoleAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseRoleAssignmentState<Missing, Missing>)

        member _.Zero(()) : SynapseRoleAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseRoleAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#principal_id-1">SynapseRoleAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: SynapseRoleAssignmentState<Missing, 'RoleName>, value: string) : SynapseRoleAssignmentState<Present, 'RoleName> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : SynapseRoleAssignmentState<Present, 'RoleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#role_name-1">SynapseRoleAssignment#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: SynapseRoleAssignmentState<'PrincipalId, Missing>, value: string) : SynapseRoleAssignmentState<'PrincipalId, Present> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            ({ assignments = state.assignments } : SynapseRoleAssignmentState<'PrincipalId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#id-1">SynapseRoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseRoleAssignmentState<'PrincipalId, 'RoleName>, value: string) : SynapseRoleAssignmentState<'PrincipalId, 'RoleName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseRoleAssignmentState<'PrincipalId, 'RoleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#principal_type-1">SynapseRoleAssignment#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: SynapseRoleAssignmentState<'PrincipalId, 'RoleName>, value: string) : SynapseRoleAssignmentState<'PrincipalId, 'RoleName> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            state : SynapseRoleAssignmentState<'PrincipalId, 'RoleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#synapse_spark_pool_id-1">SynapseRoleAssignment#synapse_spark_pool_id</a>.
        /// </summary>
        [<CustomOperation "synapse_spark_pool_id">]
        member _.SynapseSparkPoolId(state: SynapseRoleAssignmentState<'PrincipalId, 'RoleName>, value: string) : SynapseRoleAssignmentState<'PrincipalId, 'RoleName> =
            state.assignments.Add(fun config -> config.SynapseSparkPoolId <- value)
            state : SynapseRoleAssignmentState<'PrincipalId, 'RoleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#synapse_workspace_id-1">SynapseRoleAssignment#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseRoleAssignmentState<'PrincipalId, 'RoleName>, value: string) : SynapseRoleAssignmentState<'PrincipalId, 'RoleName> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            state : SynapseRoleAssignmentState<'PrincipalId, 'RoleName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_role_assignment#timeouts-1">SynapseRoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseRoleAssignmentState<'PrincipalId, 'RoleName>, value: azurerm.SynapseRoleAssignment.SynapseRoleAssignmentTimeouts) : SynapseRoleAssignmentState<'PrincipalId, 'RoleName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseRoleAssignmentState<'PrincipalId, 'RoleName>

        member _.Run(state: SynapseRoleAssignmentState<Present, Present>) : azurerm.SynapseRoleAssignment.SynapseRoleAssignment =
            let config = azurerm.SynapseRoleAssignment.SynapseRoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseRoleAssignment.SynapseRoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseRoleAssignment: missing required arguments. Must call: principal_id, role_name.", 9999, IsError = true)>]
        member _.Run(_: SynapseRoleAssignmentState<_, _>) : azurerm.SynapseRoleAssignment.SynapseRoleAssignment =
            Unchecked.defaultof<azurerm.SynapseRoleAssignment.SynapseRoleAssignment>
