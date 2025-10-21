namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsSecretsState<'Secret> = { assignments: ResizeArray<aws.DataAwsKmsSecrets.DataAwsKmsSecretsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_secrets">aws_kms_secrets</a>.
    /// </summary>
    type DataAwsKmsSecretsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsSecretsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsSecretsState<Missing>)

        member _.Zero(()) : DataAwsKmsSecretsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsSecretsState<Missing>)

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_secrets#secret-1">DataAwsKmsSecrets#secret</a> Accepts: aws.IResolvable | aws.DataAwsKmsSecrets.DataAwsKmsSecretsSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: DataAwsKmsSecretsState<Missing>, value: HashiCorp.Cdktf.IResolvable) : DataAwsKmsSecretsState<Present> =
            state.assignments.Add(fun config -> config.Secret <- value)
            ({ assignments = state.assignments } : DataAwsKmsSecretsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_secrets#id-1">DataAwsKmsSecrets#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsSecretsState<'Secret>, value: string) : DataAwsKmsSecretsState<'Secret> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsSecretsState<'Secret>

        member _.Run(state: DataAwsKmsSecretsState<Present>) : aws.DataAwsKmsSecrets.DataAwsKmsSecrets =
            let config = aws.DataAwsKmsSecrets.DataAwsKmsSecretsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsSecrets.DataAwsKmsSecrets(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKmsSecrets: missing required arguments. Must call: secret.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKmsSecretsState<_>) : aws.DataAwsKmsSecrets.DataAwsKmsSecrets =
            Unchecked.defaultof<aws.DataAwsKmsSecrets.DataAwsKmsSecrets>
