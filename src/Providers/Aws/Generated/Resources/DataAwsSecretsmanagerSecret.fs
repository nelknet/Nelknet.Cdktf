namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecretsmanagerSecretState = { assignments: ResizeArray<aws.DataAwsSecretsmanagerSecret.DataAwsSecretsmanagerSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret">aws_secretsmanager_secret</a>.
    /// </summary>
    type DataAwsSecretsmanagerSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecretsmanagerSecretState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSecretsmanagerSecretState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret#arn-1">DataAwsSecretsmanagerSecret#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSecretsmanagerSecretState, value: string) : DataAwsSecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsSecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret#id-1">DataAwsSecretsmanagerSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecretsmanagerSecretState, value: string) : DataAwsSecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret#name-1">DataAwsSecretsmanagerSecret#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSecretsmanagerSecretState, value: string) : DataAwsSecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsSecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret#tags-1">DataAwsSecretsmanagerSecret#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSecretsmanagerSecretState, value: seq<string * string>) : DataAwsSecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSecretsmanagerSecretState

        member _.Run(state: DataAwsSecretsmanagerSecretState) : aws.DataAwsSecretsmanagerSecret.DataAwsSecretsmanagerSecret =
            let config = aws.DataAwsSecretsmanagerSecret.DataAwsSecretsmanagerSecretConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecretsmanagerSecret.DataAwsSecretsmanagerSecret(StackContext.get (), logicalId, config)
