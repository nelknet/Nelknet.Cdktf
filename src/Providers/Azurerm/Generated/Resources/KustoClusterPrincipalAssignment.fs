namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> = { assignments: ResizeArray<azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment">azurerm_kusto_cluster_principal_assignment</a>.
    /// </summary>
    type KustoClusterPrincipalAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoClusterPrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterPrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoClusterPrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterPrincipalAssignmentState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#cluster_name-1">KustoClusterPrincipalAssignment#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoClusterPrincipalAssignmentState<Missing, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<Present, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<Present, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#name-1">KustoClusterPrincipalAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoClusterPrincipalAssignmentState<'ClusterName, Missing, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, Present, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<'ClusterName, Present, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#principal_id-1">KustoClusterPrincipalAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, Missing, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, Present, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, Present, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#principal_type-1">KustoClusterPrincipalAssignment#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, Missing, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, Present, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, Present, 'ResourceGroupName, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#resource_group_name-1">KustoClusterPrincipalAssignment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, Missing, 'Role, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, Present, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, Present, 'Role, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#role-1">KustoClusterPrincipalAssignment#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, Missing, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#tenant_id-1">KustoClusterPrincipalAssignment#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, Missing>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#id-1">KustoClusterPrincipalAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: string) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_principal_assignment#timeouts-1">KustoClusterPrincipalAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>, value: azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignmentTimeouts) : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoClusterPrincipalAssignmentState<'ClusterName, 'Name, 'PrincipalId, 'PrincipalType, 'ResourceGroupName, 'Role, 'TenantId>

        member _.Run(state: KustoClusterPrincipalAssignmentState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignment =
            let config = azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoClusterPrincipalAssignment: missing required arguments. Must call: cluster_name, name, principal_id, principal_type, resource_group_name, role, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: KustoClusterPrincipalAssignmentState<_, _, _, _, _, _, _>) : azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignment =
            Unchecked.defaultof<azurerm.KustoClusterPrincipalAssignment.KustoClusterPrincipalAssignment>
