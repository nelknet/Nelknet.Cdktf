namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_soa_record">azurerm_dns_soa_record</a>.
    /// </summary>
    type DataAzurermDnsSoaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsSoaRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsSoaRecordState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsSoaRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsSoaRecordState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_soa_record#resource_group_name-1">DataAzurermDnsSoaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsSoaRecordState<Missing, 'ZoneName>, value: string) : DataAzurermDnsSoaRecordState<Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsSoaRecordState<Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_soa_record#zone_name-1">DataAzurermDnsSoaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsSoaRecordState<'ResourceGroupName, Missing>, value: string) : DataAzurermDnsSoaRecordState<'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsSoaRecordState<'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_soa_record#id-1">DataAzurermDnsSoaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_soa_record#name-1">DataAzurermDnsSoaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_soa_record#timeouts-1">DataAzurermDnsSoaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecordTimeouts) : DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsSoaRecordState<'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsSoaRecordState<Present, Present>) : azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecord =
            let config = azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsSoaRecord: missing required arguments. Must call: resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsSoaRecordState<_, _>) : azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsSoaRecord.DataAzurermDnsSoaRecord>
