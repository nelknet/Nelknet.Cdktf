namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLicensemanagerReceivedLicensesState = { assignments: ResizeArray<aws.DataAwsLicensemanagerReceivedLicenses.DataAwsLicensemanagerReceivedLicensesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_licenses">aws_licensemanager_received_licenses</a>.
    /// </summary>
    type DataAwsLicensemanagerReceivedLicensesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLicensemanagerReceivedLicensesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLicensemanagerReceivedLicensesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_licenses#filter-1">DataAwsLicensemanagerReceivedLicenses#filter</a> Accepts: aws.IResolvable | aws.DataAwsLicensemanagerReceivedLicenses.DataAwsLicensemanagerReceivedLicensesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsLicensemanagerReceivedLicensesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsLicensemanagerReceivedLicensesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsLicensemanagerReceivedLicensesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_licenses#id-1">DataAwsLicensemanagerReceivedLicenses#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLicensemanagerReceivedLicensesState, value: string) : DataAwsLicensemanagerReceivedLicensesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLicensemanagerReceivedLicensesState

        member _.Run(state: DataAwsLicensemanagerReceivedLicensesState) : aws.DataAwsLicensemanagerReceivedLicenses.DataAwsLicensemanagerReceivedLicenses =
            let config = aws.DataAwsLicensemanagerReceivedLicenses.DataAwsLicensemanagerReceivedLicensesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLicensemanagerReceivedLicenses.DataAwsLicensemanagerReceivedLicenses(StackContext.get (), logicalId, config)
