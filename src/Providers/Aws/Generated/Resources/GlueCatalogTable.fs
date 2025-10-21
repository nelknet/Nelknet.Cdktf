namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueCatalogTableState<'DatabaseName, 'Name> = { assignments: ResizeArray<aws.GlueCatalogTable.GlueCatalogTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table">aws_glue_catalog_table</a>.
    /// </summary>
    type GlueCatalogTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueCatalogTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueCatalogTableState<Missing, Missing>)

        member _.Zero(()) : GlueCatalogTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueCatalogTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#database_name-1">GlueCatalogTable#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: GlueCatalogTableState<Missing, 'Name>, value: string) : GlueCatalogTableState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : GlueCatalogTableState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#name-1">GlueCatalogTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueCatalogTableState<'DatabaseName, Missing>, value: string) : GlueCatalogTableState<'DatabaseName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueCatalogTableState<'DatabaseName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#catalog_id-1">GlueCatalogTable#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#description-1">GlueCatalogTable#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#id-1">GlueCatalogTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// open_table_format_input block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#open_table_format_input-1">GlueCatalogTable#open_table_format_input</a>
        /// </summary>
        [<CustomOperation "open_table_format_input">]
        member _.OpenTableFormatInput(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInput) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.OpenTableFormatInput <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#owner-1">GlueCatalogTable#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#parameters-1">GlueCatalogTable#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: seq<string * string>) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// partition_index block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#partition_index-1">GlueCatalogTable#partition_index</a> Accepts: aws.IResolvable | aws.GlueCatalogTable.GlueCatalogTablePartitionIndex[]
        /// </summary>
        [<CustomOperation "partition_index">]
        member _.PartitionIndex(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.PartitionIndex <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// partition_keys block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#partition_keys-1">GlueCatalogTable#partition_keys</a> Accepts: aws.IResolvable | aws.GlueCatalogTable.GlueCatalogTablePartitionKeys[]
        /// </summary>
        [<CustomOperation "partition_keys">]
        member _.PartitionKeys(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.PartitionKeys <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#retention-1">GlueCatalogTable#retention</a>.
        /// </summary>
        [<CustomOperation "retention">]
        member _.Retention(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: double) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Retention <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// storage_descriptor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#storage_descriptor-1">GlueCatalogTable#storage_descriptor</a>
        /// </summary>
        [<CustomOperation "storage_descriptor">]
        member _.StorageDescriptor(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: aws.GlueCatalogTable.GlueCatalogTableStorageDescriptor) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.StorageDescriptor <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#table_type-1">GlueCatalogTable#table_type</a>.
        /// </summary>
        [<CustomOperation "table_type">]
        member _.TableType(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.TableType <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// target_table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#target_table-1">GlueCatalogTable#target_table</a>
        /// </summary>
        [<CustomOperation "target_table">]
        member _.TargetTable(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: aws.GlueCatalogTable.GlueCatalogTableTargetTable) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.TargetTable <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#view_expanded_text-1">GlueCatalogTable#view_expanded_text</a>.
        /// </summary>
        [<CustomOperation "view_expanded_text">]
        member _.ViewExpandedText(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.ViewExpandedText <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#view_original_text-1">GlueCatalogTable#view_original_text</a>.
        /// </summary>
        [<CustomOperation "view_original_text">]
        member _.ViewOriginalText(state: GlueCatalogTableState<'DatabaseName, 'Name>, value: string) : GlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.ViewOriginalText <- value)
            state : GlueCatalogTableState<'DatabaseName, 'Name>

        member _.Run(state: GlueCatalogTableState<Present, Present>) : aws.GlueCatalogTable.GlueCatalogTable =
            let config = aws.GlueCatalogTable.GlueCatalogTableConfig()
            for setter in state.assignments do
                setter config
            aws.GlueCatalogTable.GlueCatalogTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueCatalogTable: missing required arguments. Must call: database_name, name.", 9999, IsError = true)>]
        member _.Run(_: GlueCatalogTableState<_, _>) : aws.GlueCatalogTable.GlueCatalogTable =
            Unchecked.defaultof<aws.GlueCatalogTable.GlueCatalogTable>
