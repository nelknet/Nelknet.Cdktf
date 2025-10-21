namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmPatchGroupState<'BaselineId, 'PatchGroup> = { assignments: ResizeArray<aws.SsmPatchGroup.SsmPatchGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_group">aws_ssm_patch_group</a>.
    /// </summary>
    type SsmPatchGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmPatchGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmPatchGroupState<Missing, Missing>)

        member _.Zero(()) : SsmPatchGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmPatchGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_group#baseline_id-1">SsmPatchGroup#baseline_id</a>.
        /// </summary>
        [<CustomOperation "baseline_id">]
        member _.BaselineId(state: SsmPatchGroupState<Missing, 'PatchGroup>, value: string) : SsmPatchGroupState<Present, 'PatchGroup> =
            state.assignments.Add(fun config -> config.BaselineId <- value)
            ({ assignments = state.assignments } : SsmPatchGroupState<Present, 'PatchGroup>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_group#patch_group-1">SsmPatchGroup#patch_group</a>.
        /// </summary>
        [<CustomOperation "patch_group">]
        member _.PatchGroup(state: SsmPatchGroupState<'BaselineId, Missing>, value: string) : SsmPatchGroupState<'BaselineId, Present> =
            state.assignments.Add(fun config -> config.PatchGroup <- value)
            ({ assignments = state.assignments } : SsmPatchGroupState<'BaselineId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_group#id-1">SsmPatchGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmPatchGroupState<'BaselineId, 'PatchGroup>, value: string) : SsmPatchGroupState<'BaselineId, 'PatchGroup> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmPatchGroupState<'BaselineId, 'PatchGroup>

        member _.Run(state: SsmPatchGroupState<Present, Present>) : aws.SsmPatchGroup.SsmPatchGroup =
            let config = aws.SsmPatchGroup.SsmPatchGroupConfig()
            for setter in state.assignments do
                setter config
            aws.SsmPatchGroup.SsmPatchGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmPatchGroup: missing required arguments. Must call: baseline_id, patch_group.", 9999, IsError = true)>]
        member _.Run(_: SsmPatchGroupState<_, _>) : aws.SsmPatchGroup.SsmPatchGroup =
            Unchecked.defaultof<aws.SsmPatchGroup.SsmPatchGroup>
