namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53DomainsDelegationSignerRecordState<'DomainName> = { assignments: ResizeArray<aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record">aws_route53domains_delegation_signer_record</a>.
    /// </summary>
    type Route53DomainsDelegationSignerRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53DomainsDelegationSignerRecordState<Missing> =
            ({ assignments = ResizeArray() } : Route53DomainsDelegationSignerRecordState<Missing>)

        member _.Zero(()) : Route53DomainsDelegationSignerRecordState<Missing> =
            ({ assignments = ResizeArray() } : Route53DomainsDelegationSignerRecordState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#domain_name-1">Route53DomainsDelegationSignerRecord#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Route53DomainsDelegationSignerRecordState<Missing>, value: string) : Route53DomainsDelegationSignerRecordState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Route53DomainsDelegationSignerRecordState<Present>)

        /// <summary>
        /// signing_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#signing_attributes-1">Route53DomainsDelegationSignerRecord#signing_attributes</a> Accepts: aws.IResolvable | aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes[]
        /// </summary>
        [<CustomOperation "signing_attributes">]
        member _.SigningAttributes(state: Route53DomainsDelegationSignerRecordState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : Route53DomainsDelegationSignerRecordState<'DomainName> =
            state.assignments.Add(fun config -> config.SigningAttributes <- value)
            state : Route53DomainsDelegationSignerRecordState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#timeouts-1">Route53DomainsDelegationSignerRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53DomainsDelegationSignerRecordState<'DomainName>, value: aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeouts) : Route53DomainsDelegationSignerRecordState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53DomainsDelegationSignerRecordState<'DomainName>

        member _.Run(state: Route53DomainsDelegationSignerRecordState<Present>) : aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord =
            let config = aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordConfig()
            for setter in state.assignments do
                setter config
            aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53DomainsDelegationSignerRecord: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: Route53DomainsDelegationSignerRecordState<_>) : aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord =
            Unchecked.defaultof<aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord>
