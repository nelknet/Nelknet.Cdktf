namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53DomainsDomainState<'DomainName> = { assignments: ResizeArray<aws.Route53DomainsDomain.Route53DomainsDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain">aws_route53domains_domain</a>.
    /// </summary>
    type Route53DomainsDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53DomainsDomainState<Missing> =
            ({ assignments = ResizeArray() } : Route53DomainsDomainState<Missing>)

        member _.Zero(()) : Route53DomainsDomainState<Missing> =
            ({ assignments = ResizeArray() } : Route53DomainsDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#domain_name-1">Route53DomainsDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Route53DomainsDomainState<Missing>, value: string) : Route53DomainsDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Route53DomainsDomainState<Present>)

        /// <summary>
        /// admin_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#admin_contact-1">Route53DomainsDomain#admin_contact</a> Accepts: aws.IResolvable | aws.Route53DomainsDomain.Route53DomainsDomainAdminContact[]
        /// </summary>
        [<CustomOperation "admin_contact">]
        member _.AdminContact(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdminContact <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#admin_privacy-1">Route53DomainsDomain#admin_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "admin_privacy">]
        member _.AdminPrivacy(state: Route53DomainsDomainState<'DomainName>, value: bool) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdminPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#admin_privacy-1">Route53DomainsDomain#admin_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "admin_privacy">]
        member _.AdminPrivacy(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdminPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#auto_renew-1">Route53DomainsDomain#auto_renew</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: Route53DomainsDomainState<'DomainName>, value: bool) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#auto_renew-1">Route53DomainsDomain#auto_renew</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#billing_contact-1">Route53DomainsDomain#billing_contact</a>. Accepts: aws.IResolvable | aws.Route53DomainsDomain.Route53DomainsDomainBillingContact[]
        /// </summary>
        [<CustomOperation "billing_contact">]
        member _.BillingContact(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingContact <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#billing_privacy-1">Route53DomainsDomain#billing_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "billing_privacy">]
        member _.BillingPrivacy(state: Route53DomainsDomainState<'DomainName>, value: bool) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#billing_privacy-1">Route53DomainsDomain#billing_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "billing_privacy">]
        member _.BillingPrivacy(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#duration_in_years-1">Route53DomainsDomain#duration_in_years</a>.
        /// </summary>
        [<CustomOperation "duration_in_years">]
        member _.DurationInYears(state: Route53DomainsDomainState<'DomainName>, value: double) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.DurationInYears <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#name_server-1">Route53DomainsDomain#name_server</a>. Accepts: aws.IResolvable | aws.Route53DomainsDomain.Route53DomainsDomainNameServer[]
        /// </summary>
        [<CustomOperation "name_server">]
        member _.NameServer(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.NameServer <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// registrant_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#registrant_contact-1">Route53DomainsDomain#registrant_contact</a> Accepts: aws.IResolvable | aws.Route53DomainsDomain.Route53DomainsDomainRegistrantContact[]
        /// </summary>
        [<CustomOperation "registrant_contact">]
        member _.RegistrantContact(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.RegistrantContact <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#registrant_privacy-1">Route53DomainsDomain#registrant_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "registrant_privacy">]
        member _.RegistrantPrivacy(state: Route53DomainsDomainState<'DomainName>, value: bool) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.RegistrantPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#registrant_privacy-1">Route53DomainsDomain#registrant_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "registrant_privacy">]
        member _.RegistrantPrivacy(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.RegistrantPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#tags-1">Route53DomainsDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53DomainsDomainState<'DomainName>, value: seq<string * string>) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// tech_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#tech_contact-1">Route53DomainsDomain#tech_contact</a> Accepts: aws.IResolvable | aws.Route53DomainsDomain.Route53DomainsDomainTechContact[]
        /// </summary>
        [<CustomOperation "tech_contact">]
        member _.TechContact(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TechContact <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#tech_privacy-1">Route53DomainsDomain#tech_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tech_privacy">]
        member _.TechPrivacy(state: Route53DomainsDomainState<'DomainName>, value: bool) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TechPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#tech_privacy-1">Route53DomainsDomain#tech_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tech_privacy">]
        member _.TechPrivacy(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TechPrivacy <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#timeouts-1">Route53DomainsDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53DomainsDomainState<'DomainName>, value: aws.Route53DomainsDomain.Route53DomainsDomainTimeouts) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#transfer_lock-1">Route53DomainsDomain#transfer_lock</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transfer_lock">]
        member _.TransferLock(state: Route53DomainsDomainState<'DomainName>, value: bool) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TransferLock <- value)
            state : Route53DomainsDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_domain#transfer_lock-1">Route53DomainsDomain#transfer_lock</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transfer_lock">]
        member _.TransferLock(state: Route53DomainsDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TransferLock <- value)
            state : Route53DomainsDomainState<'DomainName>

        member _.Run(state: Route53DomainsDomainState<Present>) : aws.Route53DomainsDomain.Route53DomainsDomain =
            let config = aws.Route53DomainsDomain.Route53DomainsDomainConfig()
            for setter in state.assignments do
                setter config
            aws.Route53DomainsDomain.Route53DomainsDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53DomainsDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: Route53DomainsDomainState<_>) : aws.Route53DomainsDomain.Route53DomainsDomain =
            Unchecked.defaultof<aws.Route53DomainsDomain.Route53DomainsDomain>
