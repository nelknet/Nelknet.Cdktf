namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftserverlessCredentialsState<'WorkgroupName> = { assignments: ResizeArray<aws.DataAwsRedshiftserverlessCredentials.DataAwsRedshiftserverlessCredentialsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_credentials">aws_redshiftserverless_credentials</a>.
    /// </summary>
    type DataAwsRedshiftserverlessCredentialsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftserverlessCredentialsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftserverlessCredentialsState<Missing>)

        member _.Zero(()) : DataAwsRedshiftserverlessCredentialsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftserverlessCredentialsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_credentials#workgroup_name-1">DataAwsRedshiftserverlessCredentials#workgroup_name</a>.
        /// </summary>
        [<CustomOperation "workgroup_name">]
        member _.WorkgroupName(state: DataAwsRedshiftserverlessCredentialsState<Missing>, value: string) : DataAwsRedshiftserverlessCredentialsState<Present> =
            state.assignments.Add(fun config -> config.WorkgroupName <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftserverlessCredentialsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_credentials#db_name-1">DataAwsRedshiftserverlessCredentials#db_name</a>.
        /// </summary>
        [<CustomOperation "db_name">]
        member _.DbName(state: DataAwsRedshiftserverlessCredentialsState<'WorkgroupName>, value: string) : DataAwsRedshiftserverlessCredentialsState<'WorkgroupName> =
            state.assignments.Add(fun config -> config.DbName <- value)
            state : DataAwsRedshiftserverlessCredentialsState<'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_credentials#duration_seconds-1">DataAwsRedshiftserverlessCredentials#duration_seconds</a>.
        /// </summary>
        [<CustomOperation "duration_seconds">]
        member _.DurationSeconds(state: DataAwsRedshiftserverlessCredentialsState<'WorkgroupName>, value: double) : DataAwsRedshiftserverlessCredentialsState<'WorkgroupName> =
            state.assignments.Add(fun config -> config.DurationSeconds <- value)
            state : DataAwsRedshiftserverlessCredentialsState<'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_credentials#id-1">DataAwsRedshiftserverlessCredentials#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftserverlessCredentialsState<'WorkgroupName>, value: string) : DataAwsRedshiftserverlessCredentialsState<'WorkgroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftserverlessCredentialsState<'WorkgroupName>

        member _.Run(state: DataAwsRedshiftserverlessCredentialsState<Present>) : aws.DataAwsRedshiftserverlessCredentials.DataAwsRedshiftserverlessCredentials =
            let config = aws.DataAwsRedshiftserverlessCredentials.DataAwsRedshiftserverlessCredentialsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftserverlessCredentials.DataAwsRedshiftserverlessCredentials(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftserverlessCredentials: missing required arguments. Must call: workgroup_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftserverlessCredentialsState<_>) : aws.DataAwsRedshiftserverlessCredentials.DataAwsRedshiftserverlessCredentials =
            Unchecked.defaultof<aws.DataAwsRedshiftserverlessCredentials.DataAwsRedshiftserverlessCredentials>
