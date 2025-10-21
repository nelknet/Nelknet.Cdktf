namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsSrvRecord.DnsSrvRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record">azurerm_dns_srv_record</a>.
    /// </summary>
    type DnsSrvRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsSrvRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsSrvRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsSrvRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsSrvRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#name-1">DnsSrvRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsSrvRecordState<Missing, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsSrvRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsSrvRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#record-1">DnsSrvRecord#record</a> Accepts: azurerm.IResolvable | azurerm.DnsSrvRecord.DnsSrvRecordRecord[]
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: DnsSrvRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: HashiCorp.Cdktf.IResolvable) : DnsSrvRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : DnsSrvRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#resource_group_name-1">DnsSrvRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsSrvRecordState<'Name, 'Record, Missing, 'Ttl, 'ZoneName>, value: string) : DnsSrvRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsSrvRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#ttl-1">DnsSrvRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#zone_name-1">DnsSrvRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#id-1">DnsSrvRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#tags-1">DnsSrvRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_srv_record#timeouts-1">DnsSrvRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsSrvRecord.DnsSrvRecordTimeouts) : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsSrvRecordState<Present, Present, Present, Present, Present>) : azurerm.DnsSrvRecord.DnsSrvRecord =
            let config = azurerm.DnsSrvRecord.DnsSrvRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsSrvRecord.DnsSrvRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsSrvRecord: missing required arguments. Must call: name, record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsSrvRecordState<_, _, _, _, _>) : azurerm.DnsSrvRecord.DnsSrvRecord =
            Unchecked.defaultof<azurerm.DnsSrvRecord.DnsSrvRecord>
