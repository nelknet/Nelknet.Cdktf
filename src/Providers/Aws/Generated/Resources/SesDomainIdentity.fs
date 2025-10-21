namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesDomainIdentityState<'Domain> = { assignments: ResizeArray<aws.SesDomainIdentity.SesDomainIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity">aws_ses_domain_identity</a>.
    /// </summary>
    type SesDomainIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesDomainIdentityState<Missing> =
            ({ assignments = ResizeArray() } : SesDomainIdentityState<Missing>)

        member _.Zero(()) : SesDomainIdentityState<Missing> =
            ({ assignments = ResizeArray() } : SesDomainIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity#domain-1">SesDomainIdentity#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: SesDomainIdentityState<Missing>, value: string) : SesDomainIdentityState<Present> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : SesDomainIdentityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity#id-1">SesDomainIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesDomainIdentityState<'Domain>, value: string) : SesDomainIdentityState<'Domain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesDomainIdentityState<'Domain>

        member _.Run(state: SesDomainIdentityState<Present>) : aws.SesDomainIdentity.SesDomainIdentity =
            let config = aws.SesDomainIdentity.SesDomainIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.SesDomainIdentity.SesDomainIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesDomainIdentity: missing required arguments. Must call: domain.", 9999, IsError = true)>]
        member _.Run(_: SesDomainIdentityState<_>) : aws.SesDomainIdentity.SesDomainIdentity =
            Unchecked.defaultof<aws.SesDomainIdentity.SesDomainIdentity>
