namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.PrivateDnsMxRecord.PrivateDnsMxRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record">azurerm_private_dns_mx_record</a>.
    /// </summary>
    type PrivateDnsMxRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsMxRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsMxRecordState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsMxRecordState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsMxRecordState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#record-1">PrivateDnsMxRecord#record</a> Accepts: azurerm.IResolvable | azurerm.PrivateDnsMxRecord.PrivateDnsMxRecordRecord[]
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: PrivateDnsMxRecordState<Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: HashiCorp.Cdktf.IResolvable) : PrivateDnsMxRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : PrivateDnsMxRecordState<Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#resource_group_name-1">PrivateDnsMxRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsMxRecordState<'Record, Missing, 'Ttl, 'ZoneName>, value: string) : PrivateDnsMxRecordState<'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsMxRecordState<'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#ttl-1">PrivateDnsMxRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: PrivateDnsMxRecordState<'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#zone_name-1">PrivateDnsMxRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#id-1">PrivateDnsMxRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#name-1">PrivateDnsMxRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#tags-1">PrivateDnsMxRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#timeouts-1">PrivateDnsMxRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.PrivateDnsMxRecord.PrivateDnsMxRecordTimeouts) : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsMxRecordState<'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: PrivateDnsMxRecordState<Present, Present, Present, Present>) : azurerm.PrivateDnsMxRecord.PrivateDnsMxRecord =
            let config = azurerm.PrivateDnsMxRecord.PrivateDnsMxRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsMxRecord.PrivateDnsMxRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsMxRecord: missing required arguments. Must call: record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsMxRecordState<_, _, _, _>) : azurerm.PrivateDnsMxRecord.PrivateDnsMxRecord =
            Unchecked.defaultof<azurerm.PrivateDnsMxRecord.PrivateDnsMxRecord>
