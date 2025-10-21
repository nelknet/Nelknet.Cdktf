namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsClusterParameterGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsRdsClusterParameterGroup.DataAwsRdsClusterParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_cluster_parameter_group">aws_rds_cluster_parameter_group</a>.
    /// </summary>
    type DataAwsRdsClusterParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsClusterParameterGroupState<Missing>)

        member _.Zero(()) : DataAwsRdsClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsClusterParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_cluster_parameter_group#name-1">DataAwsRdsClusterParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRdsClusterParameterGroupState<Missing>, value: string) : DataAwsRdsClusterParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsRdsClusterParameterGroupState<Present>)

        member _.Run(state: DataAwsRdsClusterParameterGroupState<Present>) : aws.DataAwsRdsClusterParameterGroup.DataAwsRdsClusterParameterGroup =
            let config = aws.DataAwsRdsClusterParameterGroup.DataAwsRdsClusterParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsClusterParameterGroup.DataAwsRdsClusterParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRdsClusterParameterGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRdsClusterParameterGroupState<_>) : aws.DataAwsRdsClusterParameterGroup.DataAwsRdsClusterParameterGroup =
            Unchecked.defaultof<aws.DataAwsRdsClusterParameterGroup.DataAwsRdsClusterParameterGroup>
