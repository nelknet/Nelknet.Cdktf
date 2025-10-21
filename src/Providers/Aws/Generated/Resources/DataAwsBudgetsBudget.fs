namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBudgetsBudgetState<'Name> = { assignments: ResizeArray<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget">aws_budgets_budget</a>.
    /// </summary>
    type DataAwsBudgetsBudgetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBudgetsBudgetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBudgetsBudgetState<Missing>)

        member _.Zero(()) : DataAwsBudgetsBudgetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBudgetsBudgetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget#name-1">DataAwsBudgetsBudget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsBudgetsBudgetState<Missing>, value: string) : DataAwsBudgetsBudgetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsBudgetsBudgetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget#account_id-1">DataAwsBudgetsBudget#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataAwsBudgetsBudgetState<'Name>, value: string) : DataAwsBudgetsBudgetState<'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : DataAwsBudgetsBudgetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget#id-1">DataAwsBudgetsBudget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBudgetsBudgetState<'Name>, value: string) : DataAwsBudgetsBudgetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBudgetsBudgetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget#name_prefix-1">DataAwsBudgetsBudget#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAwsBudgetsBudgetState<'Name>, value: string) : DataAwsBudgetsBudgetState<'Name> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAwsBudgetsBudgetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget#tags-1">DataAwsBudgetsBudget#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBudgetsBudgetState<'Name>, value: seq<string * string>) : DataAwsBudgetsBudgetState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBudgetsBudgetState<'Name>

        member _.Run(state: DataAwsBudgetsBudgetState<Present>) : aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget =
            let config = aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBudgetsBudget: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBudgetsBudgetState<_>) : aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget =
            Unchecked.defaultof<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget>
