namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> = { assignments: ResizeArray<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace">azurerm_machine_learning_workspace</a>.
    /// </summary>
    type MachineLearningWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningWorkspaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningWorkspaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningWorkspaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningWorkspaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#application_insights_id-1">MachineLearningWorkspace#application_insights_id</a>.
        /// </summary>
        [<CustomOperation "application_insights_id">]
        member _.ApplicationInsightsId(state: MachineLearningWorkspaceState<Missing, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<Present, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ApplicationInsightsId <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<Present, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#identity-1">MachineLearningWorkspace#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MachineLearningWorkspaceState<'ApplicationInsightsId, Missing, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.MachineLearningWorkspace.MachineLearningWorkspaceIdentity) : MachineLearningWorkspaceState<'ApplicationInsightsId, Present, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<'ApplicationInsightsId, Present, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#key_vault_id-1">MachineLearningWorkspace#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, Missing, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#location-1">MachineLearningWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, Missing, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, Present, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, Present, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#name-1">MachineLearningWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, Missing, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, Present, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, Present, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#resource_group_name-1">MachineLearningWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, Missing, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#storage_account_id-1">MachineLearningWorkspace#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#container_registry_id-1">MachineLearningWorkspace#container_registry_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_id">]
        member _.ContainerRegistryId(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ContainerRegistryId <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#description-1">MachineLearningWorkspace#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#encryption-1">MachineLearningWorkspace#encryption</a>
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.MachineLearningWorkspace.MachineLearningWorkspaceEncryption) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// feature_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#feature_store-1">MachineLearningWorkspace#feature_store</a>
        /// </summary>
        [<CustomOperation "feature_store">]
        member _.FeatureStore(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.MachineLearningWorkspace.MachineLearningWorkspaceFeatureStore) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FeatureStore <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#friendly_name-1">MachineLearningWorkspace#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#high_business_impact-1">MachineLearningWorkspace#high_business_impact</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "high_business_impact">]
        member _.HighBusinessImpact(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: bool) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.HighBusinessImpact <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#high_business_impact-1">MachineLearningWorkspace#high_business_impact</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "high_business_impact">]
        member _.HighBusinessImpact(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.HighBusinessImpact <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#id-1">MachineLearningWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#image_build_compute_name-1">MachineLearningWorkspace#image_build_compute_name</a>.
        /// </summary>
        [<CustomOperation "image_build_compute_name">]
        member _.ImageBuildComputeName(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ImageBuildComputeName <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#kind-1">MachineLearningWorkspace#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// managed_network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#managed_network-1">MachineLearningWorkspace#managed_network</a>
        /// </summary>
        [<CustomOperation "managed_network">]
        member _.ManagedNetwork(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.MachineLearningWorkspace.MachineLearningWorkspaceManagedNetwork) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ManagedNetwork <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#primary_user_assigned_identity-1">MachineLearningWorkspace#primary_user_assigned_identity</a>.
        /// </summary>
        [<CustomOperation "primary_user_assigned_identity">]
        member _.PrimaryUserAssignedIdentity(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.PrimaryUserAssignedIdentity <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#public_network_access_enabled-1">MachineLearningWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: bool) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#public_network_access_enabled-1">MachineLearningWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// serverless_compute block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#serverless_compute-1">MachineLearningWorkspace#serverless_compute</a>
        /// </summary>
        [<CustomOperation "serverless_compute">]
        member _.ServerlessCompute(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.MachineLearningWorkspace.MachineLearningWorkspaceServerlessCompute) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ServerlessCompute <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#sku_name-1">MachineLearningWorkspace#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#tags-1">MachineLearningWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: seq<string * string>) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#timeouts-1">MachineLearningWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.MachineLearningWorkspace.MachineLearningWorkspaceTimeouts) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#v1_legacy_mode_enabled-1">MachineLearningWorkspace#v1_legacy_mode_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "v1_legacy_mode_enabled">]
        member _.V1LegacyModeEnabled(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: bool) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.V1LegacyModeEnabled <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#v1_legacy_mode_enabled-1">MachineLearningWorkspace#v1_legacy_mode_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "v1_legacy_mode_enabled">]
        member _.V1LegacyModeEnabled(state: MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.V1LegacyModeEnabled <- value)
            state : MachineLearningWorkspaceState<'ApplicationInsightsId, 'Identity, 'KeyVaultId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        member _.Run(state: MachineLearningWorkspaceState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.MachineLearningWorkspace.MachineLearningWorkspace =
            let config = azurerm.MachineLearningWorkspace.MachineLearningWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningWorkspace.MachineLearningWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningWorkspace: missing required arguments. Must call: application_insights_id, identity, key_vault_id, location, name, resource_group_name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningWorkspaceState<_, _, _, _, _, _, _>) : azurerm.MachineLearningWorkspace.MachineLearningWorkspace =
            Unchecked.defaultof<azurerm.MachineLearningWorkspace.MachineLearningWorkspace>
