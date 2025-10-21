namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record">azurerm_private_dns_ptr_record</a>.
    /// </summary>
    type PrivateDnsPtrRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsPtrRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsPtrRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsPtrRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsPtrRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#name-1">PrivateDnsPtrRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsPtrRecordState<Missing, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsPtrRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsPtrRecordState<Present, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#records-1">PrivateDnsPtrRecord#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: PrivateDnsPtrRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string>) : PrivateDnsPtrRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PrivateDnsPtrRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#resource_group_name-1">PrivateDnsPtrRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsPtrRecordState<'Name, 'Records, Missing, 'Ttl, 'ZoneName>, value: string) : PrivateDnsPtrRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsPtrRecordState<'Name, 'Records, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#ttl-1">PrivateDnsPtrRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#zone_name-1">PrivateDnsPtrRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Missing>, value: string) : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#id-1">PrivateDnsPtrRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#tags-1">PrivateDnsPtrRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_ptr_record#timeouts-1">PrivateDnsPtrRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecordTimeouts) : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsPtrRecordState<'Name, 'Records, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: PrivateDnsPtrRecordState<Present, Present, Present, Present, Present>) : azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecord =
            let config = azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsPtrRecord: missing required arguments. Must call: name, records, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsPtrRecordState<_, _, _, _, _>) : azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecord =
            Unchecked.defaultof<azurerm.PrivateDnsPtrRecord.PrivateDnsPtrRecord>
