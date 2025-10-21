namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataexchangeRevisionAssetsState<'DataSetId> = { assignments: ResizeArray<aws.DataexchangeRevisionAssets.DataexchangeRevisionAssetsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets">aws_dataexchange_revision_assets</a>.
    /// </summary>
    type DataexchangeRevisionAssetsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataexchangeRevisionAssetsState<Missing> =
            ({ assignments = ResizeArray() } : DataexchangeRevisionAssetsState<Missing>)

        member _.Zero(()) : DataexchangeRevisionAssetsState<Missing> =
            ({ assignments = ResizeArray() } : DataexchangeRevisionAssetsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#data_set_id-1">DataexchangeRevisionAssets#data_set_id</a>.
        /// </summary>
        [<CustomOperation "data_set_id">]
        member _.DataSetId(state: DataexchangeRevisionAssetsState<Missing>, value: string) : DataexchangeRevisionAssetsState<Present> =
            state.assignments.Add(fun config -> config.DataSetId <- value)
            ({ assignments = state.assignments } : DataexchangeRevisionAssetsState<Present>)

        /// <summary>
        /// asset block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#asset-1">DataexchangeRevisionAssets#asset</a> Accepts: aws.IResolvable | aws.DataexchangeRevisionAssets.DataexchangeRevisionAssetsAsset[]
        /// </summary>
        [<CustomOperation "asset">]
        member _.Asset(state: DataexchangeRevisionAssetsState<'DataSetId>, value: HashiCorp.Cdktf.IResolvable) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.Asset <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#comment-1">DataexchangeRevisionAssets#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: DataexchangeRevisionAssetsState<'DataSetId>, value: string) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#finalized-1">DataexchangeRevisionAssets#finalized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "finalized">]
        member _.Finalized(state: DataexchangeRevisionAssetsState<'DataSetId>, value: bool) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.Finalized <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#finalized-1">DataexchangeRevisionAssets#finalized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "finalized">]
        member _.Finalized(state: DataexchangeRevisionAssetsState<'DataSetId>, value: HashiCorp.Cdktf.IResolvable) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.Finalized <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#force_destroy-1">DataexchangeRevisionAssets#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DataexchangeRevisionAssetsState<'DataSetId>, value: bool) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#force_destroy-1">DataexchangeRevisionAssets#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DataexchangeRevisionAssetsState<'DataSetId>, value: HashiCorp.Cdktf.IResolvable) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#tags-1">DataexchangeRevisionAssets#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataexchangeRevisionAssetsState<'DataSetId>, value: seq<string * string>) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision_assets#timeouts-1">DataexchangeRevisionAssets#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataexchangeRevisionAssetsState<'DataSetId>, value: aws.DataexchangeRevisionAssets.DataexchangeRevisionAssetsTimeouts) : DataexchangeRevisionAssetsState<'DataSetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataexchangeRevisionAssetsState<'DataSetId>

        member _.Run(state: DataexchangeRevisionAssetsState<Present>) : aws.DataexchangeRevisionAssets.DataexchangeRevisionAssets =
            let config = aws.DataexchangeRevisionAssets.DataexchangeRevisionAssetsConfig()
            for setter in state.assignments do
                setter config
            aws.DataexchangeRevisionAssets.DataexchangeRevisionAssets(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataexchangeRevisionAssets: missing required arguments. Must call: data_set_id.", 9999, IsError = true)>]
        member _.Run(_: DataexchangeRevisionAssetsState<_>) : aws.DataexchangeRevisionAssets.DataexchangeRevisionAssets =
            Unchecked.defaultof<aws.DataexchangeRevisionAssets.DataexchangeRevisionAssets>
