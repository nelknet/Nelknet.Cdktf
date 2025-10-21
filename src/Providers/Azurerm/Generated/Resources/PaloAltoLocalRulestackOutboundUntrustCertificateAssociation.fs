namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association">azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association</a>.
    /// </summary>
    type PaloAltoLocalRulestackOutboundUntrustCertificateAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association#certificate_id-1">PaloAltoLocalRulestackOutboundUntrustCertificateAssociation#certificate_id</a>.
        /// </summary>
        [<CustomOperation "certificate_id">]
        member _.CertificateId(state: PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Missing>, value: string) : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Present> =
            state.assignments.Add(fun config -> config.CertificateId <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association#id-1">PaloAltoLocalRulestackOutboundUntrustCertificateAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId>, value: string) : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association#timeouts-1">PaloAltoLocalRulestackOutboundUntrustCertificateAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId>, value: azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeouts) : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<'CertificateId>

        member _.Run(state: PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<Present>) : azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation =
            let config = azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestackOutboundUntrustCertificateAssociation: missing required arguments. Must call: certificate_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackOutboundUntrustCertificateAssociationState<_>) : azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation>
