namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference> = { assignments: ResizeArray<aws.CleanroomsConfiguredTable.CleanroomsConfiguredTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table">aws_cleanrooms_configured_table</a>.
    /// </summary>
    type CleanroomsConfiguredTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : CleanroomsConfiguredTableState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CleanroomsConfiguredTableState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CleanroomsConfiguredTableState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CleanroomsConfiguredTableState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#allowed_columns-1">CleanroomsConfiguredTable#allowed_columns</a>.
        /// </summary>
        [<CustomOperation "allowed_columns">]
        member _.AllowedColumns(state: CleanroomsConfiguredTableState<Missing, 'AnalysisMethod, 'Name, 'TableReference>, value: seq<string>) : CleanroomsConfiguredTableState<Present, 'AnalysisMethod, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.AllowedColumns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CleanroomsConfiguredTableState<Present, 'AnalysisMethod, 'Name, 'TableReference>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#analysis_method-1">CleanroomsConfiguredTable#analysis_method</a>.
        /// </summary>
        [<CustomOperation "analysis_method">]
        member _.AnalysisMethod(state: CleanroomsConfiguredTableState<'AllowedColumns, Missing, 'Name, 'TableReference>, value: string) : CleanroomsConfiguredTableState<'AllowedColumns, Present, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.AnalysisMethod <- value)
            ({ assignments = state.assignments } : CleanroomsConfiguredTableState<'AllowedColumns, Present, 'Name, 'TableReference>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#name-1">CleanroomsConfiguredTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, Missing, 'TableReference>, value: string) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, Present, 'TableReference> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, Present, 'TableReference>)

        /// <summary>
        /// table_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#table_reference-1">CleanroomsConfiguredTable#table_reference</a>
        /// </summary>
        [<CustomOperation "table_reference">]
        member _.TableReference(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, Missing>, value: aws.CleanroomsConfiguredTable.CleanroomsConfiguredTableTableReference) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, Present> =
            state.assignments.Add(fun config -> config.TableReference <- value)
            ({ assignments = state.assignments } : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#description-1">CleanroomsConfiguredTable#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>, value: string) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#id-1">CleanroomsConfiguredTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>, value: string) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#tags-1">CleanroomsConfiguredTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>, value: seq<string * string>) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#tags_all-1">CleanroomsConfiguredTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>, value: seq<string * string>) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_configured_table#timeouts-1">CleanroomsConfiguredTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>, value: aws.CleanroomsConfiguredTable.CleanroomsConfiguredTableTimeouts) : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CleanroomsConfiguredTableState<'AllowedColumns, 'AnalysisMethod, 'Name, 'TableReference>

        member _.Run(state: CleanroomsConfiguredTableState<Present, Present, Present, Present>) : aws.CleanroomsConfiguredTable.CleanroomsConfiguredTable =
            let config = aws.CleanroomsConfiguredTable.CleanroomsConfiguredTableConfig()
            for setter in state.assignments do
                setter config
            aws.CleanroomsConfiguredTable.CleanroomsConfiguredTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cleanroomsConfiguredTable: missing required arguments. Must call: allowed_columns, analysis_method, name, table_reference.", 9999, IsError = true)>]
        member _.Run(_: CleanroomsConfiguredTableState<_, _, _, _>) : aws.CleanroomsConfiguredTable.CleanroomsConfiguredTable =
            Unchecked.defaultof<aws.CleanroomsConfiguredTable.CleanroomsConfiguredTable>
