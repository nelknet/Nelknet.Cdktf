namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Resourceexplorer2ViewState<'Name> = { assignments: ResizeArray<aws.Resourceexplorer2View.Resourceexplorer2ViewConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view">aws_resourceexplorer2_view</a>.
    /// </summary>
    type Resourceexplorer2ViewBuilder(logicalId: string) =
        member _.Yield(_: unit) : Resourceexplorer2ViewState<Missing> =
            ({ assignments = ResizeArray() } : Resourceexplorer2ViewState<Missing>)

        member _.Zero(()) : Resourceexplorer2ViewState<Missing> =
            ({ assignments = ResizeArray() } : Resourceexplorer2ViewState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#name-1">Resourceexplorer2View#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Resourceexplorer2ViewState<Missing>, value: string) : Resourceexplorer2ViewState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Resourceexplorer2ViewState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#default_view-1">Resourceexplorer2View#default_view</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_view">]
        member _.DefaultView(state: Resourceexplorer2ViewState<'Name>, value: bool) : Resourceexplorer2ViewState<'Name> =
            state.assignments.Add(fun config -> config.DefaultView <- value)
            state : Resourceexplorer2ViewState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#default_view-1">Resourceexplorer2View#default_view</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_view">]
        member _.DefaultView(state: Resourceexplorer2ViewState<'Name>, value: HashiCorp.Cdktf.IResolvable) : Resourceexplorer2ViewState<'Name> =
            state.assignments.Add(fun config -> config.DefaultView <- value)
            state : Resourceexplorer2ViewState<'Name>

        /// <summary>
        /// filters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#filters-1">Resourceexplorer2View#filters</a> Accepts: aws.IResolvable | aws.Resourceexplorer2View.Resourceexplorer2ViewFilters[]
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: Resourceexplorer2ViewState<'Name>, value: HashiCorp.Cdktf.IResolvable) : Resourceexplorer2ViewState<'Name> =
            state.assignments.Add(fun config -> config.Filters <- value)
            state : Resourceexplorer2ViewState<'Name>

        /// <summary>
        /// included_property block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#included_property-1">Resourceexplorer2View#included_property</a> Accepts: aws.IResolvable | aws.Resourceexplorer2View.Resourceexplorer2ViewIncludedProperty[]
        /// </summary>
        [<CustomOperation "included_property">]
        member _.IncludedProperty(state: Resourceexplorer2ViewState<'Name>, value: HashiCorp.Cdktf.IResolvable) : Resourceexplorer2ViewState<'Name> =
            state.assignments.Add(fun config -> config.IncludedProperty <- value)
            state : Resourceexplorer2ViewState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#scope-1">Resourceexplorer2View#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: Resourceexplorer2ViewState<'Name>, value: string) : Resourceexplorer2ViewState<'Name> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : Resourceexplorer2ViewState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#tags-1">Resourceexplorer2View#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Resourceexplorer2ViewState<'Name>, value: seq<string * string>) : Resourceexplorer2ViewState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Resourceexplorer2ViewState<'Name>

        member _.Run(state: Resourceexplorer2ViewState<Present>) : aws.Resourceexplorer2View.Resourceexplorer2View =
            let config = aws.Resourceexplorer2View.Resourceexplorer2ViewConfig()
            for setter in state.assignments do
                setter config
            aws.Resourceexplorer2View.Resourceexplorer2View(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.resourceexplorer2View: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Resourceexplorer2ViewState<_>) : aws.Resourceexplorer2View.Resourceexplorer2View =
            Unchecked.defaultof<aws.Resourceexplorer2View.Resourceexplorer2View>
