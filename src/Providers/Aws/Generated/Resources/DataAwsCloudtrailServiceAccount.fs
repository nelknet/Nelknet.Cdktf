namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudtrailServiceAccountState = { assignments: ResizeArray<aws.DataAwsCloudtrailServiceAccount.DataAwsCloudtrailServiceAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudtrail_service_account">aws_cloudtrail_service_account</a>.
    /// </summary>
    type DataAwsCloudtrailServiceAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudtrailServiceAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudtrailServiceAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudtrail_service_account#id-1">DataAwsCloudtrailServiceAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudtrailServiceAccountState, value: string) : DataAwsCloudtrailServiceAccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudtrailServiceAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudtrail_service_account#region-1">DataAwsCloudtrailServiceAccount#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsCloudtrailServiceAccountState, value: string) : DataAwsCloudtrailServiceAccountState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsCloudtrailServiceAccountState

        member _.Run(state: DataAwsCloudtrailServiceAccountState) : aws.DataAwsCloudtrailServiceAccount.DataAwsCloudtrailServiceAccount =
            let config = aws.DataAwsCloudtrailServiceAccount.DataAwsCloudtrailServiceAccountConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudtrailServiceAccount.DataAwsCloudtrailServiceAccount(StackContext.get (), logicalId, config)
