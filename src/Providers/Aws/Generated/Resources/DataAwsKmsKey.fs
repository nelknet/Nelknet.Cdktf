namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsKeyState<'KeyId> = { assignments: ResizeArray<aws.DataAwsKmsKey.DataAwsKmsKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key">aws_kms_key</a>.
    /// </summary>
    type DataAwsKmsKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsKeyState<Missing>)

        member _.Zero(()) : DataAwsKmsKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key#key_id-1">DataAwsKmsKey#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: DataAwsKmsKeyState<Missing>, value: string) : DataAwsKmsKeyState<Present> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : DataAwsKmsKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key#grant_tokens-1">DataAwsKmsKey#grant_tokens</a>.
        /// </summary>
        [<CustomOperation "grant_tokens">]
        member _.GrantTokens(state: DataAwsKmsKeyState<'KeyId>, value: seq<string>) : DataAwsKmsKeyState<'KeyId> =
            state.assignments.Add(fun config -> config.GrantTokens <- (value |> Seq.toArray))
            state : DataAwsKmsKeyState<'KeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key#id-1">DataAwsKmsKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsKeyState<'KeyId>, value: string) : DataAwsKmsKeyState<'KeyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsKeyState<'KeyId>

        member _.Run(state: DataAwsKmsKeyState<Present>) : aws.DataAwsKmsKey.DataAwsKmsKey =
            let config = aws.DataAwsKmsKey.DataAwsKmsKeyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsKey.DataAwsKmsKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKmsKey: missing required arguments. Must call: key_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKmsKeyState<_>) : aws.DataAwsKmsKey.DataAwsKmsKey =
            Unchecked.defaultof<aws.DataAwsKmsKey.DataAwsKmsKey>
