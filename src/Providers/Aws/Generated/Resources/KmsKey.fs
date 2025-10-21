namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsKeyState = { assignments: ResizeArray<aws.KmsKey.KmsKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key">aws_kms_key</a>.
    /// </summary>
    type KmsKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsKeyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : KmsKeyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#bypass_policy_lockout_safety_check-1">KmsKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsKeyState, value: bool) : KmsKeyState =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#bypass_policy_lockout_safety_check-1">KmsKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsKeyState =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#customer_master_key_spec-1">KmsKey#customer_master_key_spec</a>.
        /// </summary>
        [<CustomOperation "customer_master_key_spec">]
        member _.CustomerMasterKeySpec(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.CustomerMasterKeySpec <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#custom_key_store_id-1">KmsKey#custom_key_store_id</a>.
        /// </summary>
        [<CustomOperation "custom_key_store_id">]
        member _.CustomKeyStoreId(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.CustomKeyStoreId <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#deletion_window_in_days-1">KmsKey#deletion_window_in_days</a>.
        /// </summary>
        [<CustomOperation "deletion_window_in_days">]
        member _.DeletionWindowInDays(state: KmsKeyState, value: double) : KmsKeyState =
            state.assignments.Add(fun config -> config.DeletionWindowInDays <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#description-1">KmsKey#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#enable_key_rotation-1">KmsKey#enable_key_rotation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_key_rotation">]
        member _.EnableKeyRotation(state: KmsKeyState, value: bool) : KmsKeyState =
            state.assignments.Add(fun config -> config.EnableKeyRotation <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#enable_key_rotation-1">KmsKey#enable_key_rotation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_key_rotation">]
        member _.EnableKeyRotation(state: KmsKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsKeyState =
            state.assignments.Add(fun config -> config.EnableKeyRotation <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#id-1">KmsKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#is_enabled-1">KmsKey#is_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_enabled">]
        member _.IsEnabled(state: KmsKeyState, value: bool) : KmsKeyState =
            state.assignments.Add(fun config -> config.IsEnabled <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#is_enabled-1">KmsKey#is_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_enabled">]
        member _.IsEnabled(state: KmsKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsKeyState =
            state.assignments.Add(fun config -> config.IsEnabled <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#key_usage-1">KmsKey#key_usage</a>.
        /// </summary>
        [<CustomOperation "key_usage">]
        member _.KeyUsage(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.KeyUsage <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#multi_region-1">KmsKey#multi_region</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_region">]
        member _.MultiRegion(state: KmsKeyState, value: bool) : KmsKeyState =
            state.assignments.Add(fun config -> config.MultiRegion <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#multi_region-1">KmsKey#multi_region</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_region">]
        member _.MultiRegion(state: KmsKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsKeyState =
            state.assignments.Add(fun config -> config.MultiRegion <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#policy-1">KmsKey#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#rotation_period_in_days-1">KmsKey#rotation_period_in_days</a>.
        /// </summary>
        [<CustomOperation "rotation_period_in_days">]
        member _.RotationPeriodInDays(state: KmsKeyState, value: double) : KmsKeyState =
            state.assignments.Add(fun config -> config.RotationPeriodInDays <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#tags-1">KmsKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KmsKeyState, value: seq<string * string>) : KmsKeyState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#tags_all-1">KmsKey#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KmsKeyState, value: seq<string * string>) : KmsKeyState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KmsKeyState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#timeouts-1">KmsKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KmsKeyState, value: aws.KmsKey.KmsKeyTimeouts) : KmsKeyState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KmsKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key#xks_key_id-1">KmsKey#xks_key_id</a>.
        /// </summary>
        [<CustomOperation "xks_key_id">]
        member _.XksKeyId(state: KmsKeyState, value: string) : KmsKeyState =
            state.assignments.Add(fun config -> config.XksKeyId <- value)
            state : KmsKeyState

        member _.Run(state: KmsKeyState) : aws.KmsKey.KmsKey =
            let config = aws.KmsKey.KmsKeyConfig()
            for setter in state.assignments do
                setter config
            aws.KmsKey.KmsKey(StackContext.get (), logicalId, config)
