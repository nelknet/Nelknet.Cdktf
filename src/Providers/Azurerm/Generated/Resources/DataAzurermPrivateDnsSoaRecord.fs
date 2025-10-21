namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record">azurerm_private_dns_soa_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsSoaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsSoaRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsSoaRecordState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsSoaRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsSoaRecordState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#resource_group_name-1">DataAzurermPrivateDnsSoaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsSoaRecordState<Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsSoaRecordState<Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsSoaRecordState<Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#zone_name-1">DataAzurermPrivateDnsSoaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#id-1">DataAzurermPrivateDnsSoaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#name-1">DataAzurermPrivateDnsSoaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#timeouts-1">DataAzurermPrivateDnsSoaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecordTimeouts) : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsSoaRecordState<'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsSoaRecordState<Present, Present>) : azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecord =
            let config = azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsSoaRecord: missing required arguments. Must call: resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsSoaRecordState<_, _>) : azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecord>
