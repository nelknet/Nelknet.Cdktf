namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMemorydbSnapshotState<'Name> = { assignments: ResizeArray<aws.DataAwsMemorydbSnapshot.DataAwsMemorydbSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_snapshot">aws_memorydb_snapshot</a>.
    /// </summary>
    type DataAwsMemorydbSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMemorydbSnapshotState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbSnapshotState<Missing>)

        member _.Zero(()) : DataAwsMemorydbSnapshotState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbSnapshotState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_snapshot#name-1">DataAwsMemorydbSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMemorydbSnapshotState<Missing>, value: string) : DataAwsMemorydbSnapshotState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMemorydbSnapshotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_snapshot#id-1">DataAwsMemorydbSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMemorydbSnapshotState<'Name>, value: string) : DataAwsMemorydbSnapshotState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMemorydbSnapshotState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_snapshot#tags-1">DataAwsMemorydbSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMemorydbSnapshotState<'Name>, value: seq<string * string>) : DataAwsMemorydbSnapshotState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMemorydbSnapshotState<'Name>

        member _.Run(state: DataAwsMemorydbSnapshotState<Present>) : aws.DataAwsMemorydbSnapshot.DataAwsMemorydbSnapshot =
            let config = aws.DataAwsMemorydbSnapshot.DataAwsMemorydbSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMemorydbSnapshot.DataAwsMemorydbSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMemorydbSnapshot: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMemorydbSnapshotState<_>) : aws.DataAwsMemorydbSnapshot.DataAwsMemorydbSnapshot =
            Unchecked.defaultof<aws.DataAwsMemorydbSnapshot.DataAwsMemorydbSnapshot>
