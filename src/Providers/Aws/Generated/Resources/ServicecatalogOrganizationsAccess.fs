namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogOrganizationsAccessState<'Enabled> = { assignments: ResizeArray<aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access">aws_servicecatalog_organizations_access</a>.
    /// </summary>
    type ServicecatalogOrganizationsAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogOrganizationsAccessState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogOrganizationsAccessState<Missing>)

        member _.Zero(()) : ServicecatalogOrganizationsAccessState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogOrganizationsAccessState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#enabled-1">ServicecatalogOrganizationsAccess#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ServicecatalogOrganizationsAccessState<Missing>, value: bool) : ServicecatalogOrganizationsAccessState<Present> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : ServicecatalogOrganizationsAccessState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#enabled-1">ServicecatalogOrganizationsAccess#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ServicecatalogOrganizationsAccessState<Missing>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogOrganizationsAccessState<Present> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : ServicecatalogOrganizationsAccessState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#id-1">ServicecatalogOrganizationsAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogOrganizationsAccessState<'Enabled>, value: string) : ServicecatalogOrganizationsAccessState<'Enabled> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogOrganizationsAccessState<'Enabled>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#timeouts-1">ServicecatalogOrganizationsAccess#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogOrganizationsAccessState<'Enabled>, value: aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccessTimeouts) : ServicecatalogOrganizationsAccessState<'Enabled> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogOrganizationsAccessState<'Enabled>

        member _.Run(state: ServicecatalogOrganizationsAccessState<Present>) : aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccess =
            let config = aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccessConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogOrganizationsAccess: missing required arguments. Must call: enabled.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogOrganizationsAccessState<_>) : aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccess =
            Unchecked.defaultof<aws.ServicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccess>
