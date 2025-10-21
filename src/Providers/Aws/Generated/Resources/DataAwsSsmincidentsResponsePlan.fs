namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmincidentsResponsePlanState<'Arn> = { assignments: ResizeArray<aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_response_plan">aws_ssmincidents_response_plan</a>.
    /// </summary>
    type DataAwsSsmincidentsResponsePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmincidentsResponsePlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmincidentsResponsePlanState<Missing>)

        member _.Zero(()) : DataAwsSsmincidentsResponsePlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmincidentsResponsePlanState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_response_plan#arn-1">DataAwsSsmincidentsResponsePlan#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSsmincidentsResponsePlanState<Missing>, value: string) : DataAwsSsmincidentsResponsePlanState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsSsmincidentsResponsePlanState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_response_plan#id-1">DataAwsSsmincidentsResponsePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmincidentsResponsePlanState<'Arn>, value: string) : DataAwsSsmincidentsResponsePlanState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmincidentsResponsePlanState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_response_plan#tags-1">DataAwsSsmincidentsResponsePlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSsmincidentsResponsePlanState<'Arn>, value: seq<string * string>) : DataAwsSsmincidentsResponsePlanState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSsmincidentsResponsePlanState<'Arn>

        member _.Run(state: DataAwsSsmincidentsResponsePlanState<Present>) : aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlan =
            let config = aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlanConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmincidentsResponsePlan: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmincidentsResponsePlanState<_>) : aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlan =
            Unchecked.defaultof<aws.DataAwsSsmincidentsResponsePlan.DataAwsSsmincidentsResponsePlan>
