namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsReplicaKeyState<'PrimaryKeyArn> = { assignments: ResizeArray<aws.KmsReplicaKey.KmsReplicaKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key">aws_kms_replica_key</a>.
    /// </summary>
    type KmsReplicaKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsReplicaKeyState<Missing> =
            ({ assignments = ResizeArray() } : KmsReplicaKeyState<Missing>)

        member _.Zero(()) : KmsReplicaKeyState<Missing> =
            ({ assignments = ResizeArray() } : KmsReplicaKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#primary_key_arn-1">KmsReplicaKey#primary_key_arn</a>.
        /// </summary>
        [<CustomOperation "primary_key_arn">]
        member _.PrimaryKeyArn(state: KmsReplicaKeyState<Missing>, value: string) : KmsReplicaKeyState<Present> =
            state.assignments.Add(fun config -> config.PrimaryKeyArn <- value)
            ({ assignments = state.assignments } : KmsReplicaKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#bypass_policy_lockout_safety_check-1">KmsReplicaKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: bool) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#bypass_policy_lockout_safety_check-1">KmsReplicaKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: HashiCorp.Cdktf.IResolvable) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#deletion_window_in_days-1">KmsReplicaKey#deletion_window_in_days</a>.
        /// </summary>
        [<CustomOperation "deletion_window_in_days">]
        member _.DeletionWindowInDays(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: double) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.DeletionWindowInDays <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#description-1">KmsReplicaKey#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#enabled-1">KmsReplicaKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: bool) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#enabled-1">KmsReplicaKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: HashiCorp.Cdktf.IResolvable) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#id-1">KmsReplicaKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#policy-1">KmsReplicaKey#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#tags-1">KmsReplicaKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: seq<string * string>) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_key#tags_all-1">KmsReplicaKey#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KmsReplicaKeyState<'PrimaryKeyArn>, value: seq<string * string>) : KmsReplicaKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KmsReplicaKeyState<'PrimaryKeyArn>

        member _.Run(state: KmsReplicaKeyState<Present>) : aws.KmsReplicaKey.KmsReplicaKey =
            let config = aws.KmsReplicaKey.KmsReplicaKeyConfig()
            for setter in state.assignments do
                setter config
            aws.KmsReplicaKey.KmsReplicaKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsReplicaKey: missing required arguments. Must call: primary_key_arn.", 9999, IsError = true)>]
        member _.Run(_: KmsReplicaKeyState<_>) : aws.KmsReplicaKey.KmsReplicaKey =
            Unchecked.defaultof<aws.KmsReplicaKey.KmsReplicaKey>
