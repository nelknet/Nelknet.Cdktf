namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsCiphertextState<'KeyId, 'Plaintext> = { assignments: ResizeArray<aws.DataAwsKmsCiphertext.DataAwsKmsCiphertextConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_ciphertext">aws_kms_ciphertext</a>.
    /// </summary>
    type DataAwsKmsCiphertextBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsCiphertextState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsCiphertextState<Missing, Missing>)

        member _.Zero(()) : DataAwsKmsCiphertextState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsCiphertextState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_ciphertext#key_id-1">DataAwsKmsCiphertext#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: DataAwsKmsCiphertextState<Missing, 'Plaintext>, value: string) : DataAwsKmsCiphertextState<Present, 'Plaintext> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : DataAwsKmsCiphertextState<Present, 'Plaintext>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_ciphertext#plaintext-1">DataAwsKmsCiphertext#plaintext</a>.
        /// </summary>
        [<CustomOperation "plaintext">]
        member _.Plaintext(state: DataAwsKmsCiphertextState<'KeyId, Missing>, value: string) : DataAwsKmsCiphertextState<'KeyId, Present> =
            state.assignments.Add(fun config -> config.Plaintext <- value)
            ({ assignments = state.assignments } : DataAwsKmsCiphertextState<'KeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_ciphertext#context-1">DataAwsKmsCiphertext#context</a>.
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: DataAwsKmsCiphertextState<'KeyId, 'Plaintext>, value: seq<string * string>) : DataAwsKmsCiphertextState<'KeyId, 'Plaintext> =
            state.assignments.Add(fun config -> config.Context <- dict value)
            state : DataAwsKmsCiphertextState<'KeyId, 'Plaintext>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_ciphertext#id-1">DataAwsKmsCiphertext#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsCiphertextState<'KeyId, 'Plaintext>, value: string) : DataAwsKmsCiphertextState<'KeyId, 'Plaintext> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsCiphertextState<'KeyId, 'Plaintext>

        member _.Run(state: DataAwsKmsCiphertextState<Present, Present>) : aws.DataAwsKmsCiphertext.DataAwsKmsCiphertext =
            let config = aws.DataAwsKmsCiphertext.DataAwsKmsCiphertextConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsCiphertext.DataAwsKmsCiphertext(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKmsCiphertext: missing required arguments. Must call: key_id, plaintext.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKmsCiphertextState<_, _>) : aws.DataAwsKmsCiphertext.DataAwsKmsCiphertext =
            Unchecked.defaultof<aws.DataAwsKmsCiphertext.DataAwsKmsCiphertext>
