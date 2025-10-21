namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record">azurerm_dns_srv_record</a>.
    /// </summary>
    type DataAzurermDnsSrvRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsSrvRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsSrvRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsSrvRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsSrvRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#name-1">DataAzurermDnsSrvRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsSrvRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsSrvRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsSrvRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#resource_group_name-1">DataAzurermDnsSrvRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsSrvRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsSrvRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsSrvRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#zone_name-1">DataAzurermDnsSrvRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#id-1">DataAzurermDnsSrvRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#timeouts-1">DataAzurermDnsSrvRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecordTimeouts) : DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsSrvRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecord =
            let config = azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsSrvRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsSrvRecordState<_, _, _>) : azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsSrvRecord.DataAzurermDnsSrvRecord>
