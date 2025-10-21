namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record">azurerm_private_dns_txt_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsTxtRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsTxtRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsTxtRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsTxtRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsTxtRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#name-1">DataAzurermPrivateDnsTxtRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsTxtRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsTxtRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsTxtRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#resource_group_name-1">DataAzurermPrivateDnsTxtRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsTxtRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsTxtRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsTxtRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#zone_name-1">DataAzurermPrivateDnsTxtRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#id-1">DataAzurermPrivateDnsTxtRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#timeouts-1">DataAzurermPrivateDnsTxtRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecordTimeouts) : DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsTxtRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsTxtRecordState<Present, Present, Present>) : azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecord =
            let config = azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsTxtRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsTxtRecordState<_, _, _>) : azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecord>
