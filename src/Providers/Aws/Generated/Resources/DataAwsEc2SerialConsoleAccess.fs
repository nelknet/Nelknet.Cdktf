namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2SerialConsoleAccessState = { assignments: ResizeArray<aws.DataAwsEc2SerialConsoleAccess.DataAwsEc2SerialConsoleAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_serial_console_access">aws_ec2_serial_console_access</a>.
    /// </summary>
    type DataAwsEc2SerialConsoleAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2SerialConsoleAccessState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2SerialConsoleAccessState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_serial_console_access#id-1">DataAwsEc2SerialConsoleAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2SerialConsoleAccessState, value: string) : DataAwsEc2SerialConsoleAccessState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2SerialConsoleAccessState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_serial_console_access#timeouts-1">DataAwsEc2SerialConsoleAccess#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2SerialConsoleAccessState, value: aws.DataAwsEc2SerialConsoleAccess.DataAwsEc2SerialConsoleAccessTimeouts) : DataAwsEc2SerialConsoleAccessState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2SerialConsoleAccessState

        member _.Run(state: DataAwsEc2SerialConsoleAccessState) : aws.DataAwsEc2SerialConsoleAccess.DataAwsEc2SerialConsoleAccess =
            let config = aws.DataAwsEc2SerialConsoleAccess.DataAwsEc2SerialConsoleAccessConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2SerialConsoleAccess.DataAwsEc2SerialConsoleAccess(StackContext.get (), logicalId, config)
