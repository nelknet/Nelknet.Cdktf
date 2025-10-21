namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMemorydbParameterGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsMemorydbParameterGroup.DataAwsMemorydbParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_parameter_group">aws_memorydb_parameter_group</a>.
    /// </summary>
    type DataAwsMemorydbParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMemorydbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbParameterGroupState<Missing>)

        member _.Zero(()) : DataAwsMemorydbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_parameter_group#name-1">DataAwsMemorydbParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMemorydbParameterGroupState<Missing>, value: string) : DataAwsMemorydbParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMemorydbParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_parameter_group#id-1">DataAwsMemorydbParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMemorydbParameterGroupState<'Name>, value: string) : DataAwsMemorydbParameterGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMemorydbParameterGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_parameter_group#tags-1">DataAwsMemorydbParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMemorydbParameterGroupState<'Name>, value: seq<string * string>) : DataAwsMemorydbParameterGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMemorydbParameterGroupState<'Name>

        member _.Run(state: DataAwsMemorydbParameterGroupState<Present>) : aws.DataAwsMemorydbParameterGroup.DataAwsMemorydbParameterGroup =
            let config = aws.DataAwsMemorydbParameterGroup.DataAwsMemorydbParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMemorydbParameterGroup.DataAwsMemorydbParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMemorydbParameterGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMemorydbParameterGroupState<_>) : aws.DataAwsMemorydbParameterGroup.DataAwsMemorydbParameterGroup =
            Unchecked.defaultof<aws.DataAwsMemorydbParameterGroup.DataAwsMemorydbParameterGroup>
