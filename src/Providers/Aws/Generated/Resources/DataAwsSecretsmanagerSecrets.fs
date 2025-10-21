namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecretsmanagerSecretsState = { assignments: ResizeArray<aws.DataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecretsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets">aws_secretsmanager_secrets</a>.
    /// </summary>
    type DataAwsSecretsmanagerSecretsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecretsmanagerSecretsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSecretsmanagerSecretsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets#filter-1">DataAwsSecretsmanagerSecrets#filter</a> Accepts: aws.IResolvable | aws.DataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecretsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSecretsmanagerSecretsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerSecretsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSecretsmanagerSecretsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets#id-1">DataAwsSecretsmanagerSecrets#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecretsmanagerSecretsState, value: string) : DataAwsSecretsmanagerSecretsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecretsmanagerSecretsState

        member _.Run(state: DataAwsSecretsmanagerSecretsState) : aws.DataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecrets =
            let config = aws.DataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecretsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecrets(StackContext.get (), logicalId, config)
