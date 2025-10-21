namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOutpostsAssetState<'Arn, 'AssetId> = { assignments: ResizeArray<aws.DataAwsOutpostsAsset.DataAwsOutpostsAssetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_asset">aws_outposts_asset</a>.
    /// </summary>
    type DataAwsOutpostsAssetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOutpostsAssetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsAssetState<Missing, Missing>)

        member _.Zero(()) : DataAwsOutpostsAssetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsAssetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_asset#arn-1">DataAwsOutpostsAsset#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsOutpostsAssetState<Missing, 'AssetId>, value: string) : DataAwsOutpostsAssetState<Present, 'AssetId> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsOutpostsAssetState<Present, 'AssetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_asset#asset_id-1">DataAwsOutpostsAsset#asset_id</a>.
        /// </summary>
        [<CustomOperation "asset_id">]
        member _.AssetId(state: DataAwsOutpostsAssetState<'Arn, Missing>, value: string) : DataAwsOutpostsAssetState<'Arn, Present> =
            state.assignments.Add(fun config -> config.AssetId <- value)
            ({ assignments = state.assignments } : DataAwsOutpostsAssetState<'Arn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_asset#id-1">DataAwsOutpostsAsset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOutpostsAssetState<'Arn, 'AssetId>, value: string) : DataAwsOutpostsAssetState<'Arn, 'AssetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOutpostsAssetState<'Arn, 'AssetId>

        member _.Run(state: DataAwsOutpostsAssetState<Present, Present>) : aws.DataAwsOutpostsAsset.DataAwsOutpostsAsset =
            let config = aws.DataAwsOutpostsAsset.DataAwsOutpostsAssetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOutpostsAsset.DataAwsOutpostsAsset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOutpostsAsset: missing required arguments. Must call: arn, asset_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOutpostsAssetState<_, _>) : aws.DataAwsOutpostsAsset.DataAwsOutpostsAsset =
            Unchecked.defaultof<aws.DataAwsOutpostsAsset.DataAwsOutpostsAsset>
