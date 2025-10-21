namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsCiphertextState<'KeyId, 'Plaintext> = { assignments: ResizeArray<aws.KmsCiphertext.KmsCiphertextConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_ciphertext">aws_kms_ciphertext</a>.
    /// </summary>
    type KmsCiphertextBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsCiphertextState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KmsCiphertextState<Missing, Missing>)

        member _.Zero(()) : KmsCiphertextState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KmsCiphertextState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_ciphertext#key_id-1">KmsCiphertext#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: KmsCiphertextState<Missing, 'Plaintext>, value: string) : KmsCiphertextState<Present, 'Plaintext> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : KmsCiphertextState<Present, 'Plaintext>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_ciphertext#plaintext-1">KmsCiphertext#plaintext</a>.
        /// </summary>
        [<CustomOperation "plaintext">]
        member _.Plaintext(state: KmsCiphertextState<'KeyId, Missing>, value: string) : KmsCiphertextState<'KeyId, Present> =
            state.assignments.Add(fun config -> config.Plaintext <- value)
            ({ assignments = state.assignments } : KmsCiphertextState<'KeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_ciphertext#context-1">KmsCiphertext#context</a>.
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: KmsCiphertextState<'KeyId, 'Plaintext>, value: seq<string * string>) : KmsCiphertextState<'KeyId, 'Plaintext> =
            state.assignments.Add(fun config -> config.Context <- dict value)
            state : KmsCiphertextState<'KeyId, 'Plaintext>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_ciphertext#id-1">KmsCiphertext#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsCiphertextState<'KeyId, 'Plaintext>, value: string) : KmsCiphertextState<'KeyId, 'Plaintext> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsCiphertextState<'KeyId, 'Plaintext>

        member _.Run(state: KmsCiphertextState<Present, Present>) : aws.KmsCiphertext.KmsCiphertext =
            let config = aws.KmsCiphertext.KmsCiphertextConfig()
            for setter in state.assignments do
                setter config
            aws.KmsCiphertext.KmsCiphertext(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsCiphertext: missing required arguments. Must call: key_id, plaintext.", 9999, IsError = true)>]
        member _.Run(_: KmsCiphertextState<_, _>) : aws.KmsCiphertext.KmsCiphertext =
            Unchecked.defaultof<aws.KmsCiphertext.KmsCiphertext>
