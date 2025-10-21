namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_mx_record">azurerm_dns_mx_record</a>.
    /// </summary>
    type DataAzurermDnsMxRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsMxRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsMxRecordState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsMxRecordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsMxRecordState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_mx_record#resource_group_name-1">DataAzurermDnsMxRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsMxRecordState<Missing, 'ZoneName>, value: string) : DataAzurermDnsMxRecordState<Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsMxRecordState<Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_mx_record#zone_name-1">DataAzurermDnsMxRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsMxRecordState<'ResourceGroupName, Missing>, value: string) : DataAzurermDnsMxRecordState<'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsMxRecordState<'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_mx_record#id-1">DataAzurermDnsMxRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_mx_record#name-1">DataAzurermDnsMxRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_mx_record#timeouts-1">DataAzurermDnsMxRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecordTimeouts) : DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsMxRecordState<'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsMxRecordState<Present, Present>) : azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecord =
            let config = azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsMxRecord: missing required arguments. Must call: resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsMxRecordState<_, _>) : azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsMxRecord.DataAzurermDnsMxRecord>
