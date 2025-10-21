namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record">azurerm_dns_caa_record</a>.
    /// </summary>
    type DataAzurermDnsCaaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsCaaRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsCaaRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsCaaRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsCaaRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#name-1">DataAzurermDnsCaaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsCaaRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsCaaRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsCaaRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#resource_group_name-1">DataAzurermDnsCaaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsCaaRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsCaaRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsCaaRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#zone_name-1">DataAzurermDnsCaaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#id-1">DataAzurermDnsCaaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#timeouts-1">DataAzurermDnsCaaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecordTimeouts) : DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsCaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsCaaRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecord =
            let config = azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsCaaRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsCaaRecordState<_, _, _>) : azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsCaaRecord.DataAzurermDnsCaaRecord>
