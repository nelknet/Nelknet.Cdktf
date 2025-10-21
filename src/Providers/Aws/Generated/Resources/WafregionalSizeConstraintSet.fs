namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalSizeConstraintSetState<'Name> = { assignments: ResizeArray<aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_size_constraint_set">aws_wafregional_size_constraint_set</a>.
    /// </summary>
    type WafregionalSizeConstraintSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalSizeConstraintSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalSizeConstraintSetState<Missing>)

        member _.Zero(()) : WafregionalSizeConstraintSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalSizeConstraintSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_size_constraint_set#name-1">WafregionalSizeConstraintSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalSizeConstraintSetState<Missing>, value: string) : WafregionalSizeConstraintSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalSizeConstraintSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_size_constraint_set#id-1">WafregionalSizeConstraintSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalSizeConstraintSetState<'Name>, value: string) : WafregionalSizeConstraintSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalSizeConstraintSetState<'Name>

        /// <summary>
        /// size_constraints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_size_constraint_set#size_constraints-1">WafregionalSizeConstraintSet#size_constraints</a> Accepts: aws.IResolvable | aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSetSizeConstraints[]
        /// </summary>
        [<CustomOperation "size_constraints">]
        member _.SizeConstraints(state: WafregionalSizeConstraintSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalSizeConstraintSetState<'Name> =
            state.assignments.Add(fun config -> config.SizeConstraints <- value)
            state : WafregionalSizeConstraintSetState<'Name>

        member _.Run(state: WafregionalSizeConstraintSetState<Present>) : aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSet =
            let config = aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalSizeConstraintSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalSizeConstraintSetState<_>) : aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSet =
            Unchecked.defaultof<aws.WafregionalSizeConstraintSet.WafregionalSizeConstraintSet>
