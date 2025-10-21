namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> = { assignments: ResizeArray<aws.DataAwsRedshiftClusterCredentials.DataAwsRedshiftClusterCredentialsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials">aws_redshift_cluster_credentials</a>.
    /// </summary>
    type DataAwsRedshiftClusterCredentialsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftClusterCredentialsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftClusterCredentialsState<Missing, Missing>)

        member _.Zero(()) : DataAwsRedshiftClusterCredentialsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftClusterCredentialsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#cluster_identifier-1">DataAwsRedshiftClusterCredentials#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: DataAwsRedshiftClusterCredentialsState<Missing, 'DbUser>, value: string) : DataAwsRedshiftClusterCredentialsState<Present, 'DbUser> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftClusterCredentialsState<Present, 'DbUser>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#db_user-1">DataAwsRedshiftClusterCredentials#db_user</a>.
        /// </summary>
        [<CustomOperation "db_user">]
        member _.DbUser(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, Missing>, value: string) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.DbUser <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#auto_create-1">DataAwsRedshiftClusterCredentials#auto_create</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_create">]
        member _.AutoCreate(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>, value: bool) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> =
            state.assignments.Add(fun config -> config.AutoCreate <- value)
            state : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#auto_create-1">DataAwsRedshiftClusterCredentials#auto_create</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_create">]
        member _.AutoCreate(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> =
            state.assignments.Add(fun config -> config.AutoCreate <- value)
            state : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#db_groups-1">DataAwsRedshiftClusterCredentials#db_groups</a>.
        /// </summary>
        [<CustomOperation "db_groups">]
        member _.DbGroups(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>, value: seq<string>) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> =
            state.assignments.Add(fun config -> config.DbGroups <- (value |> Seq.toArray))
            state : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#db_name-1">DataAwsRedshiftClusterCredentials#db_name</a>.
        /// </summary>
        [<CustomOperation "db_name">]
        member _.DbName(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>, value: string) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> =
            state.assignments.Add(fun config -> config.DbName <- value)
            state : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#duration_seconds-1">DataAwsRedshiftClusterCredentials#duration_seconds</a>.
        /// </summary>
        [<CustomOperation "duration_seconds">]
        member _.DurationSeconds(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>, value: double) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> =
            state.assignments.Add(fun config -> config.DurationSeconds <- value)
            state : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster_credentials#id-1">DataAwsRedshiftClusterCredentials#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>, value: string) : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftClusterCredentialsState<'ClusterIdentifier, 'DbUser>

        member _.Run(state: DataAwsRedshiftClusterCredentialsState<Present, Present>) : aws.DataAwsRedshiftClusterCredentials.DataAwsRedshiftClusterCredentials =
            let config = aws.DataAwsRedshiftClusterCredentials.DataAwsRedshiftClusterCredentialsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftClusterCredentials.DataAwsRedshiftClusterCredentials(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftClusterCredentials: missing required arguments. Must call: cluster_identifier, db_user.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftClusterCredentialsState<_, _>) : aws.DataAwsRedshiftClusterCredentials.DataAwsRedshiftClusterCredentials =
            Unchecked.defaultof<aws.DataAwsRedshiftClusterCredentials.DataAwsRedshiftClusterCredentials>
