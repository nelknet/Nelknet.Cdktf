namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsNsRecord.DnsNsRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record">azurerm_dns_ns_record</a>.
    /// </summary>
    type DnsNsRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsNsRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsNsRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsNsRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsNsRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#name-1">DnsNsRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsNsRecordState<Missing, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsNsRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsNsRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#records-1">DnsNsRecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: DnsNsRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : DnsNsRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DnsNsRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#resource_group_name-1">DnsNsRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsNsRecordState<'Name, 'Records, Missing, 'Ttl, 'ZoneName>, value: string) : DnsNsRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsNsRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#ttl-1">DnsNsRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#zone_name-1">DnsNsRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#id-1">DnsNsRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#tags-1">DnsNsRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ns_record#timeouts-1">DnsNsRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsNsRecord.DnsNsRecordTimeouts) : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsNsRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsNsRecordState<Present, Present, Present, Present, Present>) : azurerm.DnsNsRecord.DnsNsRecord =
            let config = azurerm.DnsNsRecord.DnsNsRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsNsRecord.DnsNsRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsNsRecord: missing required arguments. Must call: name, records, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsNsRecordState<_, _, _, _, _>) : azurerm.DnsNsRecord.DnsNsRecord =
            Unchecked.defaultof<azurerm.DnsNsRecord.DnsNsRecord>
