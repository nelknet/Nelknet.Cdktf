namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbParameterGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsDbParameterGroup.DataAwsDbParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_parameter_group">aws_db_parameter_group</a>.
    /// </summary>
    type DataAwsDbParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDbParameterGroupState<Missing>)

        member _.Zero(()) : DataAwsDbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDbParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_parameter_group#name-1">DataAwsDbParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDbParameterGroupState<Missing>, value: string) : DataAwsDbParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsDbParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_parameter_group#id-1">DataAwsDbParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbParameterGroupState<'Name>, value: string) : DataAwsDbParameterGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbParameterGroupState<'Name>

        member _.Run(state: DataAwsDbParameterGroupState<Present>) : aws.DataAwsDbParameterGroup.DataAwsDbParameterGroup =
            let config = aws.DataAwsDbParameterGroup.DataAwsDbParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbParameterGroup.DataAwsDbParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDbParameterGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDbParameterGroupState<_>) : aws.DataAwsDbParameterGroup.DataAwsDbParameterGroup =
            Unchecked.defaultof<aws.DataAwsDbParameterGroup.DataAwsDbParameterGroup>
