namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record">azurerm_private_dns_aaaa_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsAaaaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsAaaaRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsAaaaRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsAaaaRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsAaaaRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record#name-1">DataAzurermPrivateDnsAaaaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsAaaaRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsAaaaRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsAaaaRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record#resource_group_name-1">DataAzurermPrivateDnsAaaaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsAaaaRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsAaaaRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsAaaaRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record#zone_name-1">DataAzurermPrivateDnsAaaaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record#id-1">DataAzurermPrivateDnsAaaaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record#timeouts-1">DataAzurermPrivateDnsAaaaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecordTimeouts) : DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsAaaaRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsAaaaRecordState<Present, Present, Present>) : azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecord =
            let config = azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsAaaaRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsAaaaRecordState<_, _, _>) : azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecord>
