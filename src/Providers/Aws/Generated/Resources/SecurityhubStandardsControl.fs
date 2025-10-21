namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn> = { assignments: ResizeArray<aws.SecurityhubStandardsControl.SecurityhubStandardsControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control">aws_securityhub_standards_control</a>.
    /// </summary>
    type SecurityhubStandardsControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubStandardsControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubStandardsControlState<Missing, Missing>)

        member _.Zero(()) : SecurityhubStandardsControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubStandardsControlState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control#control_status-1">SecurityhubStandardsControl#control_status</a>.
        /// </summary>
        [<CustomOperation "control_status">]
        member _.ControlStatus(state: SecurityhubStandardsControlState<Missing, 'StandardsControlArn>, value: string) : SecurityhubStandardsControlState<Present, 'StandardsControlArn> =
            state.assignments.Add(fun config -> config.ControlStatus <- value)
            ({ assignments = state.assignments } : SecurityhubStandardsControlState<Present, 'StandardsControlArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control#standards_control_arn-1">SecurityhubStandardsControl#standards_control_arn</a>.
        /// </summary>
        [<CustomOperation "standards_control_arn">]
        member _.StandardsControlArn(state: SecurityhubStandardsControlState<'ControlStatus, Missing>, value: string) : SecurityhubStandardsControlState<'ControlStatus, Present> =
            state.assignments.Add(fun config -> config.StandardsControlArn <- value)
            ({ assignments = state.assignments } : SecurityhubStandardsControlState<'ControlStatus, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control#disabled_reason-1">SecurityhubStandardsControl#disabled_reason</a>.
        /// </summary>
        [<CustomOperation "disabled_reason">]
        member _.DisabledReason(state: SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn>, value: string) : SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn> =
            state.assignments.Add(fun config -> config.DisabledReason <- value)
            state : SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control#id-1">SecurityhubStandardsControl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn>, value: string) : SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubStandardsControlState<'ControlStatus, 'StandardsControlArn>

        member _.Run(state: SecurityhubStandardsControlState<Present, Present>) : aws.SecurityhubStandardsControl.SecurityhubStandardsControl =
            let config = aws.SecurityhubStandardsControl.SecurityhubStandardsControlConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubStandardsControl.SecurityhubStandardsControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubStandardsControl: missing required arguments. Must call: control_status, standards_control_arn.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubStandardsControlState<_, _>) : aws.SecurityhubStandardsControl.SecurityhubStandardsControl =
            Unchecked.defaultof<aws.SecurityhubStandardsControl.SecurityhubStandardsControl>
