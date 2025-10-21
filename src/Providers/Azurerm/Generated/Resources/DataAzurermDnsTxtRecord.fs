namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record">azurerm_dns_txt_record</a>.
    /// </summary>
    type DataAzurermDnsTxtRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsTxtRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsTxtRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsTxtRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsTxtRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#name-1">DataAzurermDnsTxtRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsTxtRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsTxtRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsTxtRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#resource_group_name-1">DataAzurermDnsTxtRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsTxtRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsTxtRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsTxtRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#zone_name-1">DataAzurermDnsTxtRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#id-1">DataAzurermDnsTxtRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#timeouts-1">DataAzurermDnsTxtRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecordTimeouts) : DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsTxtRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecord =
            let config = azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsTxtRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsTxtRecordState<_, _, _>) : azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsTxtRecord.DataAzurermDnsTxtRecord>
