namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsAaaaRecord.DnsAaaaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record">azurerm_dns_aaaa_record</a>.
    /// </summary>
    type DnsAaaaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsAaaaRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsAaaaRecordState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsAaaaRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsAaaaRecordState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#name-1">DnsAaaaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsAaaaRecordState<Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsAaaaRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsAaaaRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#resource_group_name-1">DnsAaaaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsAaaaRecordState<'Name, Missing, 'Ttl, 'ZoneName>, value: string) : DnsAaaaRecordState<'Name, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsAaaaRecordState<'Name, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#ttl-1">DnsAaaaRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsAaaaRecordState<'Name, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsAaaaRecordState<'Name, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#zone_name-1">DnsAaaaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#id-1">DnsAaaaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#records-1">DnsAaaaRecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            state : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#tags-1">DnsAaaaRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#target_resource_id-1">DnsAaaaRecord#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            state : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_aaaa_record#timeouts-1">DnsAaaaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsAaaaRecord.DnsAaaaRecordTimeouts) : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsAaaaRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsAaaaRecordState<Present, Present, Present, Present>) : azurerm.DnsAaaaRecord.DnsAaaaRecord =
            let config = azurerm.DnsAaaaRecord.DnsAaaaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsAaaaRecord.DnsAaaaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsAaaaRecord: missing required arguments. Must call: name, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsAaaaRecordState<_, _, _, _>) : azurerm.DnsAaaaRecord.DnsAaaaRecord =
            Unchecked.defaultof<azurerm.DnsAaaaRecord.DnsAaaaRecord>
