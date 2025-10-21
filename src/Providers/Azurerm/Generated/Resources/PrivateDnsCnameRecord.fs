namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> = { assignments: ResizeArray<azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record">azurerm_private_dns_cname_record</a>.
    /// </summary>
    type PrivateDnsCnameRecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsCnameRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsCnameRecordState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsCnameRecordState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsCnameRecordState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#name-1">PrivateDnsCnameRecord#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsCnameRecordState<Missing, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsCnameRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsCnameRecordState<Present, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#record-1">PrivateDnsCnameRecord#record</a>.
        /// </summary>
        [<CustomOperation "record">]
        member _.Record(state: PrivateDnsCnameRecordState<'Name, Missing, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsCnameRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Record <- value)
            ({ assignments = state.assignments } : PrivateDnsCnameRecordState<'Name, Present, 'ResourceGroupName, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#resource_group_name-1">PrivateDnsCnameRecord#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsCnameRecordState<'Name, 'Record, Missing, 'Ttl, 'ZoneName>, value: string) : PrivateDnsCnameRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsCnameRecordState<'Name, 'Record, Present, 'Ttl, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#ttl-1">PrivateDnsCnameRecord#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, Missing, 'ZoneName>, value: double) : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, Present, 'ZoneName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#zone_name-1">PrivateDnsCnameRecord#zone_name</a>.
        /// </summary>
        [<CustomOperation "zone_name">]
        member _.ZoneName(state: PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Missing>, value: string) : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.ZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#id-1">PrivateDnsCnameRecord#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: string) : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#tags-1">PrivateDnsCnameRecord#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: seq<string * string>) : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_cname_record#timeouts-1">PrivateDnsCnameRecord#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>, value: azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecordTimeouts) : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsCnameRecordState<'Name, 'Record, 'ResourceGroupName, 'Ttl, 'ZoneName>

        member _.Run(state: PrivateDnsCnameRecordState<Present, Present, Present, Present, Present>) : azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecord =
            let config = azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecordConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecord(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsCnameRecord: missing required arguments. Must call: name, record, resource_group_name, ttl, zone_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsCnameRecordState<_, _, _, _, _>) : azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecord =
            Unchecked.defaultof<azurerm.PrivateDnsCnameRecord.PrivateDnsCnameRecord>
