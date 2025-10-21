namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.PrivateDnsARecord.PrivateDnsARecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record">azurerm_private_dns_a_record</a>.
    /// </summary>
    type PrivateDnsARecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsARecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsARecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsARecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsARecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#name-1">PrivateDnsARecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsARecordState<Missing, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsARecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsARecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#records-1">PrivateDnsARecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: PrivateDnsARecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : PrivateDnsARecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PrivateDnsARecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#resource_group_name-1">PrivateDnsARecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsARecordState<'Name, 'Records, Missing, 'Ttl, 'ZoneName>, value: string) : PrivateDnsARecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsARecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#ttl-1">PrivateDnsARecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#zone_name-1">PrivateDnsARecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Missing>, value: string) : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#id-1">PrivateDnsARecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#tags-1">PrivateDnsARecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_a_record#timeouts-1">PrivateDnsARecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.PrivateDnsARecord.PrivateDnsARecordTimeouts) : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsARecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: PrivateDnsARecordState<Present, Present, Present, Present, Present>) : azurerm.PrivateDnsARecord.PrivateDnsARecord =
            let config = azurerm.PrivateDnsARecord.PrivateDnsARecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsARecord.PrivateDnsARecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsARecord: missing required arguments. Must call: name, records, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsARecordState<_, _, _, _, _>) : azurerm.PrivateDnsARecord.PrivateDnsARecord =
            Unchecked.defaultof<azurerm.PrivateDnsARecord.PrivateDnsARecord>
