namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName> = { assignments: ResizeArray<aws.GluePartitionIndex.GluePartitionIndexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index">aws_glue_partition_index</a>.
    /// </summary>
    type GluePartitionIndexBuilder(logicalId: string) =
        member _.Yield(_: unit) : GluePartitionIndexState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GluePartitionIndexState<Missing, Missing, Missing>)

        member _.Zero(()) : GluePartitionIndexState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GluePartitionIndexState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#database_name-1">GluePartitionIndex#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: GluePartitionIndexState<Missing, 'PartitionIndex, 'TableName>, value: string) : GluePartitionIndexState<Present, 'PartitionIndex, 'TableName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : GluePartitionIndexState<Present, 'PartitionIndex, 'TableName>)

        /// <summary>
        /// partition_index block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#partition_index-1">GluePartitionIndex#partition_index</a>
        /// </summary>
        [<CustomOperation "partition_index">]
        member _.PartitionIndex(state: GluePartitionIndexState<'DatabaseName, Missing, 'TableName>, value: aws.GluePartitionIndex.GluePartitionIndexPartitionIndex) : GluePartitionIndexState<'DatabaseName, Present, 'TableName> =
            state.assignments.Add(fun config -> config.PartitionIndex <- value)
            ({ assignments = state.assignments } : GluePartitionIndexState<'DatabaseName, Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#table_name-1">GluePartitionIndex#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: GluePartitionIndexState<'DatabaseName, 'PartitionIndex, Missing>, value: string) : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#catalog_id-1">GluePartitionIndex#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName>, value: string) : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#id-1">GluePartitionIndex#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName>, value: string) : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#timeouts-1">GluePartitionIndex#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName>, value: aws.GluePartitionIndex.GluePartitionIndexTimeouts) : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GluePartitionIndexState<'DatabaseName, 'PartitionIndex, 'TableName>

        member _.Run(state: GluePartitionIndexState<Present, Present, Present>) : aws.GluePartitionIndex.GluePartitionIndex =
            let config = aws.GluePartitionIndex.GluePartitionIndexConfig()
            for setter in state.assignments do
                setter config
            aws.GluePartitionIndex.GluePartitionIndex(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gluePartitionIndex: missing required arguments. Must call: database_name, partition_index, table_name.", 9999, IsError = true)>]
        member _.Run(_: GluePartitionIndexState<_, _, _>) : aws.GluePartitionIndex.GluePartitionIndex =
            Unchecked.defaultof<aws.GluePartitionIndex.GluePartitionIndex>
