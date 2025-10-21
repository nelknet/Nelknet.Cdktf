namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafSizeConstraintSetState<'Name> = { assignments: ResizeArray<aws.WafSizeConstraintSet.WafSizeConstraintSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set">aws_waf_size_constraint_set</a>.
    /// </summary>
    type WafSizeConstraintSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafSizeConstraintSetState<Missing> =
            ({ assignments = ResizeArray() } : WafSizeConstraintSetState<Missing>)

        member _.Zero(()) : WafSizeConstraintSetState<Missing> =
            ({ assignments = ResizeArray() } : WafSizeConstraintSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#name-1">WafSizeConstraintSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafSizeConstraintSetState<Missing>, value: string) : WafSizeConstraintSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafSizeConstraintSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#id-1">WafSizeConstraintSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafSizeConstraintSetState<'Name>, value: string) : WafSizeConstraintSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafSizeConstraintSetState<'Name>

        /// <summary>
        /// size_constraints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#size_constraints-1">WafSizeConstraintSet#size_constraints</a> Accepts: aws.IResolvable | aws.WafSizeConstraintSet.WafSizeConstraintSetSizeConstraints[]
        /// </summary>
        [<CustomOperation "size_constraints">]
        member _.SizeConstraints(state: WafSizeConstraintSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafSizeConstraintSetState<'Name> =
            state.assignments.Add(fun config -> config.SizeConstraints <- value)
            state : WafSizeConstraintSetState<'Name>

        member _.Run(state: WafSizeConstraintSetState<Present>) : aws.WafSizeConstraintSet.WafSizeConstraintSet =
            let config = aws.WafSizeConstraintSet.WafSizeConstraintSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafSizeConstraintSet.WafSizeConstraintSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafSizeConstraintSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafSizeConstraintSetState<_>) : aws.WafSizeConstraintSet.WafSizeConstraintSet =
            Unchecked.defaultof<aws.WafSizeConstraintSet.WafSizeConstraintSet>
