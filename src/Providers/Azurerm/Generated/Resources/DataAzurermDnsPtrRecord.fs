namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record">azurerm_dns_ptr_record</a>.
    /// </summary>
    type DataAzurermDnsPtrRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsPtrRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsPtrRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsPtrRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsPtrRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#name-1">DataAzurermDnsPtrRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsPtrRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsPtrRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsPtrRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#resource_group_name-1">DataAzurermDnsPtrRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsPtrRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsPtrRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsPtrRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#zone_name-1">DataAzurermDnsPtrRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#id-1">DataAzurermDnsPtrRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#timeouts-1">DataAzurermDnsPtrRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecordTimeouts) : DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsPtrRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecord =
            let config = azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsPtrRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsPtrRecordState<_, _, _>) : azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsPtrRecord.DataAzurermDnsPtrRecord>
