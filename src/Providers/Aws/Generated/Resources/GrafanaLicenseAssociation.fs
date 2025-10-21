namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId> = { assignments: ResizeArray<aws.GrafanaLicenseAssociation.GrafanaLicenseAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_license_association">aws_grafana_license_association</a>.
    /// </summary>
    type GrafanaLicenseAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaLicenseAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaLicenseAssociationState<Missing, Missing>)

        member _.Zero(()) : GrafanaLicenseAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaLicenseAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_license_association#license_type-1">GrafanaLicenseAssociation#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: GrafanaLicenseAssociationState<Missing, 'WorkspaceId>, value: string) : GrafanaLicenseAssociationState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            ({ assignments = state.assignments } : GrafanaLicenseAssociationState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_license_association#workspace_id-1">GrafanaLicenseAssociation#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: GrafanaLicenseAssociationState<'LicenseType, Missing>, value: string) : GrafanaLicenseAssociationState<'LicenseType, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : GrafanaLicenseAssociationState<'LicenseType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_license_association#grafana_token-1">GrafanaLicenseAssociation#grafana_token</a>.
        /// </summary>
        [<CustomOperation "grafana_token">]
        member _.GrafanaToken(state: GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId>, value: string) : GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.GrafanaToken <- value)
            state : GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_license_association#id-1">GrafanaLicenseAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId>, value: string) : GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_license_association#timeouts-1">GrafanaLicenseAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId>, value: aws.GrafanaLicenseAssociation.GrafanaLicenseAssociationTimeouts) : GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GrafanaLicenseAssociationState<'LicenseType, 'WorkspaceId>

        member _.Run(state: GrafanaLicenseAssociationState<Present, Present>) : aws.GrafanaLicenseAssociation.GrafanaLicenseAssociation =
            let config = aws.GrafanaLicenseAssociation.GrafanaLicenseAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaLicenseAssociation.GrafanaLicenseAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaLicenseAssociation: missing required arguments. Must call: license_type, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: GrafanaLicenseAssociationState<_, _>) : aws.GrafanaLicenseAssociation.GrafanaLicenseAssociation =
            Unchecked.defaultof<aws.GrafanaLicenseAssociation.GrafanaLicenseAssociation>
