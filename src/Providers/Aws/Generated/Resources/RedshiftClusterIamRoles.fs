namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftClusterIamRolesState<'ClusterIdentifier> = { assignments: ResizeArray<aws.RedshiftClusterIamRoles.RedshiftClusterIamRolesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_iam_roles">aws_redshift_cluster_iam_roles</a>.
    /// </summary>
    type RedshiftClusterIamRolesBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftClusterIamRolesState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftClusterIamRolesState<Missing>)

        member _.Zero(()) : RedshiftClusterIamRolesState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftClusterIamRolesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_iam_roles#cluster_identifier-1">RedshiftClusterIamRoles#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftClusterIamRolesState<Missing>, value: string) : RedshiftClusterIamRolesState<Present> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftClusterIamRolesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_iam_roles#default_iam_role_arn-1">RedshiftClusterIamRoles#default_iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "default_iam_role_arn">]
        member _.DefaultIamRoleArn(state: RedshiftClusterIamRolesState<'ClusterIdentifier>, value: string) : RedshiftClusterIamRolesState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.DefaultIamRoleArn <- value)
            state : RedshiftClusterIamRolesState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_iam_roles#iam_role_arns-1">RedshiftClusterIamRoles#iam_role_arns</a>.
        /// </summary>
        [<CustomOperation "iam_role_arns">]
        member _.IamRoleArns(state: RedshiftClusterIamRolesState<'ClusterIdentifier>, value: seq<string>) : RedshiftClusterIamRolesState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.IamRoleArns <- (value |> Seq.toArray))
            state : RedshiftClusterIamRolesState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_iam_roles#id-1">RedshiftClusterIamRoles#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftClusterIamRolesState<'ClusterIdentifier>, value: string) : RedshiftClusterIamRolesState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftClusterIamRolesState<'ClusterIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_iam_roles#timeouts-1">RedshiftClusterIamRoles#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedshiftClusterIamRolesState<'ClusterIdentifier>, value: aws.RedshiftClusterIamRoles.RedshiftClusterIamRolesTimeouts) : RedshiftClusterIamRolesState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedshiftClusterIamRolesState<'ClusterIdentifier>

        member _.Run(state: RedshiftClusterIamRolesState<Present>) : aws.RedshiftClusterIamRoles.RedshiftClusterIamRoles =
            let config = aws.RedshiftClusterIamRoles.RedshiftClusterIamRolesConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftClusterIamRoles.RedshiftClusterIamRoles(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftClusterIamRoles: missing required arguments. Must call: cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: RedshiftClusterIamRolesState<_>) : aws.RedshiftClusterIamRoles.RedshiftClusterIamRoles =
            Unchecked.defaultof<aws.RedshiftClusterIamRoles.RedshiftClusterIamRoles>
