namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmPatchBaselineState<'Owner> = { assignments: ResizeArray<aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline">aws_ssm_patch_baseline</a>.
    /// </summary>
    type DataAwsSsmPatchBaselineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmPatchBaselineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmPatchBaselineState<Missing>)

        member _.Zero(()) : DataAwsSsmPatchBaselineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmPatchBaselineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline#owner-1">DataAwsSsmPatchBaseline#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: DataAwsSsmPatchBaselineState<Missing>, value: string) : DataAwsSsmPatchBaselineState<Present> =
            state.assignments.Add(fun config -> config.Owner <- value)
            ({ assignments = state.assignments } : DataAwsSsmPatchBaselineState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline#default_baseline-1">DataAwsSsmPatchBaseline#default_baseline</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_baseline">]
        member _.DefaultBaseline(state: DataAwsSsmPatchBaselineState<'Owner>, value: bool) : DataAwsSsmPatchBaselineState<'Owner> =
            state.assignments.Add(fun config -> config.DefaultBaseline <- value)
            state : DataAwsSsmPatchBaselineState<'Owner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline#default_baseline-1">DataAwsSsmPatchBaseline#default_baseline</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_baseline">]
        member _.DefaultBaseline(state: DataAwsSsmPatchBaselineState<'Owner>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmPatchBaselineState<'Owner> =
            state.assignments.Add(fun config -> config.DefaultBaseline <- value)
            state : DataAwsSsmPatchBaselineState<'Owner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline#id-1">DataAwsSsmPatchBaseline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmPatchBaselineState<'Owner>, value: string) : DataAwsSsmPatchBaselineState<'Owner> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmPatchBaselineState<'Owner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline#name_prefix-1">DataAwsSsmPatchBaseline#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAwsSsmPatchBaselineState<'Owner>, value: string) : DataAwsSsmPatchBaselineState<'Owner> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAwsSsmPatchBaselineState<'Owner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baseline#operating_system-1">DataAwsSsmPatchBaseline#operating_system</a>.
        /// </summary>
        [<CustomOperation "operating_system">]
        member _.OperatingSystem(state: DataAwsSsmPatchBaselineState<'Owner>, value: string) : DataAwsSsmPatchBaselineState<'Owner> =
            state.assignments.Add(fun config -> config.OperatingSystem <- value)
            state : DataAwsSsmPatchBaselineState<'Owner>

        member _.Run(state: DataAwsSsmPatchBaselineState<Present>) : aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaseline =
            let config = aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaselineConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaseline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmPatchBaseline: missing required arguments. Must call: owner.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmPatchBaselineState<_>) : aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaseline =
            Unchecked.defaultof<aws.DataAwsSsmPatchBaseline.DataAwsSsmPatchBaseline>
