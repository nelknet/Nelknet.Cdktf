namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIotRegistrationCodeState = { assignments: ResizeArray<aws.DataAwsIotRegistrationCode.DataAwsIotRegistrationCodeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iot_registration_code">aws_iot_registration_code</a>.
    /// </summary>
    type DataAwsIotRegistrationCodeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIotRegistrationCodeState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIotRegistrationCodeState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iot_registration_code#id-1">DataAwsIotRegistrationCode#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIotRegistrationCodeState, value: string) : DataAwsIotRegistrationCodeState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIotRegistrationCodeState

        member _.Run(state: DataAwsIotRegistrationCodeState) : aws.DataAwsIotRegistrationCode.DataAwsIotRegistrationCode =
            let config = aws.DataAwsIotRegistrationCode.DataAwsIotRegistrationCodeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIotRegistrationCode.DataAwsIotRegistrationCode(StackContext.get (), logicalId, config)
