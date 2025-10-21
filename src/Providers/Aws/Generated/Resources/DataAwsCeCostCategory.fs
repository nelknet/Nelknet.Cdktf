namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCeCostCategoryState<'CostCategoryArn> = { assignments: ResizeArray<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_cost_category">aws_ce_cost_category</a>.
    /// </summary>
    type DataAwsCeCostCategoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCeCostCategoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCeCostCategoryState<Missing>)

        member _.Zero(()) : DataAwsCeCostCategoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCeCostCategoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_cost_category#cost_category_arn-1">DataAwsCeCostCategory#cost_category_arn</a>.
        /// </summary>
        [<CustomOperation "cost_category_arn">]
        member _.CostCategoryArn(state: DataAwsCeCostCategoryState<Missing>, value: string) : DataAwsCeCostCategoryState<Present> =
            state.assignments.Add(fun config -> config.CostCategoryArn <- value)
            ({ assignments = state.assignments } : DataAwsCeCostCategoryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_cost_category#id-1">DataAwsCeCostCategory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCeCostCategoryState<'CostCategoryArn>, value: string) : DataAwsCeCostCategoryState<'CostCategoryArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCeCostCategoryState<'CostCategoryArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_cost_category#tags-1">DataAwsCeCostCategory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCeCostCategoryState<'CostCategoryArn>, value: seq<string * string>) : DataAwsCeCostCategoryState<'CostCategoryArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCeCostCategoryState<'CostCategoryArn>

        member _.Run(state: DataAwsCeCostCategoryState<Present>) : aws.DataAwsCeCostCategory.DataAwsCeCostCategory =
            let config = aws.DataAwsCeCostCategory.DataAwsCeCostCategoryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCeCostCategory.DataAwsCeCostCategory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCeCostCategory: missing required arguments. Must call: cost_category_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCeCostCategoryState<_>) : aws.DataAwsCeCostCategory.DataAwsCeCostCategory =
            Unchecked.defaultof<aws.DataAwsCeCostCategory.DataAwsCeCostCategory>
