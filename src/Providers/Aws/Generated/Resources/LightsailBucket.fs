namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailBucketState<'BundleId, 'Name> = { assignments: ResizeArray<aws.LightsailBucket.LightsailBucketConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket">aws_lightsail_bucket</a>.
    /// </summary>
    type LightsailBucketBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailBucketState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailBucketState<Missing, Missing>)

        member _.Zero(()) : LightsailBucketState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailBucketState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#bundle_id-1">LightsailBucket#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: LightsailBucketState<Missing, 'Name>, value: string) : LightsailBucketState<Present, 'Name> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            ({ assignments = state.assignments } : LightsailBucketState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#name-1">LightsailBucket#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailBucketState<'BundleId, Missing>, value: string) : LightsailBucketState<'BundleId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailBucketState<'BundleId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#force_delete-1">LightsailBucket#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: LightsailBucketState<'BundleId, 'Name>, value: bool) : LightsailBucketState<'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : LightsailBucketState<'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#force_delete-1">LightsailBucket#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: LightsailBucketState<'BundleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LightsailBucketState<'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : LightsailBucketState<'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#id-1">LightsailBucket#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailBucketState<'BundleId, 'Name>, value: string) : LightsailBucketState<'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailBucketState<'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#tags-1">LightsailBucket#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailBucketState<'BundleId, 'Name>, value: seq<string * string>) : LightsailBucketState<'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailBucketState<'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket#tags_all-1">LightsailBucket#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailBucketState<'BundleId, 'Name>, value: seq<string * string>) : LightsailBucketState<'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailBucketState<'BundleId, 'Name>

        member _.Run(state: LightsailBucketState<Present, Present>) : aws.LightsailBucket.LightsailBucket =
            let config = aws.LightsailBucket.LightsailBucketConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailBucket.LightsailBucket(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailBucket: missing required arguments. Must call: bundle_id, name.", 9999, IsError = true)>]
        member _.Run(_: LightsailBucketState<_, _>) : aws.LightsailBucket.LightsailBucket =
            Unchecked.defaultof<aws.LightsailBucket.LightsailBucket>
