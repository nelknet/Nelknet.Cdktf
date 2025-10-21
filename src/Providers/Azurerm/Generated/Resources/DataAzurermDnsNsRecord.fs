namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record">azurerm_dns_ns_record</a>.
    /// </summary>
    type DataAzurermDnsNsRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsNsRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsNsRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsNsRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsNsRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record#name-1">DataAzurermDnsNsRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsNsRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsNsRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsNsRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record#resource_group_name-1">DataAzurermDnsNsRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsNsRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsNsRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsNsRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record#zone_name-1">DataAzurermDnsNsRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record#id-1">DataAzurermDnsNsRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record#timeouts-1">DataAzurermDnsNsRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecordTimeouts) : DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsNsRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsNsRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecord =
            let config = azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsNsRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsNsRecordState<_, _, _>) : azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsNsRecord.DataAzurermDnsNsRecord>
