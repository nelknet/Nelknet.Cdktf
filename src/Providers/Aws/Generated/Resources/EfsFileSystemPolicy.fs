namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EfsFileSystemPolicyState<'FileSystemId, 'Policy> = { assignments: ResizeArray<aws.EfsFileSystemPolicy.EfsFileSystemPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system_policy">aws_efs_file_system_policy</a>.
    /// </summary>
    type EfsFileSystemPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EfsFileSystemPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsFileSystemPolicyState<Missing, Missing>)

        member _.Zero(()) : EfsFileSystemPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsFileSystemPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system_policy#file_system_id-1">EfsFileSystemPolicy#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: EfsFileSystemPolicyState<Missing, 'Policy>, value: string) : EfsFileSystemPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : EfsFileSystemPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system_policy#policy-1">EfsFileSystemPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: EfsFileSystemPolicyState<'FileSystemId, Missing>, value: string) : EfsFileSystemPolicyState<'FileSystemId, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : EfsFileSystemPolicyState<'FileSystemId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system_policy#bypass_policy_lockout_safety_check-1">EfsFileSystemPolicy#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: EfsFileSystemPolicyState<'FileSystemId, 'Policy>, value: bool) : EfsFileSystemPolicyState<'FileSystemId, 'Policy> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : EfsFileSystemPolicyState<'FileSystemId, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system_policy#bypass_policy_lockout_safety_check-1">EfsFileSystemPolicy#bypass_policy_lockout_safety_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_safety_check">]
        member _.BypassPolicyLockoutSafetyCheck(state: EfsFileSystemPolicyState<'FileSystemId, 'Policy>, value: HashiCorp.Cdktf.IResolvable) : EfsFileSystemPolicyState<'FileSystemId, 'Policy> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutSafetyCheck <- value)
            state : EfsFileSystemPolicyState<'FileSystemId, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system_policy#id-1">EfsFileSystemPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EfsFileSystemPolicyState<'FileSystemId, 'Policy>, value: string) : EfsFileSystemPolicyState<'FileSystemId, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EfsFileSystemPolicyState<'FileSystemId, 'Policy>

        member _.Run(state: EfsFileSystemPolicyState<Present, Present>) : aws.EfsFileSystemPolicy.EfsFileSystemPolicy =
            let config = aws.EfsFileSystemPolicy.EfsFileSystemPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EfsFileSystemPolicy.EfsFileSystemPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.efsFileSystemPolicy: missing required arguments. Must call: file_system_id, policy.", 9999, IsError = true)>]
        member _.Run(_: EfsFileSystemPolicyState<_, _>) : aws.EfsFileSystemPolicy.EfsFileSystemPolicy =
            Unchecked.defaultof<aws.EfsFileSystemPolicy.EfsFileSystemPolicy>
