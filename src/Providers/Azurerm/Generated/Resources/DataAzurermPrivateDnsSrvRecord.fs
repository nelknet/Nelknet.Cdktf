namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record">azurerm_private_dns_srv_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsSrvRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsSrvRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsSrvRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsSrvRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsSrvRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#name-1">DataAzurermPrivateDnsSrvRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsSrvRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsSrvRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsSrvRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#resource_group_name-1">DataAzurermPrivateDnsSrvRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsSrvRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsSrvRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsSrvRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#zone_name-1">DataAzurermPrivateDnsSrvRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#id-1">DataAzurermPrivateDnsSrvRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#timeouts-1">DataAzurermPrivateDnsSrvRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecordTimeouts) : DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsSrvRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsSrvRecordState<Present, Present, Present>) : azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecord =
            let config = azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsSrvRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsSrvRecordState<_, _, _>) : azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecord>
