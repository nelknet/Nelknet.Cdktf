namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> = { assignments: ResizeArray<aws.CustomerprofilesDomain.CustomerprofilesDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain">aws_customerprofiles_domain</a>.
    /// </summary>
    type CustomerprofilesDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : CustomerprofilesDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CustomerprofilesDomainState<Missing, Missing>)

        member _.Zero(()) : CustomerprofilesDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CustomerprofilesDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#default_expiration_days-1">CustomerprofilesDomain#default_expiration_days</a>.
        /// </summary>
        [<CustomOperation "default_expiration_days">]
        member _.DefaultExpirationDays(state: CustomerprofilesDomainState<Missing, 'DomainName>, value: double) : CustomerprofilesDomainState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.DefaultExpirationDays <- value)
            ({ assignments = state.assignments } : CustomerprofilesDomainState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#domain_name-1">CustomerprofilesDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: CustomerprofilesDomainState<'DefaultExpirationDays, Missing>, value: string) : CustomerprofilesDomainState<'DefaultExpirationDays, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : CustomerprofilesDomainState<'DefaultExpirationDays, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#dead_letter_queue_url-1">CustomerprofilesDomain#dead_letter_queue_url</a>.
        /// </summary>
        [<CustomOperation "dead_letter_queue_url">]
        member _.DeadLetterQueueUrl(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: string) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.DeadLetterQueueUrl <- value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#default_encryption_key-1">CustomerprofilesDomain#default_encryption_key</a>.
        /// </summary>
        [<CustomOperation "default_encryption_key">]
        member _.DefaultEncryptionKey(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: string) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.DefaultEncryptionKey <- value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#id-1">CustomerprofilesDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: string) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        /// <summary>
        /// matching block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching-1">CustomerprofilesDomain#matching</a>
        /// </summary>
        [<CustomOperation "matching">]
        member _.Matching(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: aws.CustomerprofilesDomain.CustomerprofilesDomainMatching) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.Matching <- value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        /// <summary>
        /// rule_based_matching block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#rule_based_matching-1">CustomerprofilesDomain#rule_based_matching</a>
        /// </summary>
        [<CustomOperation "rule_based_matching">]
        member _.RuleBasedMatching(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatching) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.RuleBasedMatching <- value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#tags-1">CustomerprofilesDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: seq<string * string>) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#tags_all-1">CustomerprofilesDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>, value: seq<string * string>) : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CustomerprofilesDomainState<'DefaultExpirationDays, 'DomainName>

        member _.Run(state: CustomerprofilesDomainState<Present, Present>) : aws.CustomerprofilesDomain.CustomerprofilesDomain =
            let config = aws.CustomerprofilesDomain.CustomerprofilesDomainConfig()
            for setter in state.assignments do
                setter config
            aws.CustomerprofilesDomain.CustomerprofilesDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.customerprofilesDomain: missing required arguments. Must call: default_expiration_days, domain_name.", 9999, IsError = true)>]
        member _.Run(_: CustomerprofilesDomainState<_, _>) : aws.CustomerprofilesDomain.CustomerprofilesDomain =
            Unchecked.defaultof<aws.CustomerprofilesDomain.CustomerprofilesDomain>
