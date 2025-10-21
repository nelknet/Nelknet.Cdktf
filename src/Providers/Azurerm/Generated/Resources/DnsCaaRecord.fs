namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsCaaRecord.DnsCaaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record">azurerm_dns_caa_record</a>.
    /// </summary>
    type DnsCaaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsCaaRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsCaaRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsCaaRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsCaaRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#name-1">DnsCaaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsCaaRecordState<Missing, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsCaaRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsCaaRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#record-1">DnsCaaRecord#record</a> Accepts: azurerm.IResolvable | azurerm.DnsCaaRecord.DnsCaaRecordRecord[]
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: DnsCaaRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: HashiCorp.Cdktf.IResolvable) : DnsCaaRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : DnsCaaRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#resource_group_name-1">DnsCaaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsCaaRecordState<'Name, 'Record, Missing, 'Ttl, 'ZoneName>, value: string) : DnsCaaRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsCaaRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#ttl-1">DnsCaaRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#zone_name-1">DnsCaaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#id-1">DnsCaaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#tags-1">DnsCaaRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#timeouts-1">DnsCaaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsCaaRecord.DnsCaaRecordTimeouts) : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsCaaRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsCaaRecordState<Present, Present, Present, Present, Present>) : azurerm.DnsCaaRecord.DnsCaaRecord =
            let config = azurerm.DnsCaaRecord.DnsCaaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsCaaRecord.DnsCaaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsCaaRecord: missing required arguments. Must call: name, record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsCaaRecordState<_, _, _, _, _>) : azurerm.DnsCaaRecord.DnsCaaRecord =
            Unchecked.defaultof<azurerm.DnsCaaRecord.DnsCaaRecord>
