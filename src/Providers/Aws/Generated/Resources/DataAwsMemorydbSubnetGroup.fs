namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMemorydbSubnetGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsMemorydbSubnetGroup.DataAwsMemorydbSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_subnet_group">aws_memorydb_subnet_group</a>.
    /// </summary>
    type DataAwsMemorydbSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMemorydbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbSubnetGroupState<Missing>)

        member _.Zero(()) : DataAwsMemorydbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_subnet_group#name-1">DataAwsMemorydbSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMemorydbSubnetGroupState<Missing>, value: string) : DataAwsMemorydbSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMemorydbSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_subnet_group#id-1">DataAwsMemorydbSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMemorydbSubnetGroupState<'Name>, value: string) : DataAwsMemorydbSubnetGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMemorydbSubnetGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_subnet_group#tags-1">DataAwsMemorydbSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMemorydbSubnetGroupState<'Name>, value: seq<string * string>) : DataAwsMemorydbSubnetGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMemorydbSubnetGroupState<'Name>

        member _.Run(state: DataAwsMemorydbSubnetGroupState<Present>) : aws.DataAwsMemorydbSubnetGroup.DataAwsMemorydbSubnetGroup =
            let config = aws.DataAwsMemorydbSubnetGroup.DataAwsMemorydbSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMemorydbSubnetGroup.DataAwsMemorydbSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMemorydbSubnetGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMemorydbSubnetGroupState<_>) : aws.DataAwsMemorydbSubnetGroup.DataAwsMemorydbSubnetGroup =
            Unchecked.defaultof<aws.DataAwsMemorydbSubnetGroup.DataAwsMemorydbSubnetGroup>
