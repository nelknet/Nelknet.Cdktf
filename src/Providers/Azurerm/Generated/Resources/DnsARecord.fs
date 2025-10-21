namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsARecord.DnsARecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record">azurerm_dns_a_record</a>.
    /// </summary>
    type DnsARecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsARecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsARecordState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsARecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsARecordState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#name-1">DnsARecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsARecordState<Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsARecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsARecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#resource_group_name-1">DnsARecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsARecordState<'Name, Missing, 'Ttl, 'ZoneName>, value: string) : DnsARecordState<'Name, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsARecordState<'Name, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#ttl-1">DnsARecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsARecordState<'Name, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsARecordState<'Name, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsARecordState<'Name, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#zone_name-1">DnsARecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#id-1">DnsARecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#records-1">DnsARecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            state : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#tags-1">DnsARecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#target_resource_id-1">DnsARecord#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            state : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_a_record#timeouts-1">DnsARecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsARecord.DnsARecordTimeouts) : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsARecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsARecordState<Present, Present, Present, Present>) : azurerm.DnsARecord.DnsARecord =
            let config = azurerm.DnsARecord.DnsARecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsARecord.DnsARecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsARecord: missing required arguments. Must call: name, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsARecordState<_, _, _, _>) : azurerm.DnsARecord.DnsARecord =
            Unchecked.defaultof<azurerm.DnsARecord.DnsARecord>
