namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2SerialConsoleAccessState = { assignments: ResizeArray<aws.Ec2SerialConsoleAccess.Ec2SerialConsoleAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_serial_console_access">aws_ec2_serial_console_access</a>.
    /// </summary>
    type Ec2SerialConsoleAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2SerialConsoleAccessState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Ec2SerialConsoleAccessState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_serial_console_access#enabled-1">Ec2SerialConsoleAccess#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: Ec2SerialConsoleAccessState, value: bool) : Ec2SerialConsoleAccessState =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : Ec2SerialConsoleAccessState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_serial_console_access#enabled-1">Ec2SerialConsoleAccess#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: Ec2SerialConsoleAccessState, value: HashiCorp.Cdktf.IResolvable) : Ec2SerialConsoleAccessState =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : Ec2SerialConsoleAccessState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_serial_console_access#id-1">Ec2SerialConsoleAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2SerialConsoleAccessState, value: string) : Ec2SerialConsoleAccessState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2SerialConsoleAccessState

        member _.Run(state: Ec2SerialConsoleAccessState) : aws.Ec2SerialConsoleAccess.Ec2SerialConsoleAccess =
            let config = aws.Ec2SerialConsoleAccess.Ec2SerialConsoleAccessConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2SerialConsoleAccess.Ec2SerialConsoleAccess(StackContext.get (), logicalId, config)
