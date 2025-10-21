namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.Snapshot.SnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot">azurerm_snapshot</a>.
    /// </summary>
    type SnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnapshotState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SnapshotState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SnapshotState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SnapshotState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#create_option-1">Snapshot#create_option</a>.
        /// </summary>
        [<CustomOperation "create_option">]
        member _.CreateOption(state: SnapshotState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CreateOption <- value)
            ({ assignments = state.assignments } : SnapshotState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#location-1">Snapshot#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SnapshotState<'CreateOption, Missing, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SnapshotState<'CreateOption, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#name-1">Snapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SnapshotState<'CreateOption, 'Location, Missing, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SnapshotState<'CreateOption, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#resource_group_name-1">Snapshot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SnapshotState<'CreateOption, 'Location, 'Name, Missing>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SnapshotState<'CreateOption, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#disk_access_id-1">Snapshot#disk_access_id</a>.
        /// </summary>
        [<CustomOperation "disk_access_id">]
        member _.DiskAccessId(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DiskAccessId <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#disk_size_gb-1">Snapshot#disk_size_gb</a>.
        /// </summary>
        [<CustomOperation "disk_size_gb">]
        member _.DiskSizeGb(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: double) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DiskSizeGb <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// encryption_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#encryption_settings-1">Snapshot#encryption_settings</a>
        /// </summary>
        [<CustomOperation "encryption_settings">]
        member _.EncryptionSettings(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.Snapshot.SnapshotEncryptionSettings) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EncryptionSettings <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#id-1">Snapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#incremental_enabled-1">Snapshot#incremental_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "incremental_enabled">]
        member _.IncrementalEnabled(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: bool) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IncrementalEnabled <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#incremental_enabled-1">Snapshot#incremental_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "incremental_enabled">]
        member _.IncrementalEnabled(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IncrementalEnabled <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#network_access_policy-1">Snapshot#network_access_policy</a>.
        /// </summary>
        [<CustomOperation "network_access_policy">]
        member _.NetworkAccessPolicy(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkAccessPolicy <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#public_network_access_enabled-1">Snapshot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: bool) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#public_network_access_enabled-1">Snapshot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#source_resource_id-1">Snapshot#source_resource_id</a>.
        /// </summary>
        [<CustomOperation "source_resource_id">]
        member _.SourceResourceId(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceResourceId <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#source_uri-1">Snapshot#source_uri</a>.
        /// </summary>
        [<CustomOperation "source_uri">]
        member _.SourceUri(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceUri <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#storage_account_id-1">Snapshot#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: string) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#tags-1">Snapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#timeouts-1">Snapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.Snapshot.SnapshotTimeouts) : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SnapshotState<'CreateOption, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: SnapshotState<Present, Present, Present, Present>) : azurerm.Snapshot.Snapshot =
            let config = azurerm.Snapshot.SnapshotConfig()
            for setter in state.assignments do
                setter config
            azurerm.Snapshot.Snapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.snapshot: missing required arguments. Must call: create_option, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SnapshotState<_, _, _, _>) : azurerm.Snapshot.Snapshot =
            Unchecked.defaultof<azurerm.Snapshot.Snapshot>
