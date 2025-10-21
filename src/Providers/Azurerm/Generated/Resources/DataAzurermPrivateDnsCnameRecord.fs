namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_cname_record">azurerm_private_dns_cname_record</a>.
    /// </summary>
    type DataAzurermPrivateDnsCnameRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsCnameRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsCnameRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsCnameRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsCnameRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_cname_record#name-1">DataAzurermPrivateDnsCnameRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsCnameRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsCnameRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsCnameRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_cname_record#resource_group_name-1">DataAzurermPrivateDnsCnameRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsCnameRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermPrivateDnsCnameRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsCnameRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_cname_record#zone_name-1">DataAzurermPrivateDnsCnameRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_cname_record#id-1">DataAzurermPrivateDnsCnameRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_cname_record#timeouts-1">DataAzurermPrivateDnsCnameRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecordTimeouts) : DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermPrivateDnsCnameRecordState<Present, Present, Present>) : azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecord =
            let config = azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsCnameRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsCnameRecordState<_, _, _>) : azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecord =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsCnameRecord.DataAzurermPrivateDnsCnameRecord>
