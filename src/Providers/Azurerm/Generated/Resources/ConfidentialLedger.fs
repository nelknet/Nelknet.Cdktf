namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ConfidentialLedger.ConfidentialLedgerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger">azurerm_confidential_ledger</a>.
    /// </summary>
    type ConfidentialLedgerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfidentialLedgerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfidentialLedgerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConfidentialLedgerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfidentialLedgerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// azuread_based_service_principal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#azuread_based_service_principal-1">ConfidentialLedger#azuread_based_service_principal</a> Accepts: azurerm.IResolvable | azurerm.ConfidentialLedger.ConfidentialLedgerAzureadBasedServicePrincipal[]
        /// </summary>
        [<CustomOperation "azuread_based_service_principal">]
        member _.AzureadBasedServicePrincipal(state: ConfidentialLedgerState<Missing, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ConfidentialLedgerState<Present, 'LedgerType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzureadBasedServicePrincipal <- value)
            ({ assignments = state.assignments } : ConfidentialLedgerState<Present, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#ledger_type-1">ConfidentialLedger#ledger_type</a>.
        /// </summary>
        [<CustomOperation "ledger_type">]
        member _.LedgerType(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LedgerType <- value)
            ({ assignments = state.assignments } : ConfidentialLedgerState<'AzureadBasedServicePrincipal, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#location-1">ConfidentialLedger#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, Missing, 'Name, 'ResourceGroupName>, value: string) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#name-1">ConfidentialLedger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, Missing, 'ResourceGroupName>, value: string) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#resource_group_name-1">ConfidentialLedger#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, Missing>, value: string) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, Present>)

        /// <summary>
        /// certificate_based_security_principal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#certificate_based_security_principal-1">ConfidentialLedger#certificate_based_security_principal</a> Accepts: azurerm.IResolvable | azurerm.ConfidentialLedger.ConfidentialLedgerCertificateBasedSecurityPrincipal[]
        /// </summary>
        [<CustomOperation "certificate_based_security_principal">]
        member _.CertificateBasedSecurityPrincipal(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CertificateBasedSecurityPrincipal <- value)
            state : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#id-1">ConfidentialLedger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>, value: string) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#tags-1">ConfidentialLedger#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#timeouts-1">ConfidentialLedger#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ConfidentialLedger.ConfidentialLedgerTimeouts) : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConfidentialLedgerState<'AzureadBasedServicePrincipal, 'LedgerType, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ConfidentialLedgerState<Present, Present, Present, Present, Present>) : azurerm.ConfidentialLedger.ConfidentialLedger =
            let config = azurerm.ConfidentialLedger.ConfidentialLedgerConfig()
            for setter in state.assignments do
                setter config
            azurerm.ConfidentialLedger.ConfidentialLedger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.confidentialLedger: missing required arguments. Must call: azuread_based_service_principal, ledger_type, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ConfidentialLedgerState<_, _, _, _, _>) : azurerm.ConfidentialLedger.ConfidentialLedger =
            Unchecked.defaultof<azurerm.ConfidentialLedger.ConfidentialLedger>
