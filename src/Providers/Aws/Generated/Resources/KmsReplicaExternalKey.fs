namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsReplicaExternalKeyState<'PrimaryKeyArn> = { assignments: ResizeArray<aws.KmsReplicaExternalKey.KmsReplicaExternalKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key">aws_kms_replica_external_key</a>.
    /// </summary>
    type KmsReplicaExternalKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsReplicaExternalKeyState<Missing> =
            ({ assignments = ResizeArray() } : KmsReplicaExternalKeyState<Missing>)

        member _.Zero(()) : KmsReplicaExternalKeyState<Missing> =
            ({ assignments = ResizeArray() } : KmsReplicaExternalKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#primary_key_arn-1">KmsReplicaExternalKey#primary_key_arn</a>.
        /// </summary>
        [<CustomOperation "primary_key_arn">]
        member _.PrimaryKeyArn(state: KmsReplicaExternalKeyState<Missing>, value: string) : KmsReplicaExternalKeyState<Present> =
            state.assignments.Add(fun config -> config.PrimaryKeyArn <- value)
            ({ assignments = state.assignments } : KmsReplicaExternalKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#bypass_policy_lockout_safety_check-1">KmsReplicaExternalKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: bool) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#bypass_policy_lockout_safety_check-1">KmsReplicaExternalKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: HashiCorp.Cdktf.IResolvable) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#deletion_window_in_days-1">KmsReplicaExternalKey#deletion_window_in_days</a>.
        /// </summary>
        [<CustomOperation "deletion_window_in_days">]
        member _.DeletionWindowInDays(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: double) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.DeletionWindowInDays <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#description-1">KmsReplicaExternalKey#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#enabled-1">KmsReplicaExternalKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: bool) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#enabled-1">KmsReplicaExternalKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: HashiCorp.Cdktf.IResolvable) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#id-1">KmsReplicaExternalKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#key_material_base64-1">KmsReplicaExternalKey#key_material_base64</a>.
        /// </summary>
        [<CustomOperation "key_material_base64">]
        member _.KeyMaterialBase64(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.KeyMaterialBase64 <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#policy-1">KmsReplicaExternalKey#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#tags-1">KmsReplicaExternalKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: seq<string * string>) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#tags_all-1">KmsReplicaExternalKey#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: seq<string * string>) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_replica_external_key#valid_to-1">KmsReplicaExternalKey#valid_to</a>.
        /// </summary>
        [<CustomOperation "valid_to">]
        member _.ValidTo(state: KmsReplicaExternalKeyState<'PrimaryKeyArn>, value: string) : KmsReplicaExternalKeyState<'PrimaryKeyArn> =
            state.assignments.Add(fun config -> config.ValidTo <- value)
            state : KmsReplicaExternalKeyState<'PrimaryKeyArn>

        member _.Run(state: KmsReplicaExternalKeyState<Present>) : aws.KmsReplicaExternalKey.KmsReplicaExternalKey =
            let config = aws.KmsReplicaExternalKey.KmsReplicaExternalKeyConfig()
            for setter in state.assignments do
                setter config
            aws.KmsReplicaExternalKey.KmsReplicaExternalKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsReplicaExternalKey: missing required arguments. Must call: primary_key_arn.", 9999, IsError = true)>]
        member _.Run(_: KmsReplicaExternalKeyState<_>) : aws.KmsReplicaExternalKey.KmsReplicaExternalKey =
            Unchecked.defaultof<aws.KmsReplicaExternalKey.KmsReplicaExternalKey>
