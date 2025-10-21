namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailBucketAccessKeyState<'BucketName> = { assignments: ResizeArray<aws.LightsailBucketAccessKey.LightsailBucketAccessKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_access_key">aws_lightsail_bucket_access_key</a>.
    /// </summary>
    type LightsailBucketAccessKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailBucketAccessKeyState<Missing> =
            ({ assignments = ResizeArray() } : LightsailBucketAccessKeyState<Missing>)

        member _.Zero(()) : LightsailBucketAccessKeyState<Missing> =
            ({ assignments = ResizeArray() } : LightsailBucketAccessKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_access_key#bucket_name-1">LightsailBucketAccessKey#bucket_name</a>.
        /// </summary>
        [<CustomOperation "bucket_name">]
        member _.BucketName(state: LightsailBucketAccessKeyState<Missing>, value: string) : LightsailBucketAccessKeyState<Present> =
            state.assignments.Add(fun config -> config.BucketName <- value)
            ({ assignments = state.assignments } : LightsailBucketAccessKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_access_key#id-1">LightsailBucketAccessKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailBucketAccessKeyState<'BucketName>, value: string) : LightsailBucketAccessKeyState<'BucketName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailBucketAccessKeyState<'BucketName>

        member _.Run(state: LightsailBucketAccessKeyState<Present>) : aws.LightsailBucketAccessKey.LightsailBucketAccessKey =
            let config = aws.LightsailBucketAccessKey.LightsailBucketAccessKeyConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailBucketAccessKey.LightsailBucketAccessKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailBucketAccessKey: missing required arguments. Must call: bucket_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailBucketAccessKeyState<_>) : aws.LightsailBucketAccessKey.LightsailBucketAccessKey =
            Unchecked.defaultof<aws.LightsailBucketAccessKey.LightsailBucketAccessKey>
