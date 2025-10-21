namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationResourceLfTagState = { assignments: ResizeArray<aws.LakeformationResourceLfTag.LakeformationResourceLfTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag">aws_lakeformation_resource_lf_tag</a>.
    /// </summary>
    type LakeformationResourceLfTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationResourceLfTagState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LakeformationResourceLfTagState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag#catalog_id-1">LakeformationResourceLfTag#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: LakeformationResourceLfTagState, value: string) : LakeformationResourceLfTagState =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : LakeformationResourceLfTagState

        /// <summary>
        /// database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag#database-1">LakeformationResourceLfTag#database</a> Accepts: aws.IResolvable | aws.LakeformationResourceLfTag.LakeformationResourceLfTagDatabase[]
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: LakeformationResourceLfTagState, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceLfTagState =
            state.assignments.Add(fun config -> config.Database <- value)
            state : LakeformationResourceLfTagState

        /// <summary>
        /// lf_tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag#lf_tag-1">LakeformationResourceLfTag#lf_tag</a> Accepts: aws.IResolvable | aws.LakeformationResourceLfTag.LakeformationResourceLfTagLfTag[]
        /// </summary>
        [<CustomOperation "lf_tag">]
        member _.LfTag(state: LakeformationResourceLfTagState, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceLfTagState =
            state.assignments.Add(fun config -> config.LfTag <- value)
            state : LakeformationResourceLfTagState

        /// <summary>
        /// table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag#table-1">LakeformationResourceLfTag#table</a> Accepts: aws.IResolvable | aws.LakeformationResourceLfTag.LakeformationResourceLfTagTable[]
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: LakeformationResourceLfTagState, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceLfTagState =
            state.assignments.Add(fun config -> config.Table <- value)
            state : LakeformationResourceLfTagState

        /// <summary>
        /// table_with_columns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag#table_with_columns-1">LakeformationResourceLfTag#table_with_columns</a> Accepts: aws.IResolvable | aws.LakeformationResourceLfTag.LakeformationResourceLfTagTableWithColumns[]
        /// </summary>
        [<CustomOperation "table_with_columns">]
        member _.TableWithColumns(state: LakeformationResourceLfTagState, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceLfTagState =
            state.assignments.Add(fun config -> config.TableWithColumns <- value)
            state : LakeformationResourceLfTagState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tag#timeouts-1">LakeformationResourceLfTag#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LakeformationResourceLfTagState, value: aws.LakeformationResourceLfTag.LakeformationResourceLfTagTimeouts) : LakeformationResourceLfTagState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LakeformationResourceLfTagState

        member _.Run(state: LakeformationResourceLfTagState) : aws.LakeformationResourceLfTag.LakeformationResourceLfTag =
            let config = aws.LakeformationResourceLfTag.LakeformationResourceLfTagConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationResourceLfTag.LakeformationResourceLfTag(StackContext.get (), logicalId, config)
