namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.DnsCnameRecord.DnsCnameRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record">azurerm_dns_cname_record</a>.
    /// </summary>
    type DnsCnameRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsCnameRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsCnameRecordState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DnsCnameRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsCnameRecordState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#name-1">DnsCnameRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsCnameRecordState<Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsCnameRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsCnameRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#resource_group_name-1">DnsCnameRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsCnameRecordState<'Name, Missing, 'Ttl, 'ZoneName>, value: string) : DnsCnameRecordState<'Name, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsCnameRecordState<'Name, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#ttl-1">DnsCnameRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DnsCnameRecordState<'Name, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : DnsCnameRecordState<'Name, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : DnsCnameRecordState<'Name, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#zone_name-1">DnsCnameRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, Missing>, value: string) : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#id-1">DnsCnameRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#record-1">DnsCnameRecord#record</a>.
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            state : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#tags-1">DnsCnameRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#target_resource_id-1">DnsCnameRecord#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            state : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_cname_record#timeouts-1">DnsCnameRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.DnsCnameRecord.DnsCnameRecordTimeouts) : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsCnameRecordState<'Name, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: DnsCnameRecordState<Present, Present, Present, Present>) : azurerm.DnsCnameRecord.DnsCnameRecord =
            let config = azurerm.DnsCnameRecord.DnsCnameRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsCnameRecord.DnsCnameRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsCnameRecord: missing required arguments. Must call: name, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: DnsCnameRecordState<_, _, _, _>) : azurerm.DnsCnameRecord.DnsCnameRecord =
            Unchecked.defaultof<azurerm.DnsCnameRecord.DnsCnameRecord>
