namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> = { assignments: ResizeArray<azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment">azurerm_kusto_database_principal_assignment</a>.
    /// </summary>
    type KustoDatabasePrincipalAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoDatabasePrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoDatabasePrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoDatabasePrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoDatabasePrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#cluster_name-1">KustoDatabasePrincipalAssignment#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoDatabasePrincipalAssignmentState<Missing, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<Present, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<Present, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#database_name-1">KustoDatabasePrincipalAssignment#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: KustoDatabasePrincipalAssignmentState<'ClusterName, Missing, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, Present, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, Present, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#name-1">KustoDatabasePrincipalAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, Missing, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, Present, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, Present, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#principal_id-1">KustoDatabasePrincipalAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, Missing, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, Present, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, Present, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#principal_type-1">KustoDatabasePrincipalAssignment#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, Missing, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, Present, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, Present, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#resource_group_name-1">KustoDatabasePrincipalAssignment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, Missing, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, Present, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, Present, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#role-1">KustoDatabasePrincipalAssignment#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, Missing, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#tenant_id-1">KustoDatabasePrincipalAssignment#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, Missing>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#id-1">KustoDatabasePrincipalAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database_principal_assignment#timeouts-1">KustoDatabasePrincipalAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignmentTimeouts) : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoDatabasePrincipalAssignmentState<'ClusterName, 'DatabaseName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>

        member _.Run(state: KustoDatabasePrincipalAssignmentState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignment =
            let config = azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoDatabasePrincipalAssignment: missing required arguments. Must call: cluster_name, database_name, name, principal_id, principal_type, resource_group_name, role, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: KustoDatabasePrincipalAssignmentState<_, _, _, _, _, _, _, _>) : azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignment =
            Unchecked.defaultof<azurerm.KustoDatabasePrincipalAssignment.KustoDatabasePrincipalAssignment>
