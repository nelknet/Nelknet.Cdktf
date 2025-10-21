namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsSecretState<'Secret> = { assignments: ResizeArray<aws.DataAwsKmsSecret.DataAwsKmsSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_secret">aws_kms_secret</a>.
    /// </summary>
    type DataAwsKmsSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsSecretState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsSecretState<Missing>)

        member _.Zero(()) : DataAwsKmsSecretState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsSecretState<Missing>)

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_secret#secret-1">DataAwsKmsSecret#secret</a> Accepts: aws.IResolvable | aws.DataAwsKmsSecret.DataAwsKmsSecretSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: DataAwsKmsSecretState<Missing>, value: HashiCorp.Cdktf.IResolvable) : DataAwsKmsSecretState<Present> =
            state.assignments.Add(fun config -> config.Secret <- value)
            ({ assignments = state.assignments } : DataAwsKmsSecretState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_secret#id-1">DataAwsKmsSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsSecretState<'Secret>, value: string) : DataAwsKmsSecretState<'Secret> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsSecretState<'Secret>

        member _.Run(state: DataAwsKmsSecretState<Present>) : aws.DataAwsKmsSecret.DataAwsKmsSecret =
            let config = aws.DataAwsKmsSecret.DataAwsKmsSecretConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsSecret.DataAwsKmsSecret(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKmsSecret: missing required arguments. Must call: secret.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKmsSecretState<_>) : aws.DataAwsKmsSecret.DataAwsKmsSecret =
            Unchecked.defaultof<aws.DataAwsKmsSecret.DataAwsKmsSecret>
