namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsZoneState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermDnsZone.DataAzurermDnsZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone">azurerm_dns_zone</a>.
    /// </summary>
    type DataAzurermDnsZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsZoneState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsZoneState<Missing>)

        member _.Zero(()) : DataAzurermDnsZoneState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsZoneState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#name-1">DataAzurermDnsZone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsZoneState<Missing>, value: string) : DataAzurermDnsZoneState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsZoneState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#id-1">DataAzurermDnsZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsZoneState<'Name>, value: string) : DataAzurermDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#resource_group_name-1">DataAzurermDnsZone#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsZoneState<'Name>, value: string) : DataAzurermDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermDnsZoneState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#timeouts-1">DataAzurermDnsZone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsZoneState<'Name>, value: azurerm.DataAzurermDnsZone.DataAzurermDnsZoneTimeouts) : DataAzurermDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsZoneState<'Name>

        member _.Run(state: DataAzurermDnsZoneState<Present>) : azurerm.DataAzurermDnsZone.DataAzurermDnsZone =
            let config = azurerm.DataAzurermDnsZone.DataAzurermDnsZoneConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsZone.DataAzurermDnsZone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsZone: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsZoneState<_>) : azurerm.DataAzurermDnsZone.DataAzurermDnsZone =
            Unchecked.defaultof<azurerm.DataAzurermDnsZone.DataAzurermDnsZone>
