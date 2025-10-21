namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalGeoMatchSetState<'Name> = { assignments: ResizeArray<aws.WafregionalGeoMatchSet.WafregionalGeoMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set">aws_wafregional_geo_match_set</a>.
    /// </summary>
    type WafregionalGeoMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalGeoMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalGeoMatchSetState<Missing>)

        member _.Zero(()) : WafregionalGeoMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalGeoMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#name-1">WafregionalGeoMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalGeoMatchSetState<Missing>, value: string) : WafregionalGeoMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalGeoMatchSetState<Present>)

        /// <summary>
        /// geo_match_constraint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#geo_match_constraint-1">WafregionalGeoMatchSet#geo_match_constraint</a> Accepts: aws.IResolvable | aws.WafregionalGeoMatchSet.WafregionalGeoMatchSetGeoMatchConstraint[]
        /// </summary>
        [<CustomOperation "geo_match_constraint">]
        member _.GeoMatchConstraint(state: WafregionalGeoMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalGeoMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.GeoMatchConstraint <- value)
            state : WafregionalGeoMatchSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#id-1">WafregionalGeoMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalGeoMatchSetState<'Name>, value: string) : WafregionalGeoMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalGeoMatchSetState<'Name>

        member _.Run(state: WafregionalGeoMatchSetState<Present>) : aws.WafregionalGeoMatchSet.WafregionalGeoMatchSet =
            let config = aws.WafregionalGeoMatchSet.WafregionalGeoMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalGeoMatchSet.WafregionalGeoMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalGeoMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalGeoMatchSetState<_>) : aws.WafregionalGeoMatchSet.WafregionalGeoMatchSet =
            Unchecked.defaultof<aws.WafregionalGeoMatchSet.WafregionalGeoMatchSet>
