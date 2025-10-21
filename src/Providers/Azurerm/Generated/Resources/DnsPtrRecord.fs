namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsPtrRecord.DnsPtrRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record">azurerm_dns_ptr_record</a>.
    /// </summary>
    type DnsPtrRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsPtrRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsPtrRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsPtrRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsPtrRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#name-1">DnsPtrRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsPtrRecordState<Missing, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsPtrRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsPtrRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#records-1">DnsPtrRecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: DnsPtrRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : DnsPtrRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DnsPtrRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#resource_group_name-1">DnsPtrRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsPtrRecordState<'Name, 'Records, Missing, 'Ttl, 'ZoneName>, value: string) : DnsPtrRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsPtrRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#ttl-1">DnsPtrRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#zone_name-1">DnsPtrRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#id-1">DnsPtrRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#tags-1">DnsPtrRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_ptr_record#timeouts-1">DnsPtrRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsPtrRecord.DnsPtrRecordTimeouts) : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsPtrRecordState<Present, Present, Present, Present, Present>) : azurerm.DnsPtrRecord.DnsPtrRecord =
            let config = azurerm.DnsPtrRecord.DnsPtrRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsPtrRecord.DnsPtrRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsPtrRecord: missing required arguments. Must call: name, records, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsPtrRecordState<_, _, _, _, _>) : azurerm.DnsPtrRecord.DnsPtrRecord =
            Unchecked.defaultof<azurerm.DnsPtrRecord.DnsPtrRecord>
