namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association">azurerm_palo_alto_local_rulestack_outbound_trust_certificate_association</a>.
    /// </summary>
    type PaloAltoLocalRulestackOutboundTrustCertificateAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#certificate_id-1">PaloAltoLocalRulestackOutboundTrustCertificateAssociation#certificate_id</a>.
        /// </summary>
        [<CustomOperation "certificate_id">]
        member _.CertificateId(state: PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Missing>, value: string) : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Present> =
            state.assignments.Add(fun config -> config.CertificateId <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#id-1">PaloAltoLocalRulestackOutboundTrustCertificateAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId>, value: string) : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#timeouts-1">PaloAltoLocalRulestackOutboundTrustCertificateAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId>, value: azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts) : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<'CertificateId>

        member _.Run(state: PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<Present>) : azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociation =
            let config = azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestackOutboundTrustCertificateAssociation: missing required arguments. Must call: certificate_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackOutboundTrustCertificateAssociationState<_>) : azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociation =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociation>
