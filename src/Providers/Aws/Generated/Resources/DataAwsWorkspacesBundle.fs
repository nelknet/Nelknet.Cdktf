namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWorkspacesBundleState = { assignments: ResizeArray<aws.DataAwsWorkspacesBundle.DataAwsWorkspacesBundleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_bundle">aws_workspaces_bundle</a>.
    /// </summary>
    type DataAwsWorkspacesBundleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWorkspacesBundleState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsWorkspacesBundleState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_bundle#bundle_id-1">DataAwsWorkspacesBundle#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: DataAwsWorkspacesBundleState, value: string) : DataAwsWorkspacesBundleState =
            state.assignments.Add(fun config -> config.BundleId <- value)
            state : DataAwsWorkspacesBundleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_bundle#id-1">DataAwsWorkspacesBundle#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWorkspacesBundleState, value: string) : DataAwsWorkspacesBundleState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWorkspacesBundleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_bundle#name-1">DataAwsWorkspacesBundle#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWorkspacesBundleState, value: string) : DataAwsWorkspacesBundleState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsWorkspacesBundleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_bundle#owner-1">DataAwsWorkspacesBundle#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: DataAwsWorkspacesBundleState, value: string) : DataAwsWorkspacesBundleState =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : DataAwsWorkspacesBundleState

        member _.Run(state: DataAwsWorkspacesBundleState) : aws.DataAwsWorkspacesBundle.DataAwsWorkspacesBundle =
            let config = aws.DataAwsWorkspacesBundle.DataAwsWorkspacesBundleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWorkspacesBundle.DataAwsWorkspacesBundle(StackContext.get (), logicalId, config)
