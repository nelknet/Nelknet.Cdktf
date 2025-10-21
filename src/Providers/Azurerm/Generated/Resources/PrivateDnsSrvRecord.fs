namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record">azurerm_private_dns_srv_record</a>.
    /// </summary>
    type PrivateDnsSrvRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsSrvRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsSrvRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsSrvRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsSrvRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#name-1">PrivateDnsSrvRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsSrvRecordState<Missing, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsSrvRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsSrvRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#record-1">PrivateDnsSrvRecord#record</a> Accepts: azurerm.IResolvable | azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecordRecord[]
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: PrivateDnsSrvRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: HashiCorp.Cdktf.IResolvable) : PrivateDnsSrvRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : PrivateDnsSrvRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#resource_group_name-1">PrivateDnsSrvRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsSrvRecordState<'Name, 'Record, Missing, 'Ttl, 'ZoneName>, value: string) : PrivateDnsSrvRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsSrvRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#ttl-1">PrivateDnsSrvRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#zone_name-1">PrivateDnsSrvRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#id-1">PrivateDnsSrvRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#tags-1">PrivateDnsSrvRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_srv_record#timeouts-1">PrivateDnsSrvRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecordTimeouts) : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsSrvRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: PrivateDnsSrvRecordState<Present, Present, Present, Present, Present>) : azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecord =
            let config = azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsSrvRecord: missing required arguments. Must call: name, record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsSrvRecordState<_, _, _, _, _>) : azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecord =
            Unchecked.defaultof<azurerm.PrivateDnsSrvRecord.PrivateDnsSrvRecord>
