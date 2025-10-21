namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record">azurerm_private_dns_mx_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsMxRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsMxRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsMxRecordState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsMxRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsMxRecordState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#resource_group_name-1">DataAzurermPrivateDnsMxRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsMxRecordState<Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsMxRecordState<Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsMxRecordState<Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#zone_name-1">DataAzurermPrivateDnsMxRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#id-1">DataAzurermPrivateDnsMxRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#name-1">DataAzurermPrivateDnsMxRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#timeouts-1">DataAzurermPrivateDnsMxRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecordTimeouts) : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsMxRecordState<'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsMxRecordState<Present, Present>) : azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecord =
            let config = azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsMxRecord: missing required arguments. Must call: resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsMxRecordState<_, _>) : azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecord>
