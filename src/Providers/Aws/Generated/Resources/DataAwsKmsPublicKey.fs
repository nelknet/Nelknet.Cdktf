namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsPublicKeyState<'KeyId> = { assignments: ResizeArray<aws.DataAwsKmsPublicKey.DataAwsKmsPublicKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_public_key">aws_kms_public_key</a>.
    /// </summary>
    type DataAwsKmsPublicKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsPublicKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsPublicKeyState<Missing>)

        member _.Zero(()) : DataAwsKmsPublicKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsPublicKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_public_key#key_id-1">DataAwsKmsPublicKey#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: DataAwsKmsPublicKeyState<Missing>, value: string) : DataAwsKmsPublicKeyState<Present> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : DataAwsKmsPublicKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_public_key#grant_tokens-1">DataAwsKmsPublicKey#grant_tokens</a>.
        /// </summary>
        [<CustomOperation "grant_tokens">]
        member _.GrantTokens(state: DataAwsKmsPublicKeyState<'KeyId>, value: seq<string>) : DataAwsKmsPublicKeyState<'KeyId> =
            state.assignments.Add(fun config -> config.GrantTokens <- (value |> Seq.toArray))
            state : DataAwsKmsPublicKeyState<'KeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_public_key#id-1">DataAwsKmsPublicKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsPublicKeyState<'KeyId>, value: string) : DataAwsKmsPublicKeyState<'KeyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsPublicKeyState<'KeyId>

        member _.Run(state: DataAwsKmsPublicKeyState<Present>) : aws.DataAwsKmsPublicKey.DataAwsKmsPublicKey =
            let config = aws.DataAwsKmsPublicKey.DataAwsKmsPublicKeyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsPublicKey.DataAwsKmsPublicKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKmsPublicKey: missing required arguments. Must call: key_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKmsPublicKeyState<_>) : aws.DataAwsKmsPublicKey.DataAwsKmsPublicKey =
            Unchecked.defaultof<aws.DataAwsKmsPublicKey.DataAwsKmsPublicKey>
