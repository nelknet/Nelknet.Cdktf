namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOutpostsAssetsState<'Arn> = { assignments: ResizeArray<aws.DataAwsOutpostsAssets.DataAwsOutpostsAssetsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_assets">aws_outposts_assets</a>.
    /// </summary>
    type DataAwsOutpostsAssetsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOutpostsAssetsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsAssetsState<Missing>)

        member _.Zero(()) : DataAwsOutpostsAssetsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsAssetsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_assets#arn-1">DataAwsOutpostsAssets#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsOutpostsAssetsState<Missing>, value: string) : DataAwsOutpostsAssetsState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsOutpostsAssetsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_assets#host_id_filter-1">DataAwsOutpostsAssets#host_id_filter</a>.
        /// </summary>
        [<CustomOperation "host_id_filter">]
        member _.HostIdFilter(state: DataAwsOutpostsAssetsState<'Arn>, value: seq<string>) : DataAwsOutpostsAssetsState<'Arn> =
            state.assignments.Add(fun config -> config.HostIdFilter <- (value |> Seq.toArray))
            state : DataAwsOutpostsAssetsState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_assets#id-1">DataAwsOutpostsAssets#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOutpostsAssetsState<'Arn>, value: string) : DataAwsOutpostsAssetsState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOutpostsAssetsState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_assets#status_id_filter-1">DataAwsOutpostsAssets#status_id_filter</a>.
        /// </summary>
        [<CustomOperation "status_id_filter">]
        member _.StatusIdFilter(state: DataAwsOutpostsAssetsState<'Arn>, value: seq<string>) : DataAwsOutpostsAssetsState<'Arn> =
            state.assignments.Add(fun config -> config.StatusIdFilter <- (value |> Seq.toArray))
            state : DataAwsOutpostsAssetsState<'Arn>

        member _.Run(state: DataAwsOutpostsAssetsState<Present>) : aws.DataAwsOutpostsAssets.DataAwsOutpostsAssets =
            let config = aws.DataAwsOutpostsAssets.DataAwsOutpostsAssetsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOutpostsAssets.DataAwsOutpostsAssets(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOutpostsAssets: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOutpostsAssetsState<_>) : aws.DataAwsOutpostsAssets.DataAwsOutpostsAssets =
            Unchecked.defaultof<aws.DataAwsOutpostsAssets.DataAwsOutpostsAssets>
