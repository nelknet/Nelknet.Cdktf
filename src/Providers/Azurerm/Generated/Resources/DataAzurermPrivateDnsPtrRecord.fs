namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record">azurerm_private_dns_ptr_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsPtrRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsPtrRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsPtrRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsPtrRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsPtrRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#name-1">DataAzurermPrivateDnsPtrRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsPtrRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsPtrRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsPtrRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#resource_group_name-1">DataAzurermPrivateDnsPtrRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsPtrRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsPtrRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsPtrRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#zone_name-1">DataAzurermPrivateDnsPtrRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#id-1">DataAzurermPrivateDnsPtrRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#timeouts-1">DataAzurermPrivateDnsPtrRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecordTimeouts) : DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsPtrRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsPtrRecordState<Present, Present, Present>) : azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecord =
            let config = azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsPtrRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsPtrRecordState<_, _, _>) : azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecord>
