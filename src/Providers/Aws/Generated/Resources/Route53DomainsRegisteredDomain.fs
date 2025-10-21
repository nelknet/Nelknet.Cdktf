namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53DomainsRegisteredDomainState<'DomainName> = { assignments: ResizeArray<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain">aws_route53domains_registered_domain</a>.
    /// </summary>
    type Route53DomainsRegisteredDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53DomainsRegisteredDomainState<Missing> =
            ({ assignments = ResizeArray() } : Route53DomainsRegisteredDomainState<Missing>)

        member _.Zero(()) : Route53DomainsRegisteredDomainState<Missing> =
            ({ assignments = ResizeArray() } : Route53DomainsRegisteredDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#domain_name-1">Route53DomainsRegisteredDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Route53DomainsRegisteredDomainState<Missing>, value: string) : Route53DomainsRegisteredDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Route53DomainsRegisteredDomainState<Present>)

        /// <summary>
        /// admin_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#admin_contact-1">Route53DomainsRegisteredDomain#admin_contact</a>
        /// </summary>
        [<CustomOperation "admin_contact">]
        member _.AdminContact(state: Route53DomainsRegisteredDomainState<'DomainName>, value: aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContact) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdminContact <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#admin_privacy-1">Route53DomainsRegisteredDomain#admin_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "admin_privacy">]
        member _.AdminPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: bool) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdminPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#admin_privacy-1">Route53DomainsRegisteredDomain#admin_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "admin_privacy">]
        member _.AdminPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdminPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#auto_renew-1">Route53DomainsRegisteredDomain#auto_renew</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: Route53DomainsRegisteredDomainState<'DomainName>, value: bool) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#auto_renew-1">Route53DomainsRegisteredDomain#auto_renew</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// billing_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#billing_contact-1">Route53DomainsRegisteredDomain#billing_contact</a>
        /// </summary>
        [<CustomOperation "billing_contact">]
        member _.BillingContact(state: Route53DomainsRegisteredDomainState<'DomainName>, value: aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainBillingContact) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingContact <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#billing_privacy-1">Route53DomainsRegisteredDomain#billing_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "billing_privacy">]
        member _.BillingPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: bool) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#billing_privacy-1">Route53DomainsRegisteredDomain#billing_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "billing_privacy">]
        member _.BillingPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.BillingPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#id-1">Route53DomainsRegisteredDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53DomainsRegisteredDomainState<'DomainName>, value: string) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// name_server block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#name_server-1">Route53DomainsRegisteredDomain#name_server</a> Accepts: aws.IResolvable | aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServer[]
        /// </summary>
        [<CustomOperation "name_server">]
        member _.NameServer(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.NameServer <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// registrant_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#registrant_contact-1">Route53DomainsRegisteredDomain#registrant_contact</a>
        /// </summary>
        [<CustomOperation "registrant_contact">]
        member _.RegistrantContact(state: Route53DomainsRegisteredDomainState<'DomainName>, value: aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainRegistrantContact) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.RegistrantContact <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#registrant_privacy-1">Route53DomainsRegisteredDomain#registrant_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "registrant_privacy">]
        member _.RegistrantPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: bool) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.RegistrantPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#registrant_privacy-1">Route53DomainsRegisteredDomain#registrant_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "registrant_privacy">]
        member _.RegistrantPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.RegistrantPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#tags-1">Route53DomainsRegisteredDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53DomainsRegisteredDomainState<'DomainName>, value: seq<string * string>) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#tags_all-1">Route53DomainsRegisteredDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53DomainsRegisteredDomainState<'DomainName>, value: seq<string * string>) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// tech_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#tech_contact-1">Route53DomainsRegisteredDomain#tech_contact</a>
        /// </summary>
        [<CustomOperation "tech_contact">]
        member _.TechContact(state: Route53DomainsRegisteredDomainState<'DomainName>, value: aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTechContact) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TechContact <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#tech_privacy-1">Route53DomainsRegisteredDomain#tech_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tech_privacy">]
        member _.TechPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: bool) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TechPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#tech_privacy-1">Route53DomainsRegisteredDomain#tech_privacy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tech_privacy">]
        member _.TechPrivacy(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TechPrivacy <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#timeouts-1">Route53DomainsRegisteredDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53DomainsRegisteredDomainState<'DomainName>, value: aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTimeouts) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#transfer_lock-1">Route53DomainsRegisteredDomain#transfer_lock</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transfer_lock">]
        member _.TransferLock(state: Route53DomainsRegisteredDomainState<'DomainName>, value: bool) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TransferLock <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#transfer_lock-1">Route53DomainsRegisteredDomain#transfer_lock</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transfer_lock">]
        member _.TransferLock(state: Route53DomainsRegisteredDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsRegisteredDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TransferLock <- value)
            state : Route53DomainsRegisteredDomainState<'DomainName>

        member _.Run(state: Route53DomainsRegisteredDomainState<Present>) : aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain =
            let config = aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainConfig()
            for setter in state.assignments do
                setter config
            aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53DomainsRegisteredDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: Route53DomainsRegisteredDomainState<_>) : aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain =
            Unchecked.defaultof<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain>
