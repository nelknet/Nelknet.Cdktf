namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticSanVolumeGroupState<'ElasticSanId, 'Name> = { assignments: ResizeArray<azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group">azurerm_elastic_san_volume_group</a>.
    /// </summary>
    type ElasticSanVolumeGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticSanVolumeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticSanVolumeGroupState<Missing, Missing>)

        member _.Zero(()) : ElasticSanVolumeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticSanVolumeGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#elastic_san_id-1">ElasticSanVolumeGroup#elastic_san_id</a>.
        /// </summary>
        [<CustomOperation "elastic_san_id">]
        member _.ElasticSanId(state: ElasticSanVolumeGroupState<Missing, 'Name>, value: string) : ElasticSanVolumeGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ElasticSanId <- value)
            ({ assignments = state.assignments } : ElasticSanVolumeGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#name-1">ElasticSanVolumeGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticSanVolumeGroupState<'ElasticSanId, Missing>, value: string) : ElasticSanVolumeGroupState<'ElasticSanId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticSanVolumeGroupState<'ElasticSanId, Present>)

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#encryption-1">ElasticSanVolumeGroup#encryption</a>
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupEncryption) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#encryption_type-1">ElasticSanVolumeGroup#encryption_type</a>.
        /// </summary>
        [<CustomOperation "encryption_type">]
        member _.EncryptionType(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: string) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.EncryptionType <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#id-1">ElasticSanVolumeGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: string) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#identity-1">ElasticSanVolumeGroup#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupIdentity) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// network_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#network_rule-1">ElasticSanVolumeGroup#network_rule</a> Accepts: azurerm.IResolvable | azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupNetworkRule[]
        /// </summary>
        [<CustomOperation "network_rule">]
        member _.NetworkRule(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.NetworkRule <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#protocol_type-1">ElasticSanVolumeGroup#protocol_type</a>.
        /// </summary>
        [<CustomOperation "protocol_type">]
        member _.ProtocolType(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: string) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.ProtocolType <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume_group#timeouts-1">ElasticSanVolumeGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupTimeouts) : ElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        member _.Run(state: ElasticSanVolumeGroupState<Present, Present>) : azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup =
            let config = azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.elasticSanVolumeGroup: missing required arguments. Must call: elastic_san_id, name.", 9999, IsError = true)>]
        member _.Run(_: ElasticSanVolumeGroupState<_, _>) : azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup =
            Unchecked.defaultof<azurerm.ElasticSanVolumeGroup.ElasticSanVolumeGroup>
