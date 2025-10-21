namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AttestationProviderState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AttestationProvider.AttestationProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider">azurerm_attestation_provider</a>.
    /// </summary>
    type AttestationProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : AttestationProviderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AttestationProviderState<Missing, Missing, Missing>)

        member _.Zero(()) : AttestationProviderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AttestationProviderState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#location-1">AttestationProvider#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AttestationProviderState<Missing, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AttestationProviderState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#name-1">AttestationProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AttestationProviderState<'Location, Missing, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AttestationProviderState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#resource_group_name-1">AttestationProvider#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AttestationProviderState<'Location, 'Name, Missing>, value: string) : AttestationProviderState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AttestationProviderState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#id-1">AttestationProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#open_enclave_policy_base64-1">AttestationProvider#open_enclave_policy_base64</a>.
        /// </summary>
        [<CustomOperation "open_enclave_policy_base64">]
        member _.OpenEnclavePolicyBase64(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OpenEnclavePolicyBase64 <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#policy_signing_certificate_data-1">AttestationProvider#policy_signing_certificate_data</a>.
        /// </summary>
        [<CustomOperation "policy_signing_certificate_data">]
        member _.PolicySigningCertificateData(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PolicySigningCertificateData <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#sev_snp_policy_base64-1">AttestationProvider#sev_snp_policy_base64</a>.
        /// </summary>
        [<CustomOperation "sev_snp_policy_base64">]
        member _.SevSnpPolicyBase64(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SevSnpPolicyBase64 <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#sgx_enclave_policy_base64-1">AttestationProvider#sgx_enclave_policy_base64</a>.
        /// </summary>
        [<CustomOperation "sgx_enclave_policy_base64">]
        member _.SgxEnclavePolicyBase64(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SgxEnclavePolicyBase64 <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#tags-1">AttestationProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#timeouts-1">AttestationProvider#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AttestationProvider.AttestationProviderTimeouts) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/attestation_provider#tpm_policy_base64-1">AttestationProvider#tpm_policy_base64</a>.
        /// </summary>
        [<CustomOperation "tpm_policy_base64">]
        member _.TpmPolicyBase64(state: AttestationProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AttestationProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TpmPolicyBase64 <- value)
            state : AttestationProviderState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AttestationProviderState<Present, Present, Present>) : azurerm.AttestationProvider.AttestationProvider =
            let config = azurerm.AttestationProvider.AttestationProviderConfig()
            for setter in state.assignments do
                setter config
            azurerm.AttestationProvider.AttestationProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.attestationProvider: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AttestationProviderState<_, _, _>) : azurerm.AttestationProvider.AttestationProvider =
            Unchecked.defaultof<azurerm.AttestationProvider.AttestationProvider>
