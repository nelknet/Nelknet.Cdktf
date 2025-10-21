namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record">azurerm_private_dns_aaaa_record</a>.
    /// </summary>
    type PrivateDnsAaaaRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsAaaaRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsAaaaRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsAaaaRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsAaaaRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#name-1">PrivateDnsAaaaRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsAaaaRecordState<Missing, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsAaaaRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsAaaaRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#records-1">PrivateDnsAaaaRecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: PrivateDnsAaaaRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : PrivateDnsAaaaRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PrivateDnsAaaaRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#resource_group_name-1">PrivateDnsAaaaRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsAaaaRecordState<'Name, 'Records, Missing, 'Ttl, 'ZoneName>, value: string) : PrivateDnsAaaaRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsAaaaRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#ttl-1">PrivateDnsAaaaRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#zone_name-1">PrivateDnsAaaaRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Missing>, value: string) : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#id-1">PrivateDnsAaaaRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#tags-1">PrivateDnsAaaaRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_aaaa_record#timeouts-1">PrivateDnsAaaaRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecordTimeouts) : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsAaaaRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: PrivateDnsAaaaRecordState<Present, Present, Present, Present, Present>) : azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecord =
            let config = azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsAaaaRecord: missing required arguments. Must call: name, records, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsAaaaRecordState<_, _, _, _, _>) : azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecord =
            Unchecked.defaultof<azurerm.PrivateDnsAaaaRecord.PrivateDnsAaaaRecord>
