namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmDefaultPatchBaselineState<'BaselineId, 'OperatingSystem> = { assignments: ResizeArray<aws.SsmDefaultPatchBaseline.SsmDefaultPatchBaselineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_default_patch_baseline">aws_ssm_default_patch_baseline</a>.
    /// </summary>
    type SsmDefaultPatchBaselineBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmDefaultPatchBaselineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmDefaultPatchBaselineState<Missing, Missing>)

        member _.Zero(()) : SsmDefaultPatchBaselineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmDefaultPatchBaselineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_default_patch_baseline#baseline_id-1">SsmDefaultPatchBaseline#baseline_id</a>.
        /// </summary>
        [<CustomOperation "baseline_id">]
        member _.BaselineId(state: SsmDefaultPatchBaselineState<Missing, 'OperatingSystem>, value: string) : SsmDefaultPatchBaselineState<Present, 'OperatingSystem> =
            state.assignments.Add(fun config -> config.BaselineId <- value)
            ({ assignments = state.assignments } : SsmDefaultPatchBaselineState<Present, 'OperatingSystem>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_default_patch_baseline#operating_system-1">SsmDefaultPatchBaseline#operating_system</a>.
        /// </summary>
        [<CustomOperation "operating_system">]
        member _.OperatingSystem(state: SsmDefaultPatchBaselineState<'BaselineId, Missing>, value: string) : SsmDefaultPatchBaselineState<'BaselineId, Present> =
            state.assignments.Add(fun config -> config.OperatingSystem <- value)
            ({ assignments = state.assignments } : SsmDefaultPatchBaselineState<'BaselineId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_default_patch_baseline#id-1">SsmDefaultPatchBaseline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmDefaultPatchBaselineState<'BaselineId, 'OperatingSystem>, value: string) : SsmDefaultPatchBaselineState<'BaselineId, 'OperatingSystem> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmDefaultPatchBaselineState<'BaselineId, 'OperatingSystem>

        member _.Run(state: SsmDefaultPatchBaselineState<Present, Present>) : aws.SsmDefaultPatchBaseline.SsmDefaultPatchBaseline =
            let config = aws.SsmDefaultPatchBaseline.SsmDefaultPatchBaselineConfig()
            for setter in state.assignments do
                setter config
            aws.SsmDefaultPatchBaseline.SsmDefaultPatchBaseline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmDefaultPatchBaseline: missing required arguments. Must call: baseline_id, operating_system.", 9999, IsError = true)>]
        member _.Run(_: SsmDefaultPatchBaselineState<_, _>) : aws.SsmDefaultPatchBaseline.SsmDefaultPatchBaseline =
            Unchecked.defaultof<aws.SsmDefaultPatchBaseline.SsmDefaultPatchBaseline>
