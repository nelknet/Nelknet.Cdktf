namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElbServiceAccountState = { assignments: ResizeArray<aws.DataAwsElbServiceAccount.DataAwsElbServiceAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb_service_account">aws_elb_service_account</a>.
    /// </summary>
    type DataAwsElbServiceAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElbServiceAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsElbServiceAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb_service_account#id-1">DataAwsElbServiceAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElbServiceAccountState, value: string) : DataAwsElbServiceAccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElbServiceAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb_service_account#region-1">DataAwsElbServiceAccount#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsElbServiceAccountState, value: string) : DataAwsElbServiceAccountState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsElbServiceAccountState

        member _.Run(state: DataAwsElbServiceAccountState) : aws.DataAwsElbServiceAccount.DataAwsElbServiceAccount =
            let config = aws.DataAwsElbServiceAccount.DataAwsElbServiceAccountConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElbServiceAccount.DataAwsElbServiceAccount(StackContext.get (), logicalId, config)
