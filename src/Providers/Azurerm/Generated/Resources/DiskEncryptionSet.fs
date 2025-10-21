namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DiskEncryptionSet.DiskEncryptionSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set">azurerm_disk_encryption_set</a>.
    /// </summary>
    type DiskEncryptionSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DiskEncryptionSetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DiskEncryptionSetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DiskEncryptionSetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DiskEncryptionSetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#identity-1">DiskEncryptionSet#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DiskEncryptionSetState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DiskEncryptionSet.DiskEncryptionSetIdentity) : DiskEncryptionSetState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : DiskEncryptionSetState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#location-1">DiskEncryptionSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DiskEncryptionSetState<'Identity, Missing, 'Name, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DiskEncryptionSetState<'Identity, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#name-1">DiskEncryptionSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DiskEncryptionSetState<'Identity, 'Location, Missing, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DiskEncryptionSetState<'Identity, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#resource_group_name-1">DiskEncryptionSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, Missing>, value: string) : DiskEncryptionSetState<'Identity, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DiskEncryptionSetState<'Identity, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#auto_key_rotation_enabled-1">DiskEncryptionSet#auto_key_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_key_rotation_enabled">]
        member _.AutoKeyRotationEnabled(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: bool) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoKeyRotationEnabled <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#auto_key_rotation_enabled-1">DiskEncryptionSet#auto_key_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_key_rotation_enabled">]
        member _.AutoKeyRotationEnabled(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoKeyRotationEnabled <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#encryption_type-1">DiskEncryptionSet#encryption_type</a>.
        /// </summary>
        [<CustomOperation "encryption_type">]
        member _.EncryptionType(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EncryptionType <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#federated_client_id-1">DiskEncryptionSet#federated_client_id</a>.
        /// </summary>
        [<CustomOperation "federated_client_id">]
        member _.FederatedClientId(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FederatedClientId <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#id-1">DiskEncryptionSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#key_vault_key_id-1">DiskEncryptionSet#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#managed_hsm_key_id-1">DiskEncryptionSet#managed_hsm_key_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_key_id">]
        member _.ManagedHsmKeyId(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedHsmKeyId <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#tags-1">DiskEncryptionSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_encryption_set#timeouts-1">DiskEncryptionSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DiskEncryptionSet.DiskEncryptionSetTimeouts) : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DiskEncryptionSetState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DiskEncryptionSetState<Present, Present, Present, Present>) : azurerm.DiskEncryptionSet.DiskEncryptionSet =
            let config = azurerm.DiskEncryptionSet.DiskEncryptionSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DiskEncryptionSet.DiskEncryptionSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.diskEncryptionSet: missing required arguments. Must call: identity, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DiskEncryptionSetState<_, _, _, _>) : azurerm.DiskEncryptionSet.DiskEncryptionSet =
            Unchecked.defaultof<azurerm.DiskEncryptionSet.DiskEncryptionSet>
