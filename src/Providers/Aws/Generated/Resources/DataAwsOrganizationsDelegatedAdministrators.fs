namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsDelegatedAdministratorsState = { assignments: ResizeArray<aws.DataAwsOrganizationsDelegatedAdministrators.DataAwsOrganizationsDelegatedAdministratorsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_delegated_administrators">aws_organizations_delegated_administrators</a>.
    /// </summary>
    type DataAwsOrganizationsDelegatedAdministratorsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsDelegatedAdministratorsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsOrganizationsDelegatedAdministratorsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_delegated_administrators#id-1">DataAwsOrganizationsDelegatedAdministrators#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsDelegatedAdministratorsState, value: string) : DataAwsOrganizationsDelegatedAdministratorsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsDelegatedAdministratorsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_delegated_administrators#service_principal-1">DataAwsOrganizationsDelegatedAdministrators#service_principal</a>.
        /// </summary>
        [<CustomOperation "service_principal">]
        member _.ServicePrincipal(state: DataAwsOrganizationsDelegatedAdministratorsState, value: string) : DataAwsOrganizationsDelegatedAdministratorsState =
            state.assignments.Add(fun config -> config.ServicePrincipal <- value)
            state : DataAwsOrganizationsDelegatedAdministratorsState

        member _.Run(state: DataAwsOrganizationsDelegatedAdministratorsState) : aws.DataAwsOrganizationsDelegatedAdministrators.DataAwsOrganizationsDelegatedAdministrators =
            let config = aws.DataAwsOrganizationsDelegatedAdministrators.DataAwsOrganizationsDelegatedAdministratorsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsDelegatedAdministrators.DataAwsOrganizationsDelegatedAdministrators(StackContext.get (), logicalId, config)
