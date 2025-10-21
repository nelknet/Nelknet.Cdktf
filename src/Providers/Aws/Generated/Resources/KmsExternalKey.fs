namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsExternalKeyState = { assignments: ResizeArray<aws.KmsExternalKey.KmsExternalKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key">aws_kms_external_key</a>.
    /// </summary>
    type KmsExternalKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsExternalKeyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : KmsExternalKeyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#bypass_policy_lockout_safety_check-1">KmsExternalKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsExternalKeyState, value: bool) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#bypass_policy_lockout_safety_check-1">KmsExternalKey#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsExternalKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#deletion_window_in_days-1">KmsExternalKey#deletion_window_in_days</a>.
        /// </summary>
        [<CustomOperation "deletion_window_in_days">]
        member _.DeletionWindowInDays(state: KmsExternalKeyState, value: double) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.DeletionWindowInDays <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#description-1">KmsExternalKey#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KmsExternalKeyState, value: string) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#enabled-1">KmsExternalKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: KmsExternalKeyState, value: bool) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#enabled-1">KmsExternalKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: KmsExternalKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#id-1">KmsExternalKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsExternalKeyState, value: string) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#key_material_base64-1">KmsExternalKey#key_material_base64</a>.
        /// </summary>
        [<CustomOperation "key_material_base64">]
        member _.KeyMaterialBase64(state: KmsExternalKeyState, value: string) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.KeyMaterialBase64 <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#multi_region-1">KmsExternalKey#multi_region</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_region">]
        member _.MultiRegion(state: KmsExternalKeyState, value: bool) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.MultiRegion <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#multi_region-1">KmsExternalKey#multi_region</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_region">]
        member _.MultiRegion(state: KmsExternalKeyState, value: HashiCorp.Cdktf.IResolvable) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.MultiRegion <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#policy-1">KmsExternalKey#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: KmsExternalKeyState, value: string) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#tags-1">KmsExternalKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KmsExternalKeyState, value: seq<string * string>) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#tags_all-1">KmsExternalKey#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KmsExternalKeyState, value: seq<string * string>) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KmsExternalKeyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_external_key#valid_to-1">KmsExternalKey#valid_to</a>.
        /// </summary>
        [<CustomOperation "valid_to">]
        member _.ValidTo(state: KmsExternalKeyState, value: string) : KmsExternalKeyState =
            state.assignments.Add(fun config -> config.ValidTo <- value)
            state : KmsExternalKeyState

        member _.Run(state: KmsExternalKeyState) : aws.KmsExternalKey.KmsExternalKey =
            let config = aws.KmsExternalKey.KmsExternalKeyConfig()
            for setter in state.assignments do
                setter config
            aws.KmsExternalKey.KmsExternalKey(StackContext.get (), logicalId, config)
