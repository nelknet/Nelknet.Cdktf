namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsTxtRecord.DnsTxtRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record">azurerm_dns_txt_record</a>.
    /// </summary>
    type DnsTxtRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsTxtRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsTxtRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsTxtRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsTxtRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#name-1">DnsTxtRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsTxtRecordState<Missing, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsTxtRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsTxtRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#record-1">DnsTxtRecord#record</a> Accepts: azurerm.IResolvable | azurerm.DnsTxtRecord.DnsTxtRecordRecord[]
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: DnsTxtRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: HashiCorp.Cdktf.IResolvable) : DnsTxtRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : DnsTxtRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#resource_group_name-1">DnsTxtRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsTxtRecordState<'Name, 'Record, Missing, 'Ttl, 'ZoneName>, value: string) : DnsTxtRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsTxtRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#ttl-1">DnsTxtRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#zone_name-1">DnsTxtRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#id-1">DnsTxtRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#tags-1">DnsTxtRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#timeouts-1">DnsTxtRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsTxtRecord.DnsTxtRecordTimeouts) : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsTxtRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsTxtRecordState<Present, Present, Present, Present, Present>) : azurerm.DnsTxtRecord.DnsTxtRecord =
            let config = azurerm.DnsTxtRecord.DnsTxtRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsTxtRecord.DnsTxtRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsTxtRecord: missing required arguments. Must call: name, record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsTxtRecordState<_, _, _, _, _>) : azurerm.DnsTxtRecord.DnsTxtRecord =
            Unchecked.defaultof<azurerm.DnsTxtRecord.DnsTxtRecord>
