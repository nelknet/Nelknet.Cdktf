namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName> = { assignments: ResizeArray<azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_cname_record">azurerm_dns_cname_record</a>.
    /// </summary>
    type DataAzurermDnsCnameRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDnsCnameRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsCnameRecordState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDnsCnameRecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDnsCnameRecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_cname_record#name-1">DataAzurermDnsCnameRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDnsCnameRecordState<Missing, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsCnameRecordState<Present, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDnsCnameRecordState<Present, 'ResourceGroupName, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_cname_record#resource_group_name-1">DataAzurermDnsCnameRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDnsCnameRecordState<'Name, Missing, 'ZoneName>, value: string) : DataAzurermDnsCnameRecordState<'Name, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsCnameRecordState<'Name, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_cname_record#zone_name-1">DataAzurermDnsCnameRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_cname_record#id-1">DataAzurermDnsCnameRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: string) : DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_cname_record#timeouts-1">DataAzurermDnsCnameRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>, value: azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecordTimeouts) : DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDnsCnameRecordState<'Name, 'ResourceGroupName, 'ZoneName>

        member _.Run(state: DataAzurermDnsCnameRecordState<Present, Present, Present>) : azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecord =
            let config = azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDnsCnameRecord: missing required arguments. Must call: name, resource_group_name, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDnsCnameRecordState<_, _, _>) : azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecord =
            Unchecked.defaultof<azurerm.DataAzurermDnsCnameRecord.DataAzurermDnsCnameRecord>
