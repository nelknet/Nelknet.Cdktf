namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsKeyPolicyState<'KeyId, 'Policy> = { assignments: ResizeArray<aws.KmsKeyPolicy.KmsKeyPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key_policy">aws_kms_key_policy</a>.
    /// </summary>
    type KmsKeyPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsKeyPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KmsKeyPolicyState<Missing, Missing>)

        member _.Zero(()) : KmsKeyPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KmsKeyPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key_policy#key_id-1">KmsKeyPolicy#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: KmsKeyPolicyState<Missing, 'Policy>, value: string) : KmsKeyPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : KmsKeyPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key_policy#policy-1">KmsKeyPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: KmsKeyPolicyState<'KeyId, Missing>, value: string) : KmsKeyPolicyState<'KeyId, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : KmsKeyPolicyState<'KeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key_policy#bypass_policy_lockout_safety_check-1">KmsKeyPolicy#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsKeyPolicyState<'KeyId, 'Policy>, value: bool) : KmsKeyPolicyState<'KeyId, 'Policy> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsKeyPolicyState<'KeyId, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key_policy#bypass_policy_lockout_safety_check-1">KmsKeyPolicy#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: KmsKeyPolicyState<'KeyId, 'Policy>, value: HashiCorp.Cdktf.IResolvable) : KmsKeyPolicyState<'KeyId, 'Policy> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : KmsKeyPolicyState<'KeyId, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_key_policy#id-1">KmsKeyPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsKeyPolicyState<'KeyId, 'Policy>, value: string) : KmsKeyPolicyState<'KeyId, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsKeyPolicyState<'KeyId, 'Policy>

        member _.Run(state: KmsKeyPolicyState<Present, Present>) : aws.KmsKeyPolicy.KmsKeyPolicy =
            let config = aws.KmsKeyPolicy.KmsKeyPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.KmsKeyPolicy.KmsKeyPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsKeyPolicy: missing required arguments. Must call: key_id, policy.", 9999, IsError = true)>]
        member _.Run(_: KmsKeyPolicyState<_, _>) : aws.KmsKeyPolicy.KmsKeyPolicy =
            Unchecked.defaultof<aws.KmsKeyPolicy.KmsKeyPolicy>
