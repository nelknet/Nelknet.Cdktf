namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEbsDefaultKmsKeyState = { assignments: ResizeArray<aws.DataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_default_kms_key">aws_ebs_default_kms_key</a>.
    /// </summary>
    type DataAwsEbsDefaultKmsKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEbsDefaultKmsKeyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEbsDefaultKmsKeyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_default_kms_key#id-1">DataAwsEbsDefaultKmsKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEbsDefaultKmsKeyState, value: string) : DataAwsEbsDefaultKmsKeyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEbsDefaultKmsKeyState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_default_kms_key#timeouts-1">DataAwsEbsDefaultKmsKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEbsDefaultKmsKeyState, value: aws.DataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKeyTimeouts) : DataAwsEbsDefaultKmsKeyState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEbsDefaultKmsKeyState

        member _.Run(state: DataAwsEbsDefaultKmsKeyState) : aws.DataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKey =
            let config = aws.DataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKeyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKey(StackContext.get (), logicalId, config)
