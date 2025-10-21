namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsZoneState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone">azurerm_private_dns_zone</a>.
    /// </summary>
    type DataAzurermPrivateDnsZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsZoneState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsZoneState<Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsZoneState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsZoneState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone#name-1">DataAzurermPrivateDnsZone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsZoneState<Missing>, value: string) : DataAzurermPrivateDnsZoneState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsZoneState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone#id-1">DataAzurermPrivateDnsZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsZoneState<'Name>, value: string) : DataAzurermPrivateDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone#resource_group_name-1">DataAzurermPrivateDnsZone#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsZoneState<'Name>, value: string) : DataAzurermPrivateDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermPrivateDnsZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone#tags-1">DataAzurermPrivateDnsZone#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermPrivateDnsZoneState<'Name>, value: seq<string * string>) : DataAzurermPrivateDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermPrivateDnsZoneState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone#timeouts-1">DataAzurermPrivateDnsZone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsZoneState<'Name>, value: azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZoneTimeouts) : DataAzurermPrivateDnsZoneState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsZoneState<'Name>

        member _.Run(state: DataAzurermPrivateDnsZoneState<Present>) : azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZone =
            let config = azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZoneConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsZone: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsZoneState<_>) : azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZone =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsZone.DataAzurermPrivateDnsZone>
