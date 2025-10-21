namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecretsmanagerSecretState = { assignments: ResizeArray<aws.SecretsmanagerSecret.SecretsmanagerSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret">aws_secretsmanager_secret</a>.
    /// </summary>
    type SecretsmanagerSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecretsmanagerSecretState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SecretsmanagerSecretState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#description-1">SecretsmanagerSecret#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecretsmanagerSecretState, value: string) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#force_overwrite_replica_secret-1">SecretsmanagerSecret#force_overwrite_replica_secret</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_overwrite_replica_secret">]
        member _.ForceOverwriteReplicaSecret(state: SecretsmanagerSecretState, value: bool) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.ForceOverwriteReplicaSecret <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#force_overwrite_replica_secret-1">SecretsmanagerSecret#force_overwrite_replica_secret</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_overwrite_replica_secret">]
        member _.ForceOverwriteReplicaSecret(state: SecretsmanagerSecretState, value: HashiCorp.Cdktf.IResolvable) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.ForceOverwriteReplicaSecret <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#id-1">SecretsmanagerSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecretsmanagerSecretState, value: string) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#kms_key_id-1">SecretsmanagerSecret#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: SecretsmanagerSecretState, value: string) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#name-1">SecretsmanagerSecret#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecretsmanagerSecretState, value: string) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#name_prefix-1">SecretsmanagerSecret#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SecretsmanagerSecretState, value: string) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#policy-1">SecretsmanagerSecret#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SecretsmanagerSecretState, value: string) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#recovery_window_in_days-1">SecretsmanagerSecret#recovery_window_in_days</a>.
        /// </summary>
        [<CustomOperation "recovery_window_in_days">]
        member _.RecoveryWindowInDays(state: SecretsmanagerSecretState, value: double) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.RecoveryWindowInDays <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// replica block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#replica-1">SecretsmanagerSecret#replica</a> Accepts: aws.IResolvable | aws.SecretsmanagerSecret.SecretsmanagerSecretReplica[]
        /// </summary>
        [<CustomOperation "replica">]
        member _.Replica(state: SecretsmanagerSecretState, value: HashiCorp.Cdktf.IResolvable) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Replica <- value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#tags-1">SecretsmanagerSecret#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SecretsmanagerSecretState, value: seq<string * string>) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SecretsmanagerSecretState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret#tags_all-1">SecretsmanagerSecret#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SecretsmanagerSecretState, value: seq<string * string>) : SecretsmanagerSecretState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SecretsmanagerSecretState

        member _.Run(state: SecretsmanagerSecretState) : aws.SecretsmanagerSecret.SecretsmanagerSecret =
            let config = aws.SecretsmanagerSecret.SecretsmanagerSecretConfig()
            for setter in state.assignments do
                setter config
            aws.SecretsmanagerSecret.SecretsmanagerSecret(StackContext.get (), logicalId, config)
