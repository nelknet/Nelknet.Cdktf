namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventPermissionState<'Principal, 'StatementId> = { assignments: ResizeArray<aws.CloudwatchEventPermission.CloudwatchEventPermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission">aws_cloudwatch_event_permission</a>.
    /// </summary>
    type CloudwatchEventPermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventPermissionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventPermissionState<Missing, Missing>)

        member _.Zero(()) : CloudwatchEventPermissionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventPermissionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission#principal-1">CloudwatchEventPermission#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: CloudwatchEventPermissionState<Missing, 'StatementId>, value: string) : CloudwatchEventPermissionState<Present, 'StatementId> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : CloudwatchEventPermissionState<Present, 'StatementId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission#statement_id-1">CloudwatchEventPermission#statement_id</a>.
        /// </summary>
        [<CustomOperation "statement_id">]
        member _.StatementId(state: CloudwatchEventPermissionState<'Principal, Missing>, value: string) : CloudwatchEventPermissionState<'Principal, Present> =
            state.assignments.Add(fun config -> config.StatementId <- value)
            ({ assignments = state.assignments } : CloudwatchEventPermissionState<'Principal, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission#action-1">CloudwatchEventPermission#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: CloudwatchEventPermissionState<'Principal, 'StatementId>, value: string) : CloudwatchEventPermissionState<'Principal, 'StatementId> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : CloudwatchEventPermissionState<'Principal, 'StatementId>

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission#condition-1">CloudwatchEventPermission#condition</a>
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: CloudwatchEventPermissionState<'Principal, 'StatementId>, value: aws.CloudwatchEventPermission.CloudwatchEventPermissionCondition) : CloudwatchEventPermissionState<'Principal, 'StatementId> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : CloudwatchEventPermissionState<'Principal, 'StatementId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission#event_bus_name-1">CloudwatchEventPermission#event_bus_name</a>.
        /// </summary>
        [<CustomOperation "event_bus_name">]
        member _.EventBusName(state: CloudwatchEventPermissionState<'Principal, 'StatementId>, value: string) : CloudwatchEventPermissionState<'Principal, 'StatementId> =
            state.assignments.Add(fun config -> config.EventBusName <- value)
            state : CloudwatchEventPermissionState<'Principal, 'StatementId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_permission#id-1">CloudwatchEventPermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventPermissionState<'Principal, 'StatementId>, value: string) : CloudwatchEventPermissionState<'Principal, 'StatementId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventPermissionState<'Principal, 'StatementId>

        member _.Run(state: CloudwatchEventPermissionState<Present, Present>) : aws.CloudwatchEventPermission.CloudwatchEventPermission =
            let config = aws.CloudwatchEventPermission.CloudwatchEventPermissionConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventPermission.CloudwatchEventPermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventPermission: missing required arguments. Must call: principal, statement_id.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventPermissionState<_, _>) : aws.CloudwatchEventPermission.CloudwatchEventPermission =
            Unchecked.defaultof<aws.CloudwatchEventPermission.CloudwatchEventPermission>
