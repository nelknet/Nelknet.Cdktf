namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMemorydbClusterState<'Name> = { assignments: ResizeArray<aws.DataAwsMemorydbCluster.DataAwsMemorydbClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_cluster">aws_memorydb_cluster</a>.
    /// </summary>
    type DataAwsMemorydbClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMemorydbClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbClusterState<Missing>)

        member _.Zero(()) : DataAwsMemorydbClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_cluster#name-1">DataAwsMemorydbCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMemorydbClusterState<Missing>, value: string) : DataAwsMemorydbClusterState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMemorydbClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_cluster#id-1">DataAwsMemorydbCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMemorydbClusterState<'Name>, value: string) : DataAwsMemorydbClusterState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMemorydbClusterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_cluster#tags-1">DataAwsMemorydbCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMemorydbClusterState<'Name>, value: seq<string * string>) : DataAwsMemorydbClusterState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMemorydbClusterState<'Name>

        member _.Run(state: DataAwsMemorydbClusterState<Present>) : aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster =
            let config = aws.DataAwsMemorydbCluster.DataAwsMemorydbClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMemorydbCluster: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMemorydbClusterState<_>) : aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster =
            Unchecked.defaultof<aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster>
