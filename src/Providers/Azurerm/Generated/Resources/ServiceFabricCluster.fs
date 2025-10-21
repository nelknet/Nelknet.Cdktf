namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> = { assignments: ResizeArray<azurerm.ServiceFabricCluster.ServiceFabricClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster">azurerm_service_fabric_cluster</a>.
    /// </summary>
    type ServiceFabricClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServiceFabricClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceFabricClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServiceFabricClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceFabricClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#location-1">ServiceFabricCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ServiceFabricClusterState<Missing, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<Present, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<Present, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#management_endpoint-1">ServiceFabricCluster#management_endpoint</a>.
        /// </summary>
        [<CustomOperation "management_endpoint">]
        member _.ManagementEndpoint(state: ServiceFabricClusterState<'Location, Missing, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, Present, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ManagementEndpoint <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, Present, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#name-1">ServiceFabricCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, Missing, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, Present, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, 'ManagementEndpoint, Present, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>)

        /// <summary>
        /// node_type block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#node_type-1">ServiceFabricCluster#node_type</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricCluster.ServiceFabricClusterNodeType[]
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, Missing, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, Present, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, Present, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reliability_level-1">ServiceFabricCluster#reliability_level</a>.
        /// </summary>
        [<CustomOperation "reliability_level">]
        member _.ReliabilityLevel(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, Missing, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, Present, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ReliabilityLevel <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, Present, 'ResourceGroupName, 'UpgradeMode, 'VmImage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#resource_group_name-1">ServiceFabricCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, Missing, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, Present, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, Present, 'UpgradeMode, 'VmImage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_mode-1">ServiceFabricCluster#upgrade_mode</a>.
        /// </summary>
        [<CustomOperation "upgrade_mode">]
        member _.UpgradeMode(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, Missing, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, Present, 'VmImage> =
            state.assignments.Add(fun config -> config.UpgradeMode <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, Present, 'VmImage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#vm_image-1">ServiceFabricCluster#vm_image</a>.
        /// </summary>
        [<CustomOperation "vm_image">]
        member _.VmImage(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, Missing>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, Present> =
            state.assignments.Add(fun config -> config.VmImage <- value)
            ({ assignments = state.assignments } : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#add_on_features-1">ServiceFabricCluster#add_on_features</a>.
        /// </summary>
        [<CustomOperation "add_on_features">]
        member _.AddOnFeatures(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: seq<string>) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.AddOnFeatures <- (value |> Seq.toArray))
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// azure_active_directory block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#azure_active_directory-1">ServiceFabricCluster#azure_active_directory</a>
        /// </summary>
        [<CustomOperation "azure_active_directory">]
        member _.AzureActiveDirectory(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterAzureActiveDirectory) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.AzureActiveDirectory <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate-1">ServiceFabricCluster#certificate</a>
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterCertificate) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// certificate_common_names block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_common_names-1">ServiceFabricCluster#certificate_common_names</a>
        /// </summary>
        [<CustomOperation "certificate_common_names">]
        member _.CertificateCommonNames(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateCommonNames) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.CertificateCommonNames <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// client_certificate_common_name block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_certificate_common_name-1">ServiceFabricCluster#client_certificate_common_name</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricCluster.ServiceFabricClusterClientCertificateCommonName[]
        /// </summary>
        [<CustomOperation "client_certificate_common_name">]
        member _.ClientCertificateCommonName(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ClientCertificateCommonName <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// client_certificate_thumbprint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_certificate_thumbprint-1">ServiceFabricCluster#client_certificate_thumbprint</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricCluster.ServiceFabricClusterClientCertificateThumbprint[]
        /// </summary>
        [<CustomOperation "client_certificate_thumbprint">]
        member _.ClientCertificateThumbprint(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ClientCertificateThumbprint <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#cluster_code_version-1">ServiceFabricCluster#cluster_code_version</a>.
        /// </summary>
        [<CustomOperation "cluster_code_version">]
        member _.ClusterCodeVersion(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ClusterCodeVersion <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// diagnostics_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#diagnostics_config-1">ServiceFabricCluster#diagnostics_config</a>
        /// </summary>
        [<CustomOperation "diagnostics_config">]
        member _.DiagnosticsConfig(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterDiagnosticsConfig) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.DiagnosticsConfig <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// fabric_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#fabric_settings-1">ServiceFabricCluster#fabric_settings</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricCluster.ServiceFabricClusterFabricSettings[]
        /// </summary>
        [<CustomOperation "fabric_settings">]
        member _.FabricSettings(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.FabricSettings <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#id-1">ServiceFabricCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// reverse_proxy_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_certificate-1">ServiceFabricCluster#reverse_proxy_certificate</a>
        /// </summary>
        [<CustomOperation "reverse_proxy_certificate">]
        member _.ReverseProxyCertificate(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterReverseProxyCertificate) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ReverseProxyCertificate <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// reverse_proxy_certificate_common_names block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_certificate_common_names-1">ServiceFabricCluster#reverse_proxy_certificate_common_names</a>
        /// </summary>
        [<CustomOperation "reverse_proxy_certificate_common_names">]
        member _.ReverseProxyCertificateCommonNames(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNames) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ReverseProxyCertificateCommonNames <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#service_fabric_zonal_upgrade_mode-1">ServiceFabricCluster#service_fabric_zonal_upgrade_mode</a>.
        /// </summary>
        [<CustomOperation "service_fabric_zonal_upgrade_mode">]
        member _.ServiceFabricZonalUpgradeMode(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.ServiceFabricZonalUpgradeMode <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#tags-1">ServiceFabricCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: seq<string * string>) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#timeouts-1">ServiceFabricCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterTimeouts) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_policy-1">ServiceFabricCluster#upgrade_policy</a>
        /// </summary>
        [<CustomOperation "upgrade_policy">]
        member _.UpgradePolicy(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicy) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.UpgradePolicy <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#vmss_zonal_upgrade_mode-1">ServiceFabricCluster#vmss_zonal_upgrade_mode</a>.
        /// </summary>
        [<CustomOperation "vmss_zonal_upgrade_mode">]
        member _.VmssZonalUpgradeMode(state: ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>, value: string) : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage> =
            state.assignments.Add(fun config -> config.VmssZonalUpgradeMode <- value)
            state : ServiceFabricClusterState<'Location, 'ManagementEndpoint, 'Name, 'NodeType, 'ReliabilityLevel, 'ResourceGroupName, 'UpgradeMode, 'VmImage>

        member _.Run(state: ServiceFabricClusterState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.ServiceFabricCluster.ServiceFabricCluster =
            let config = azurerm.ServiceFabricCluster.ServiceFabricClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServiceFabricCluster.ServiceFabricCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.serviceFabricCluster: missing required arguments. Must call: location, management_endpoint, name, node_type, reliability_level, resource_group_name, upgrade_mode, vm_image.", 9999, IsError = true)>]
        member _.Run(_: ServiceFabricClusterState<_, _, _, _, _, _, _, _>) : azurerm.ServiceFabricCluster.ServiceFabricCluster =
            Unchecked.defaultof<azurerm.ServiceFabricCluster.ServiceFabricCluster>
