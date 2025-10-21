namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName> = { assignments: ResizeArray<azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider">azurerm_virtual_hub_security_partner_provider</a>.
    /// </summary>
    type VirtualHubSecurityPartnerProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubSecurityPartnerProviderState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubSecurityPartnerProviderState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubSecurityPartnerProviderState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubSecurityPartnerProviderState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#location-1">VirtualHubSecurityPartnerProvider#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualHubSecurityPartnerProviderState<Missing, 'Name, 'ResourceGroupName, 'SecurityProviderName>, value: string) : VirtualHubSecurityPartnerProviderState<Present, 'Name, 'ResourceGroupName, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualHubSecurityPartnerProviderState<Present, 'Name, 'ResourceGroupName, 'SecurityProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#name-1">VirtualHubSecurityPartnerProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubSecurityPartnerProviderState<'Location, Missing, 'ResourceGroupName, 'SecurityProviderName>, value: string) : VirtualHubSecurityPartnerProviderState<'Location, Present, 'ResourceGroupName, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubSecurityPartnerProviderState<'Location, Present, 'ResourceGroupName, 'SecurityProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#resource_group_name-1">VirtualHubSecurityPartnerProvider#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualHubSecurityPartnerProviderState<'Location, 'Name, Missing, 'SecurityProviderName>, value: string) : VirtualHubSecurityPartnerProviderState<'Location, 'Name, Present, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualHubSecurityPartnerProviderState<'Location, 'Name, Present, 'SecurityProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#security_provider_name-1">VirtualHubSecurityPartnerProvider#security_provider_name</a>.
        /// </summary>
        [<CustomOperation "security_provider_name">]
        member _.SecurityProviderName(state: VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SecurityProviderName <- value)
            ({ assignments = state.assignments } : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#id-1">VirtualHubSecurityPartnerProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>, value: string) : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#tags-1">VirtualHubSecurityPartnerProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>, value: seq<string * string>) : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#timeouts-1">VirtualHubSecurityPartnerProvider#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>, value: azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProviderTimeouts) : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_security_partner_provider#virtual_hub_id-1">VirtualHubSecurityPartnerProvider#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>, value: string) : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            state : VirtualHubSecurityPartnerProviderState<'Location, 'Name, 'ResourceGroupName, 'SecurityProviderName>

        member _.Run(state: VirtualHubSecurityPartnerProviderState<Present, Present, Present, Present>) : azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProvider =
            let config = azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProviderConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubSecurityPartnerProvider: missing required arguments. Must call: location, name, resource_group_name, security_provider_name.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubSecurityPartnerProviderState<_, _, _, _>) : azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProvider =
            Unchecked.defaultof<azurerm.VirtualHubSecurityPartnerProvider.VirtualHubSecurityPartnerProvider>
