namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmPatchBaselinesState = { assignments: ResizeArray<aws.DataAwsSsmPatchBaselines.DataAwsSsmPatchBaselinesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baselines">aws_ssm_patch_baselines</a>.
    /// </summary>
    type DataAwsSsmPatchBaselinesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmPatchBaselinesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSsmPatchBaselinesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baselines#default_baselines-1">DataAwsSsmPatchBaselines#default_baselines</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_baselines">]
        member _.DefaultBaselines(state: DataAwsSsmPatchBaselinesState, value: bool) : DataAwsSsmPatchBaselinesState =
            state.assignments.Add(fun config -> config.DefaultBaselines <- value)
            state : DataAwsSsmPatchBaselinesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baselines#default_baselines-1">DataAwsSsmPatchBaselines#default_baselines</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_baselines">]
        member _.DefaultBaselines(state: DataAwsSsmPatchBaselinesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmPatchBaselinesState =
            state.assignments.Add(fun config -> config.DefaultBaselines <- value)
            state : DataAwsSsmPatchBaselinesState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baselines#filter-1">DataAwsSsmPatchBaselines#filter</a> Accepts: aws.IResolvable | aws.DataAwsSsmPatchBaselines.DataAwsSsmPatchBaselinesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSsmPatchBaselinesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmPatchBaselinesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSsmPatchBaselinesState

        member _.Run(state: DataAwsSsmPatchBaselinesState) : aws.DataAwsSsmPatchBaselines.DataAwsSsmPatchBaselines =
            let config = aws.DataAwsSsmPatchBaselines.DataAwsSsmPatchBaselinesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmPatchBaselines.DataAwsSsmPatchBaselines(StackContext.get (), logicalId, config)
