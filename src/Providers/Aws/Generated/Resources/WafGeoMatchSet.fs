namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafGeoMatchSetState<'Name> = { assignments: ResizeArray<aws.WafGeoMatchSet.WafGeoMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set">aws_waf_geo_match_set</a>.
    /// </summary>
    type WafGeoMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafGeoMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafGeoMatchSetState<Missing>)

        member _.Zero(()) : WafGeoMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafGeoMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#name-1">WafGeoMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafGeoMatchSetState<Missing>, value: string) : WafGeoMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafGeoMatchSetState<Present>)

        /// <summary>
        /// geo_match_constraint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#geo_match_constraint-1">WafGeoMatchSet#geo_match_constraint</a> Accepts: aws.IResolvable | aws.WafGeoMatchSet.WafGeoMatchSetGeoMatchConstraint[]
        /// </summary>
        [<CustomOperation "geo_match_constraint">]
        member _.GeoMatchConstraint(state: WafGeoMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafGeoMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.GeoMatchConstraint <- value)
            state : WafGeoMatchSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#id-1">WafGeoMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafGeoMatchSetState<'Name>, value: string) : WafGeoMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafGeoMatchSetState<'Name>

        member _.Run(state: WafGeoMatchSetState<Present>) : aws.WafGeoMatchSet.WafGeoMatchSet =
            let config = aws.WafGeoMatchSet.WafGeoMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafGeoMatchSet.WafGeoMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafGeoMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafGeoMatchSetState<_>) : aws.WafGeoMatchSet.WafGeoMatchSet =
            Unchecked.defaultof<aws.WafGeoMatchSet.WafGeoMatchSet>
