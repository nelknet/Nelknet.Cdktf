namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.KubernetesCluster.KubernetesClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster">azurerm_kubernetes_cluster</a>.
    /// </summary>
    type KubernetesClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// default_node_pool block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#default_node_pool-1">KubernetesCluster#default_node_pool</a>
        /// </summary>
        [<CustomOperation "default_node_pool">]
        member _.DefaultNodePool(state: KubernetesClusterState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterDefaultNodePool) : KubernetesClusterState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultNodePool <- value)
            ({ assignments = state.assignments } : KubernetesClusterState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#location-1">KubernetesCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KubernetesClusterState<'DefaultNodePool, Missing, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KubernetesClusterState<'DefaultNodePool, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#name-1">KubernetesCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesClusterState<'DefaultNodePool, 'Location, Missing, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesClusterState<'DefaultNodePool, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#resource_group_name-1">KubernetesCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, Missing>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, Present>)

        /// <summary>
        /// aci_connector_linux block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#aci_connector_linux-1">KubernetesCluster#aci_connector_linux</a>
        /// </summary>
        [<CustomOperation "aci_connector_linux">]
        member _.AciConnectorLinux(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterAciConnectorLinux) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AciConnectorLinux <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// api_server_access_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#api_server_access_profile-1">KubernetesCluster#api_server_access_profile</a>
        /// </summary>
        [<CustomOperation "api_server_access_profile">]
        member _.ApiServerAccessProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterApiServerAccessProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiServerAccessProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#automatic_upgrade_channel-1">KubernetesCluster#automatic_upgrade_channel</a>.
        /// </summary>
        [<CustomOperation "automatic_upgrade_channel">]
        member _.AutomaticUpgradeChannel(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeChannel <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// auto_scaler_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#auto_scaler_profile-1">KubernetesCluster#auto_scaler_profile</a>
        /// </summary>
        [<CustomOperation "auto_scaler_profile">]
        member _.AutoScalerProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterAutoScalerProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoScalerProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// azure_active_directory_role_based_access_control block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_active_directory_role_based_access_control-1">KubernetesCluster#azure_active_directory_role_based_access_control</a>
        /// </summary>
        [<CustomOperation "azure_active_directory_role_based_access_control">]
        member _.AzureActiveDirectoryRoleBasedAccessControl(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControl) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzureActiveDirectoryRoleBasedAccessControl <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_policy_enabled-1">KubernetesCluster#azure_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azure_policy_enabled">]
        member _.AzurePolicyEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzurePolicyEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_policy_enabled-1">KubernetesCluster#azure_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azure_policy_enabled">]
        member _.AzurePolicyEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzurePolicyEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// confidential_computing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#confidential_computing-1">KubernetesCluster#confidential_computing</a>
        /// </summary>
        [<CustomOperation "confidential_computing">]
        member _.ConfidentialComputing(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterConfidentialComputing) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfidentialComputing <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cost_analysis_enabled-1">KubernetesCluster#cost_analysis_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cost_analysis_enabled">]
        member _.CostAnalysisEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CostAnalysisEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cost_analysis_enabled-1">KubernetesCluster#cost_analysis_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cost_analysis_enabled">]
        member _.CostAnalysisEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CostAnalysisEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#disk_encryption_set_id-1">KubernetesCluster#disk_encryption_set_id</a>.
        /// </summary>
        [<CustomOperation "disk_encryption_set_id">]
        member _.DiskEncryptionSetId(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DiskEncryptionSetId <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix-1">KubernetesCluster#dns_prefix</a>.
        /// </summary>
        [<CustomOperation "dns_prefix">]
        member _.DnsPrefix(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsPrefix <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix_private_cluster-1">KubernetesCluster#dns_prefix_private_cluster</a>.
        /// </summary>
        [<CustomOperation "dns_prefix_private_cluster">]
        member _.DnsPrefixPrivateCluster(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsPrefixPrivateCluster <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#edge_zone-1">KubernetesCluster#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_application_routing_enabled-1">KubernetesCluster#http_application_routing_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "http_application_routing_enabled">]
        member _.HttpApplicationRoutingEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpApplicationRoutingEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_application_routing_enabled-1">KubernetesCluster#http_application_routing_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "http_application_routing_enabled">]
        member _.HttpApplicationRoutingEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpApplicationRoutingEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// http_proxy_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy_config-1">KubernetesCluster#http_proxy_config</a>
        /// </summary>
        [<CustomOperation "http_proxy_config">]
        member _.HttpProxyConfig(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterHttpProxyConfig) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpProxyConfig <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#id-1">KubernetesCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#identity-1">KubernetesCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterIdentity) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_enabled-1">KubernetesCluster#image_cleaner_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "image_cleaner_enabled">]
        member _.ImageCleanerEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImageCleanerEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_enabled-1">KubernetesCluster#image_cleaner_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "image_cleaner_enabled">]
        member _.ImageCleanerEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImageCleanerEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_interval_hours-1">KubernetesCluster#image_cleaner_interval_hours</a>.
        /// </summary>
        [<CustomOperation "image_cleaner_interval_hours">]
        member _.ImageCleanerIntervalHours(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: double) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImageCleanerIntervalHours <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// ingress_application_gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ingress_application_gateway-1">KubernetesCluster#ingress_application_gateway</a>
        /// </summary>
        [<CustomOperation "ingress_application_gateway">]
        member _.IngressApplicationGateway(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterIngressApplicationGateway) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IngressApplicationGateway <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// key_management_service block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_management_service-1">KubernetesCluster#key_management_service</a>
        /// </summary>
        [<CustomOperation "key_management_service">]
        member _.KeyManagementService(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterKeyManagementService) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyManagementService <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// key_vault_secrets_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_secrets_provider-1">KubernetesCluster#key_vault_secrets_provider</a>
        /// </summary>
        [<CustomOperation "key_vault_secrets_provider">]
        member _.KeyVaultSecretsProvider(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterKeyVaultSecretsProvider) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultSecretsProvider <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// kubelet_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_identity-1">KubernetesCluster#kubelet_identity</a>
        /// </summary>
        [<CustomOperation "kubelet_identity">]
        member _.KubeletIdentity(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterKubeletIdentity) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KubeletIdentity <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubernetes_version-1">KubernetesCluster#kubernetes_version</a>.
        /// </summary>
        [<CustomOperation "kubernetes_version">]
        member _.KubernetesVersion(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KubernetesVersion <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// linux_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#linux_profile-1">KubernetesCluster#linux_profile</a>
        /// </summary>
        [<CustomOperation "linux_profile">]
        member _.LinuxProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterLinuxProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LinuxProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#local_account_disabled-1">KubernetesCluster#local_account_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_account_disabled">]
        member _.LocalAccountDisabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAccountDisabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#local_account_disabled-1">KubernetesCluster#local_account_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_account_disabled">]
        member _.LocalAccountDisabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAccountDisabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// maintenance_window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window-1">KubernetesCluster#maintenance_window</a>
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindow) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// maintenance_window_auto_upgrade block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_auto_upgrade-1">KubernetesCluster#maintenance_window_auto_upgrade</a>
        /// </summary>
        [<CustomOperation "maintenance_window_auto_upgrade">]
        member _.MaintenanceWindowAutoUpgrade(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgrade) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaintenanceWindowAutoUpgrade <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// maintenance_window_node_os block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_node_os-1">KubernetesCluster#maintenance_window_node_os</a>
        /// </summary>
        [<CustomOperation "maintenance_window_node_os">]
        member _.MaintenanceWindowNodeOs(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaintenanceWindowNodeOs <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// microsoft_defender block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#microsoft_defender-1">KubernetesCluster#microsoft_defender</a>
        /// </summary>
        [<CustomOperation "microsoft_defender">]
        member _.MicrosoftDefender(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterMicrosoftDefender) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MicrosoftDefender <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// monitor_metrics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#monitor_metrics-1">KubernetesCluster#monitor_metrics</a>
        /// </summary>
        [<CustomOperation "monitor_metrics">]
        member _.MonitorMetrics(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterMonitorMetrics) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MonitorMetrics <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_profile-1">KubernetesCluster#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterNetworkProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_os_upgrade_channel-1">KubernetesCluster#node_os_upgrade_channel</a>.
        /// </summary>
        [<CustomOperation "node_os_upgrade_channel">]
        member _.NodeOsUpgradeChannel(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeOsUpgradeChannel <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_resource_group-1">KubernetesCluster#node_resource_group</a>.
        /// </summary>
        [<CustomOperation "node_resource_group">]
        member _.NodeResourceGroup(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeResourceGroup <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oidc_issuer_enabled-1">KubernetesCluster#oidc_issuer_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "oidc_issuer_enabled">]
        member _.OidcIssuerEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OidcIssuerEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oidc_issuer_enabled-1">KubernetesCluster#oidc_issuer_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "oidc_issuer_enabled">]
        member _.OidcIssuerEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OidcIssuerEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// oms_agent block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oms_agent-1">KubernetesCluster#oms_agent</a>
        /// </summary>
        [<CustomOperation "oms_agent">]
        member _.OmsAgent(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterOmsAgent) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OmsAgent <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#open_service_mesh_enabled-1">KubernetesCluster#open_service_mesh_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "open_service_mesh_enabled">]
        member _.OpenServiceMeshEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OpenServiceMeshEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#open_service_mesh_enabled-1">KubernetesCluster#open_service_mesh_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "open_service_mesh_enabled">]
        member _.OpenServiceMeshEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OpenServiceMeshEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_enabled-1">KubernetesCluster#private_cluster_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_cluster_enabled">]
        member _.PrivateClusterEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateClusterEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_enabled-1">KubernetesCluster#private_cluster_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_cluster_enabled">]
        member _.PrivateClusterEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateClusterEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_public_fqdn_enabled-1">KubernetesCluster#private_cluster_public_fqdn_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_cluster_public_fqdn_enabled">]
        member _.PrivateClusterPublicFqdnEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateClusterPublicFqdnEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_public_fqdn_enabled-1">KubernetesCluster#private_cluster_public_fqdn_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_cluster_public_fqdn_enabled">]
        member _.PrivateClusterPublicFqdnEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateClusterPublicFqdnEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_dns_zone_id-1">KubernetesCluster#private_dns_zone_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_zone_id">]
        member _.PrivateDnsZoneId(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateDnsZoneId <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#role_based_access_control_enabled-1">KubernetesCluster#role_based_access_control_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "role_based_access_control_enabled">]
        member _.RoleBasedAccessControlEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RoleBasedAccessControlEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#role_based_access_control_enabled-1">KubernetesCluster#role_based_access_control_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "role_based_access_control_enabled">]
        member _.RoleBasedAccessControlEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RoleBasedAccessControlEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#run_command_enabled-1">KubernetesCluster#run_command_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "run_command_enabled">]
        member _.RunCommandEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RunCommandEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#run_command_enabled-1">KubernetesCluster#run_command_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "run_command_enabled">]
        member _.RunCommandEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RunCommandEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// service_mesh_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_mesh_profile-1">KubernetesCluster#service_mesh_profile</a>
        /// </summary>
        [<CustomOperation "service_mesh_profile">]
        member _.ServiceMeshProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterServiceMeshProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceMeshProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// service_principal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_principal-1">KubernetesCluster#service_principal</a>
        /// </summary>
        [<CustomOperation "service_principal">]
        member _.ServicePrincipal(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterServicePrincipal) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServicePrincipal <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#sku_tier-1">KubernetesCluster#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// storage_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#storage_profile-1">KubernetesCluster#storage_profile</a>
        /// </summary>
        [<CustomOperation "storage_profile">]
        member _.StorageProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterStorageProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#support_plan-1">KubernetesCluster#support_plan</a>.
        /// </summary>
        [<CustomOperation "support_plan">]
        member _.SupportPlan(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SupportPlan <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#tags-1">KubernetesCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#timeouts-1">KubernetesCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterTimeouts) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// web_app_routing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#web_app_routing-1">KubernetesCluster#web_app_routing</a>
        /// </summary>
        [<CustomOperation "web_app_routing">]
        member _.WebAppRouting(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterWebAppRouting) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WebAppRouting <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// windows_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#windows_profile-1">KubernetesCluster#windows_profile</a>
        /// </summary>
        [<CustomOperation "windows_profile">]
        member _.WindowsProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterWindowsProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WindowsProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// workload_autoscaler_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_autoscaler_profile-1">KubernetesCluster#workload_autoscaler_profile</a>
        /// </summary>
        [<CustomOperation "workload_autoscaler_profile">]
        member _.WorkloadAutoscalerProfile(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkloadAutoscalerProfile <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_identity_enabled-1">KubernetesCluster#workload_identity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "workload_identity_enabled">]
        member _.WorkloadIdentityEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: bool) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkloadIdentityEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_identity_enabled-1">KubernetesCluster#workload_identity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "workload_identity_enabled">]
        member _.WorkloadIdentityEnabled(state: KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkloadIdentityEnabled <- value)
            state : KubernetesClusterState<'DefaultNodePool, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: KubernetesClusterState<Present, Present, Present, Present>) : azurerm.KubernetesCluster.KubernetesCluster =
            let config = azurerm.KubernetesCluster.KubernetesClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesCluster.KubernetesCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesCluster: missing required arguments. Must call: default_node_pool, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: KubernetesClusterState<_, _, _, _>) : azurerm.KubernetesCluster.KubernetesCluster =
            Unchecked.defaultof<azurerm.KubernetesCluster.KubernetesCluster>
