namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationResourceLfTagsState<'LfTag> = { assignments: ResizeArray<aws.LakeformationResourceLfTags.LakeformationResourceLfTagsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags">aws_lakeformation_resource_lf_tags</a>.
    /// </summary>
    type LakeformationResourceLfTagsBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationResourceLfTagsState<Missing> =
            ({ assignments = ResizeArray() } : LakeformationResourceLfTagsState<Missing>)

        member _.Zero(()) : LakeformationResourceLfTagsState<Missing> =
            ({ assignments = ResizeArray() } : LakeformationResourceLfTagsState<Missing>)

        /// <summary>
        /// lf_tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#lf_tag-1">LakeformationResourceLfTags#lf_tag</a> Accepts: aws.IResolvable | aws.LakeformationResourceLfTags.LakeformationResourceLfTagsLfTag[]
        /// </summary>
        [<CustomOperation "lf_tag">]
        member _.LfTag(state: LakeformationResourceLfTagsState<Missing>, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceLfTagsState<Present> =
            state.assignments.Add(fun config -> config.LfTag <- value)
            ({ assignments = state.assignments } : LakeformationResourceLfTagsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#catalog_id-1">LakeformationResourceLfTags#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: LakeformationResourceLfTagsState<'LfTag>, value: string) : LakeformationResourceLfTagsState<'LfTag> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : LakeformationResourceLfTagsState<'LfTag>

        /// <summary>
        /// database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#database-1">LakeformationResourceLfTags#database</a>
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: LakeformationResourceLfTagsState<'LfTag>, value: aws.LakeformationResourceLfTags.LakeformationResourceLfTagsDatabase) : LakeformationResourceLfTagsState<'LfTag> =
            state.assignments.Add(fun config -> config.Database <- value)
            state : LakeformationResourceLfTagsState<'LfTag>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#id-1">LakeformationResourceLfTags#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LakeformationResourceLfTagsState<'LfTag>, value: string) : LakeformationResourceLfTagsState<'LfTag> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LakeformationResourceLfTagsState<'LfTag>

        /// <summary>
        /// table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#table-1">LakeformationResourceLfTags#table</a>
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: LakeformationResourceLfTagsState<'LfTag>, value: aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTable) : LakeformationResourceLfTagsState<'LfTag> =
            state.assignments.Add(fun config -> config.Table <- value)
            state : LakeformationResourceLfTagsState<'LfTag>

        /// <summary>
        /// table_with_columns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#table_with_columns-1">LakeformationResourceLfTags#table_with_columns</a>
        /// </summary>
        [<CustomOperation "table_with_columns">]
        member _.TableWithColumns(state: LakeformationResourceLfTagsState<'LfTag>, value: aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTableWithColumns) : LakeformationResourceLfTagsState<'LfTag> =
            state.assignments.Add(fun config -> config.TableWithColumns <- value)
            state : LakeformationResourceLfTagsState<'LfTag>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#timeouts-1">LakeformationResourceLfTags#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LakeformationResourceLfTagsState<'LfTag>, value: aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTimeouts) : LakeformationResourceLfTagsState<'LfTag> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LakeformationResourceLfTagsState<'LfTag>

        member _.Run(state: LakeformationResourceLfTagsState<Present>) : aws.LakeformationResourceLfTags.LakeformationResourceLfTags =
            let config = aws.LakeformationResourceLfTags.LakeformationResourceLfTagsConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationResourceLfTags.LakeformationResourceLfTags(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lakeformationResourceLfTags: missing required arguments. Must call: lf_tag.", 9999, IsError = true)>]
        member _.Run(_: LakeformationResourceLfTagsState<_>) : aws.LakeformationResourceLfTags.LakeformationResourceLfTags =
            Unchecked.defaultof<aws.LakeformationResourceLfTags.LakeformationResourceLfTags>
