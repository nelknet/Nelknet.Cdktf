namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaRoleAssociationState<'Role, 'WorkspaceId> = { assignments: ResizeArray<aws.GrafanaRoleAssociation.GrafanaRoleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association">aws_grafana_role_association</a>.
    /// </summary>
    type GrafanaRoleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaRoleAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaRoleAssociationState<Missing, Missing>)

        member _.Zero(()) : GrafanaRoleAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaRoleAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association#role-1">GrafanaRoleAssociation#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: GrafanaRoleAssociationState<Missing, 'WorkspaceId>, value: string) : GrafanaRoleAssociationState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : GrafanaRoleAssociationState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association#workspace_id-1">GrafanaRoleAssociation#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: GrafanaRoleAssociationState<'Role, Missing>, value: string) : GrafanaRoleAssociationState<'Role, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : GrafanaRoleAssociationState<'Role, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association#group_ids-1">GrafanaRoleAssociation#group_ids</a>.
        /// </summary>
        [<CustomOperation "group_ids">]
        member _.GroupIds(state: GrafanaRoleAssociationState<'Role, 'WorkspaceId>, value: seq<string>) : GrafanaRoleAssociationState<'Role, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.GroupIds <- (value |> Seq.toArray))
            state : GrafanaRoleAssociationState<'Role, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association#id-1">GrafanaRoleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GrafanaRoleAssociationState<'Role, 'WorkspaceId>, value: string) : GrafanaRoleAssociationState<'Role, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GrafanaRoleAssociationState<'Role, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association#timeouts-1">GrafanaRoleAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GrafanaRoleAssociationState<'Role, 'WorkspaceId>, value: aws.GrafanaRoleAssociation.GrafanaRoleAssociationTimeouts) : GrafanaRoleAssociationState<'Role, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GrafanaRoleAssociationState<'Role, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_role_association#user_ids-1">GrafanaRoleAssociation#user_ids</a>.
        /// </summary>
        [<CustomOperation "user_ids">]
        member _.UserIds(state: GrafanaRoleAssociationState<'Role, 'WorkspaceId>, value: seq<string>) : GrafanaRoleAssociationState<'Role, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.UserIds <- (value |> Seq.toArray))
            state : GrafanaRoleAssociationState<'Role, 'WorkspaceId>

        member _.Run(state: GrafanaRoleAssociationState<Present, Present>) : aws.GrafanaRoleAssociation.GrafanaRoleAssociation =
            let config = aws.GrafanaRoleAssociation.GrafanaRoleAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaRoleAssociation.GrafanaRoleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaRoleAssociation: missing required arguments. Must call: role, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: GrafanaRoleAssociationState<_, _>) : aws.GrafanaRoleAssociation.GrafanaRoleAssociation =
            Unchecked.defaultof<aws.GrafanaRoleAssociation.GrafanaRoleAssociation>
