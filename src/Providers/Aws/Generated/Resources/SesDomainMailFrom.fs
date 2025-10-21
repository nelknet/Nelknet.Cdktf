namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesDomainMailFromState<'Domain, 'MailFromDomain> = { assignments: ResizeArray<aws.SesDomainMailFrom.SesDomainMailFromConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_mail_from">aws_ses_domain_mail_from</a>.
    /// </summary>
    type SesDomainMailFromBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesDomainMailFromState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SesDomainMailFromState<Missing, Missing>)

        member _.Zero(()) : SesDomainMailFromState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SesDomainMailFromState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_mail_from#domain-1">SesDomainMailFrom#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: SesDomainMailFromState<Missing, 'MailFromDomain>, value: string) : SesDomainMailFromState<Present, 'MailFromDomain> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : SesDomainMailFromState<Present, 'MailFromDomain>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_mail_from#mail_from_domain-1">SesDomainMailFrom#mail_from_domain</a>.
        /// </summary>
        [<CustomOperation "mail_from_domain">]
        member _.MailFromDomain(state: SesDomainMailFromState<'Domain, Missing>, value: string) : SesDomainMailFromState<'Domain, Present> =
            state.assignments.Add(fun config -> config.MailFromDomain <- value)
            ({ assignments = state.assignments } : SesDomainMailFromState<'Domain, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_mail_from#behavior_on_mx_failure-1">SesDomainMailFrom#behavior_on_mx_failure</a>.
        /// </summary>
        [<CustomOperation "behavior_on_mx_failure">]
        member _.BehaviorOnMxFailure(state: SesDomainMailFromState<'Domain, 'MailFromDomain>, value: string) : SesDomainMailFromState<'Domain, 'MailFromDomain> =
            state.assignments.Add(fun config -> config.BehaviorOnMxFailure <- value)
            state : SesDomainMailFromState<'Domain, 'MailFromDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_mail_from#id-1">SesDomainMailFrom#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesDomainMailFromState<'Domain, 'MailFromDomain>, value: string) : SesDomainMailFromState<'Domain, 'MailFromDomain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesDomainMailFromState<'Domain, 'MailFromDomain>

        member _.Run(state: SesDomainMailFromState<Present, Present>) : aws.SesDomainMailFrom.SesDomainMailFrom =
            let config = aws.SesDomainMailFrom.SesDomainMailFromConfig()
            for setter in state.assignments do
                setter config
            aws.SesDomainMailFrom.SesDomainMailFrom(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesDomainMailFrom: missing required arguments. Must call: domain, mail_from_domain.", 9999, IsError = true)>]
        member _.Run(_: SesDomainMailFromState<_, _>) : aws.SesDomainMailFrom.SesDomainMailFrom =
            Unchecked.defaultof<aws.SesDomainMailFrom.SesDomainMailFrom>
