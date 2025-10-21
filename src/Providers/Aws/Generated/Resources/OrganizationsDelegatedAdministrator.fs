namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsDelegatedAdministratorState<'AccountId, 'ServicePrincipal> = { assignments: ResizeArray<aws.OrganizationsDelegatedAdministrator.OrganizationsDelegatedAdministratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_delegated_administrator">aws_organizations_delegated_administrator</a>.
    /// </summary>
    type OrganizationsDelegatedAdministratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsDelegatedAdministratorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsDelegatedAdministratorState<Missing, Missing>)

        member _.Zero(()) : OrganizationsDelegatedAdministratorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsDelegatedAdministratorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_delegated_administrator#account_id-1">OrganizationsDelegatedAdministrator#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: OrganizationsDelegatedAdministratorState<Missing, 'ServicePrincipal>, value: string) : OrganizationsDelegatedAdministratorState<Present, 'ServicePrincipal> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : OrganizationsDelegatedAdministratorState<Present, 'ServicePrincipal>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_delegated_administrator#service_principal-1">OrganizationsDelegatedAdministrator#service_principal</a>.
        /// </summary>
        [<CustomOperation "service_principal">]
        member _.ServicePrincipal(state: OrganizationsDelegatedAdministratorState<'AccountId, Missing>, value: string) : OrganizationsDelegatedAdministratorState<'AccountId, Present> =
            state.assignments.Add(fun config -> config.ServicePrincipal <- value)
            ({ assignments = state.assignments } : OrganizationsDelegatedAdministratorState<'AccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_delegated_administrator#id-1">OrganizationsDelegatedAdministrator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsDelegatedAdministratorState<'AccountId, 'ServicePrincipal>, value: string) : OrganizationsDelegatedAdministratorState<'AccountId, 'ServicePrincipal> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsDelegatedAdministratorState<'AccountId, 'ServicePrincipal>

        member _.Run(state: OrganizationsDelegatedAdministratorState<Present, Present>) : aws.OrganizationsDelegatedAdministrator.OrganizationsDelegatedAdministrator =
            let config = aws.OrganizationsDelegatedAdministrator.OrganizationsDelegatedAdministratorConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsDelegatedAdministrator.OrganizationsDelegatedAdministrator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.organizationsDelegatedAdministrator: missing required arguments. Must call: account_id, service_principal.", 9999, IsError = true)>]
        member _.Run(_: OrganizationsDelegatedAdministratorState<_, _>) : aws.OrganizationsDelegatedAdministrator.OrganizationsDelegatedAdministrator =
            Unchecked.defaultof<aws.OrganizationsDelegatedAdministrator.OrganizationsDelegatedAdministrator>
