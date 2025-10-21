namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLicensemanagerReceivedLicenseState<'LicenseArn> = { assignments: ResizeArray<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_license">aws_licensemanager_received_license</a>.
    /// </summary>
    type DataAwsLicensemanagerReceivedLicenseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLicensemanagerReceivedLicenseState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLicensemanagerReceivedLicenseState<Missing>)

        member _.Zero(()) : DataAwsLicensemanagerReceivedLicenseState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLicensemanagerReceivedLicenseState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_license#license_arn-1">DataAwsLicensemanagerReceivedLicense#license_arn</a>.
        /// </summary>
        [<CustomOperation "license_arn">]
        member _.LicenseArn(state: DataAwsLicensemanagerReceivedLicenseState<Missing>, value: string) : DataAwsLicensemanagerReceivedLicenseState<Present> =
            state.assignments.Add(fun config -> config.LicenseArn <- value)
            ({ assignments = state.assignments } : DataAwsLicensemanagerReceivedLicenseState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_license#id-1">DataAwsLicensemanagerReceivedLicense#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLicensemanagerReceivedLicenseState<'LicenseArn>, value: string) : DataAwsLicensemanagerReceivedLicenseState<'LicenseArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLicensemanagerReceivedLicenseState<'LicenseArn>

        member _.Run(state: DataAwsLicensemanagerReceivedLicenseState<Present>) : aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense =
            let config = aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLicensemanagerReceivedLicense: missing required arguments. Must call: license_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLicensemanagerReceivedLicenseState<_>) : aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense =
            Unchecked.defaultof<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense>
