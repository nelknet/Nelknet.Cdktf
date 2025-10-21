namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record">azurerm_dns_aaaa_record</a>.
    /// </summary>
    type DataAzurermDnsAaaaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsAaaaRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsAaaaRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsAaaaRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsAaaaRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#name-1">DataAzurermDnsAaaaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsAaaaRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsAaaaRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsAaaaRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#resource_group_name-1">DataAzurermDnsAaaaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsAaaaRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsAaaaRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsAaaaRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#zone_name-1">DataAzurermDnsAaaaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#id-1">DataAzurermDnsAaaaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#timeouts-1">DataAzurermDnsAaaaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecordTimeouts) : DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsAaaaRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecord =
            let config = azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsAaaaRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsAaaaRecordState<_, _, _>) : azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecord>
