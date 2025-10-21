namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsDelegatedServicesState<'AccountId> = { assignments: ResizeArray<aws.DataAwsOrganizationsDelegatedServices.DataAwsOrganizationsDelegatedServicesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_delegated_services">aws_organizations_delegated_services</a>.
    /// </summary>
    type DataAwsOrganizationsDelegatedServicesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsDelegatedServicesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsDelegatedServicesState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsDelegatedServicesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsDelegatedServicesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_delegated_services#account_id-1">DataAwsOrganizationsDelegatedServices#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataAwsOrganizationsDelegatedServicesState<Missing>, value: string) : DataAwsOrganizationsDelegatedServicesState<Present> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsDelegatedServicesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_delegated_services#id-1">DataAwsOrganizationsDelegatedServices#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsDelegatedServicesState<'AccountId>, value: string) : DataAwsOrganizationsDelegatedServicesState<'AccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsDelegatedServicesState<'AccountId>

        member _.Run(state: DataAwsOrganizationsDelegatedServicesState<Present>) : aws.DataAwsOrganizationsDelegatedServices.DataAwsOrganizationsDelegatedServices =
            let config = aws.DataAwsOrganizationsDelegatedServices.DataAwsOrganizationsDelegatedServicesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsDelegatedServices.DataAwsOrganizationsDelegatedServices(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsDelegatedServices: missing required arguments. Must call: account_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsDelegatedServicesState<_>) : aws.DataAwsOrganizationsDelegatedServices.DataAwsOrganizationsDelegatedServices =
            Unchecked.defaultof<aws.DataAwsOrganizationsDelegatedServices.DataAwsOrganizationsDelegatedServices>
