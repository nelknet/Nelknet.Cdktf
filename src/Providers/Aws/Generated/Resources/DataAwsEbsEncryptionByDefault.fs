namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEbsEncryptionByDefaultState = { assignments: ResizeArray<aws.DataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_encryption_by_default">aws_ebs_encryption_by_default</a>.
    /// </summary>
    type DataAwsEbsEncryptionByDefaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEbsEncryptionByDefaultState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEbsEncryptionByDefaultState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_encryption_by_default#id-1">DataAwsEbsEncryptionByDefault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEbsEncryptionByDefaultState, value: string) : DataAwsEbsEncryptionByDefaultState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEbsEncryptionByDefaultState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_encryption_by_default#timeouts-1">DataAwsEbsEncryptionByDefault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEbsEncryptionByDefaultState, value: aws.DataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefaultTimeouts) : DataAwsEbsEncryptionByDefaultState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEbsEncryptionByDefaultState

        member _.Run(state: DataAwsEbsEncryptionByDefaultState) : aws.DataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefault =
            let config = aws.DataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefaultConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefault(StackContext.get (), logicalId, config)
