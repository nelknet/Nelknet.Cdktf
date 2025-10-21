namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesDomainIdentityVerificationState<'Domain> = { assignments: ResizeArray<aws.SesDomainIdentityVerification.SesDomainIdentityVerificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification">aws_ses_domain_identity_verification</a>.
    /// </summary>
    type SesDomainIdentityVerificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesDomainIdentityVerificationState<Missing> =
            ({ assignments = ResizeArray() } : SesDomainIdentityVerificationState<Missing>)

        member _.Zero(()) : SesDomainIdentityVerificationState<Missing> =
            ({ assignments = ResizeArray() } : SesDomainIdentityVerificationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification#domain-1">SesDomainIdentityVerification#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: SesDomainIdentityVerificationState<Missing>, value: string) : SesDomainIdentityVerificationState<Present> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : SesDomainIdentityVerificationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification#id-1">SesDomainIdentityVerification#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesDomainIdentityVerificationState<'Domain>, value: string) : SesDomainIdentityVerificationState<'Domain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesDomainIdentityVerificationState<'Domain>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification#timeouts-1">SesDomainIdentityVerification#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SesDomainIdentityVerificationState<'Domain>, value: aws.SesDomainIdentityVerification.SesDomainIdentityVerificationTimeouts) : SesDomainIdentityVerificationState<'Domain> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SesDomainIdentityVerificationState<'Domain>

        member _.Run(state: SesDomainIdentityVerificationState<Present>) : aws.SesDomainIdentityVerification.SesDomainIdentityVerification =
            let config = aws.SesDomainIdentityVerification.SesDomainIdentityVerificationConfig()
            for setter in state.assignments do
                setter config
            aws.SesDomainIdentityVerification.SesDomainIdentityVerification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesDomainIdentityVerification: missing required arguments. Must call: domain.", 9999, IsError = true)>]
        member _.Run(_: SesDomainIdentityVerificationState<_>) : aws.SesDomainIdentityVerification.SesDomainIdentityVerification =
            Unchecked.defaultof<aws.SesDomainIdentityVerification.SesDomainIdentityVerification>
