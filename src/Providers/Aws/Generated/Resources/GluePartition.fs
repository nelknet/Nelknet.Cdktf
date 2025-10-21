namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName> = { assignments: ResizeArray<aws.GluePartition.GluePartitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition">aws_glue_partition</a>.
    /// </summary>
    type GluePartitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : GluePartitionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GluePartitionState<Missing, Missing, Missing>)

        member _.Zero(()) : GluePartitionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GluePartitionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#database_name-1">GluePartition#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: GluePartitionState<Missing, 'PartitionValues, 'TableName>, value: string) : GluePartitionState<Present, 'PartitionValues, 'TableName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : GluePartitionState<Present, 'PartitionValues, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#partition_values-1">GluePartition#partition_values</a>.
        /// </summary>
        [<CustomOperation "partition_values">]
        member _.PartitionValues(state: GluePartitionState<'DatabaseName, Missing, 'TableName>, value: seq<string>) : GluePartitionState<'DatabaseName, Present, 'TableName> =
            state.assignments.Add(fun config -> config.PartitionValues <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : GluePartitionState<'DatabaseName, Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#table_name-1">GluePartition#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: GluePartitionState<'DatabaseName, 'PartitionValues, Missing>, value: string) : GluePartitionState<'DatabaseName, 'PartitionValues, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : GluePartitionState<'DatabaseName, 'PartitionValues, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#catalog_id-1">GluePartition#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>, value: string) : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#id-1">GluePartition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>, value: string) : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#parameters-1">GluePartition#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>, value: seq<string * string>) : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>

        /// <summary>
        /// storage_descriptor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#storage_descriptor-1">GluePartition#storage_descriptor</a>
        /// </summary>
        [<CustomOperation "storage_descriptor">]
        member _.StorageDescriptor(state: GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>, value: aws.GluePartition.GluePartitionStorageDescriptor) : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName> =
            state.assignments.Add(fun config -> config.StorageDescriptor <- value)
            state : GluePartitionState<'DatabaseName, 'PartitionValues, 'TableName>

        member _.Run(state: GluePartitionState<Present, Present, Present>) : aws.GluePartition.GluePartition =
            let config = aws.GluePartition.GluePartitionConfig()
            for setter in state.assignments do
                setter config
            aws.GluePartition.GluePartition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gluePartition: missing required arguments. Must call: database_name, partition_values, table_name.", 9999, IsError = true)>]
        member _.Run(_: GluePartitionState<_, _, _>) : aws.GluePartition.GluePartition =
            Unchecked.defaultof<aws.GluePartition.GluePartition>
