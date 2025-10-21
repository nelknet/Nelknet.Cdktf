namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLicensemanagerGrantsState = { assignments: ResizeArray<aws.DataAwsLicensemanagerGrants.DataAwsLicensemanagerGrantsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants">aws_licensemanager_grants</a>.
    /// </summary>
    type DataAwsLicensemanagerGrantsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLicensemanagerGrantsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLicensemanagerGrantsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#filter-1">DataAwsLicensemanagerGrants#filter</a> Accepts: aws.IResolvable | aws.DataAwsLicensemanagerGrants.DataAwsLicensemanagerGrantsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsLicensemanagerGrantsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsLicensemanagerGrantsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsLicensemanagerGrantsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#id-1">DataAwsLicensemanagerGrants#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLicensemanagerGrantsState, value: string) : DataAwsLicensemanagerGrantsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLicensemanagerGrantsState

        member _.Run(state: DataAwsLicensemanagerGrantsState) : aws.DataAwsLicensemanagerGrants.DataAwsLicensemanagerGrants =
            let config = aws.DataAwsLicensemanagerGrants.DataAwsLicensemanagerGrantsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLicensemanagerGrants.DataAwsLicensemanagerGrants(StackContext.get (), logicalId, config)
