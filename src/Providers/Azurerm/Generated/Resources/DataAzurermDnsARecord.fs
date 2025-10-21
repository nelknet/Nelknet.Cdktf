namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsARecord.DataAzurermDnsARecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record">azurerm_dns_a_record</a>.
    /// </summary>
    type DataAzurermDnsARecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsARecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsARecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsARecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsARecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#name-1">DataAzurermDnsARecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsARecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsARecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsARecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#resource_group_name-1">DataAzurermDnsARecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsARecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsARecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsARecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#zone_name-1">DataAzurermDnsARecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsARecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsARecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsARecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#id-1">DataAzurermDnsARecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#timeouts-1">DataAzurermDnsARecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsARecord.DataAzurermDnsARecordTimeouts) : DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsARecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsARecordState<Present, Present, Present>) : azurerm.DataAzurermDnsARecord.DataAzurermDnsARecord =
            let config = azurerm.DataAzurermDnsARecord.DataAzurermDnsARecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsARecord.DataAzurermDnsARecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsARecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsARecordState<_, _, _>) : azurerm.DataAzurermDnsARecord.DataAzurermDnsARecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsARecord.DataAzurermDnsARecord>
