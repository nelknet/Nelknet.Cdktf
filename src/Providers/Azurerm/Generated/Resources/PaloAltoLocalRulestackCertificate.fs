namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate">azurerm_palo_alto_local_rulestack_certificate</a>.
    /// </summary>
    type PaloAltoLocalRulestackCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackCertificateState<Missing, Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#name-1">PaloAltoLocalRulestackCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoLocalRulestackCertificateState<Missing, 'RulestackId>, value: string) : PaloAltoLocalRulestackCertificateState<Present, 'RulestackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackCertificateState<Present, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#rulestack_id-1">PaloAltoLocalRulestackCertificate#rulestack_id</a>.
        /// </summary>
        [<CustomOperation "rulestack_id">]
        member _.RulestackId(state: PaloAltoLocalRulestackCertificateState<'Name, Missing>, value: string) : PaloAltoLocalRulestackCertificateState<'Name, Present> =
            state.assignments.Add(fun config -> config.RulestackId <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackCertificateState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#audit_comment-1">PaloAltoLocalRulestackCertificate#audit_comment</a>.
        /// </summary>
        [<CustomOperation "audit_comment">]
        member _.AuditComment(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.AuditComment <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#description-1">PaloAltoLocalRulestackCertificate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#id-1">PaloAltoLocalRulestackCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#key_vault_certificate_id-1">PaloAltoLocalRulestackCertificate#key_vault_certificate_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_certificate_id">]
        member _.KeyVaultCertificateId(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.KeyVaultCertificateId <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#self_signed-1">PaloAltoLocalRulestackCertificate#self_signed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "self_signed">]
        member _.SelfSigned(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: bool) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.SelfSigned <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#self_signed-1">PaloAltoLocalRulestackCertificate#self_signed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "self_signed">]
        member _.SelfSigned(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.SelfSigned <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_certificate#timeouts-1">PaloAltoLocalRulestackCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>, value: azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificateTimeouts) : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackCertificateState<'Name, 'RulestackId>

        member _.Run(state: PaloAltoLocalRulestackCertificateState<Present, Present>) : azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificate =
            let config = azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestackCertificate: missing required arguments. Must call: name, rulestack_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackCertificateState<_, _>) : azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificate =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestackCertificate.PaloAltoLocalRulestackCertificate>
