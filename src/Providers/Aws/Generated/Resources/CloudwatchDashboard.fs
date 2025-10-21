namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchDashboardState<'DashboardBody, 'DashboardName> = { assignments: ResizeArray<aws.CloudwatchDashboard.CloudwatchDashboardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_dashboard">aws_cloudwatch_dashboard</a>.
    /// </summary>
    type CloudwatchDashboardBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchDashboardState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchDashboardState<Missing, Missing>)

        member _.Zero(()) : CloudwatchDashboardState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchDashboardState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_dashboard#dashboard_body-1">CloudwatchDashboard#dashboard_body</a>.
        /// </summary>
        [<CustomOperation "dashboard_body">]
        member _.DashboardBody(state: CloudwatchDashboardState<Missing, 'DashboardName>, value: string) : CloudwatchDashboardState<Present, 'DashboardName> =
            state.assignments.Add(fun config -> config.DashboardBody <- value)
            ({ assignments = state.assignments } : CloudwatchDashboardState<Present, 'DashboardName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_dashboard#dashboard_name-1">CloudwatchDashboard#dashboard_name</a>.
        /// </summary>
        [<CustomOperation "dashboard_name">]
        member _.DashboardName(state: CloudwatchDashboardState<'DashboardBody, Missing>, value: string) : CloudwatchDashboardState<'DashboardBody, Present> =
            state.assignments.Add(fun config -> config.DashboardName <- value)
            ({ assignments = state.assignments } : CloudwatchDashboardState<'DashboardBody, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_dashboard#id-1">CloudwatchDashboard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchDashboardState<'DashboardBody, 'DashboardName>, value: string) : CloudwatchDashboardState<'DashboardBody, 'DashboardName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchDashboardState<'DashboardBody, 'DashboardName>

        member _.Run(state: CloudwatchDashboardState<Present, Present>) : aws.CloudwatchDashboard.CloudwatchDashboard =
            let config = aws.CloudwatchDashboard.CloudwatchDashboardConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchDashboard.CloudwatchDashboard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchDashboard: missing required arguments. Must call: dashboard_body, dashboard_name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchDashboardState<_, _>) : aws.CloudwatchDashboard.CloudwatchDashboard =
            Unchecked.defaultof<aws.CloudwatchDashboard.CloudwatchDashboard>
