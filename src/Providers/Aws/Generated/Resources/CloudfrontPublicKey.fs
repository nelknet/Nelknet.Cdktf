namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontPublicKeyState<'EncodedKey> = { assignments: ResizeArray<aws.CloudfrontPublicKey.CloudfrontPublicKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_public_key">aws_cloudfront_public_key</a>.
    /// </summary>
    type CloudfrontPublicKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontPublicKeyState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontPublicKeyState<Missing>)

        member _.Zero(()) : CloudfrontPublicKeyState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontPublicKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_public_key#encoded_key-1">CloudfrontPublicKey#encoded_key</a>.
        /// </summary>
        [<CustomOperation "encoded_key">]
        member _.EncodedKey(state: CloudfrontPublicKeyState<Missing>, value: string) : CloudfrontPublicKeyState<Present> =
            state.assignments.Add(fun config -> config.EncodedKey <- value)
            ({ assignments = state.assignments } : CloudfrontPublicKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_public_key#comment-1">CloudfrontPublicKey#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontPublicKeyState<'EncodedKey>, value: string) : CloudfrontPublicKeyState<'EncodedKey> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontPublicKeyState<'EncodedKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_public_key#id-1">CloudfrontPublicKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontPublicKeyState<'EncodedKey>, value: string) : CloudfrontPublicKeyState<'EncodedKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontPublicKeyState<'EncodedKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_public_key#name-1">CloudfrontPublicKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontPublicKeyState<'EncodedKey>, value: string) : CloudfrontPublicKeyState<'EncodedKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : CloudfrontPublicKeyState<'EncodedKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_public_key#name_prefix-1">CloudfrontPublicKey#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: CloudfrontPublicKeyState<'EncodedKey>, value: string) : CloudfrontPublicKeyState<'EncodedKey> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : CloudfrontPublicKeyState<'EncodedKey>

        member _.Run(state: CloudfrontPublicKeyState<Present>) : aws.CloudfrontPublicKey.CloudfrontPublicKey =
            let config = aws.CloudfrontPublicKey.CloudfrontPublicKeyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontPublicKey.CloudfrontPublicKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontPublicKey: missing required arguments. Must call: encoded_key.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontPublicKeyState<_>) : aws.CloudfrontPublicKey.CloudfrontPublicKey =
            Unchecked.defaultof<aws.CloudfrontPublicKey.CloudfrontPublicKey>
