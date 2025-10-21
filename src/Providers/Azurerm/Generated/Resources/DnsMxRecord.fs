namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsMxRecord.DnsMxRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record">azurerm_dns_mx_record</a>.
    /// </summary>
    type DnsMxRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsMxRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsMxRecordState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsMxRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsMxRecordState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#record-1">DnsMxRecord#record</a> Accepts: azurerm.IResolvable | azurerm.DnsMxRecord.DnsMxRecordRecord[]
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: DnsMxRecordState<Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: HashiCorp.Cdktf.IResolvable) : DnsMxRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : DnsMxRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#resource_group_name-1">DnsMxRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsMxRecordState<'Record, Missing, 'Ttl, 'ZoneName>, value: string) : DnsMxRecordState<'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsMxRecordState<'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#ttl-1">DnsMxRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsMxRecordState<'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsMxRecordState<'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsMxRecordState<'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#zone_name-1">DnsMxRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#id-1">DnsMxRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#name-1">DnsMxRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#tags-1">DnsMxRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#timeouts-1">DnsMxRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsMxRecord.DnsMxRecordTimeouts) : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsMxRecordState<Present, Present, Present, Present>) : azurerm.DnsMxRecord.DnsMxRecord =
            let config = azurerm.DnsMxRecord.DnsMxRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsMxRecord.DnsMxRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsMxRecord: missing required arguments. Must call: record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsMxRecordState<_, _, _, _>) : azurerm.DnsMxRecord.DnsMxRecord =
            Unchecked.defaultof<azurerm.DnsMxRecord.DnsMxRecord>
