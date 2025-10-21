using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster azurerm_kubernetes_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesCluster), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfig\"}}]")]
    public class KubernetesCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster azurerm_kubernetes_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesCluster(Constructs.Construct scope, string id, azurerm.KubernetesCluster.IKubernetesClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.KubernetesCluster.IKubernetesClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KubernetesCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KubernetesCluster to import.</param>
        /// <param name="importFromId">The id of the existing KubernetesCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KubernetesCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KubernetesCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KubernetesCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KubernetesCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.KubernetesCluster.KubernetesCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAciConnectorLinux", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux\"}}]")]
        public virtual void PutAciConnectorLinux(azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApiServerAccessProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfile\"}}]")]
        public virtual void PutApiServerAccessProfile(azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoScalerProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile\"}}]")]
        public virtual void PutAutoScalerProfile(azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureActiveDirectoryRoleBasedAccessControl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControl\"}}]")]
        public virtual void PutAzureActiveDirectoryRoleBasedAccessControl(azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfidentialComputing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing\"}}]")]
        public virtual void PutConfidentialComputing(azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultNodePool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool\"}}]")]
        public virtual void PutDefaultNodePool(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpProxyConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig\"}}]")]
        public virtual void PutHttpProxyConfig(azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.KubernetesCluster.IKubernetesClusterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIngressApplicationGateway", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGateway\"}}]")]
        public virtual void PutIngressApplicationGateway(azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyManagementService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyManagementService\"}}]")]
        public virtual void PutKeyManagementService(azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyVaultSecretsProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider\"}}]")]
        public virtual void PutKeyVaultSecretsProvider(azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKubeletIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeletIdentity\"}}]")]
        public virtual void PutKubeletIdentity(azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinuxProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfile\"}}]")]
        public virtual void PutLinuxProfile(azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindowAutoUpgrade", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgrade\"}}]")]
        public virtual void PutMaintenanceWindowAutoUpgrade(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindowNodeOs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs\"}}]")]
        public virtual void PutMaintenanceWindowNodeOs(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoftDefender", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMicrosoftDefender\"}}]")]
        public virtual void PutMicrosoftDefender(azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitorMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics\"}}]")]
        public virtual void PutMonitorMetrics(azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfile\"}}]")]
        public virtual void PutNetworkProfile(azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOmsAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterOmsAgent\"}}]")]
        public virtual void PutOmsAgent(azurerm.KubernetesCluster.IKubernetesClusterOmsAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterOmsAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceMeshProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile\"}}]")]
        public virtual void PutServiceMeshProfile(azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServicePrincipal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServicePrincipal\"}}]")]
        public virtual void PutServicePrincipal(azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterStorageProfile\"}}]")]
        public virtual void PutStorageProfile(azurerm.KubernetesCluster.IKubernetesClusterStorageProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterStorageProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.KubernetesCluster.IKubernetesClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebAppRouting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWebAppRouting\"}}]")]
        public virtual void PutWebAppRouting(azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindowsProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfile\"}}]")]
        public virtual void PutWindowsProfile(azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkloadAutoscalerProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile\"}}]")]
        public virtual void PutWorkloadAutoscalerProfile(azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAciConnectorLinux")]
        public virtual void ResetAciConnectorLinux()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiServerAccessProfile")]
        public virtual void ResetApiServerAccessProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticUpgradeChannel")]
        public virtual void ResetAutomaticUpgradeChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoScalerProfile")]
        public virtual void ResetAutoScalerProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureActiveDirectoryRoleBasedAccessControl")]
        public virtual void ResetAzureActiveDirectoryRoleBasedAccessControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzurePolicyEnabled")]
        public virtual void ResetAzurePolicyEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfidentialComputing")]
        public virtual void ResetConfidentialComputing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostAnalysisEnabled")]
        public virtual void ResetCostAnalysisEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskEncryptionSetId")]
        public virtual void ResetDiskEncryptionSetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsPrefix")]
        public virtual void ResetDnsPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsPrefixPrivateCluster")]
        public virtual void ResetDnsPrefixPrivateCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgeZone")]
        public virtual void ResetEdgeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpApplicationRoutingEnabled")]
        public virtual void ResetHttpApplicationRoutingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpProxyConfig")]
        public virtual void ResetHttpProxyConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageCleanerEnabled")]
        public virtual void ResetImageCleanerEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageCleanerIntervalHours")]
        public virtual void ResetImageCleanerIntervalHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIngressApplicationGateway")]
        public virtual void ResetIngressApplicationGateway()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyManagementService")]
        public virtual void ResetKeyManagementService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultSecretsProvider")]
        public virtual void ResetKeyVaultSecretsProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubeletIdentity")]
        public virtual void ResetKubeletIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubernetesVersion")]
        public virtual void ResetKubernetesVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinuxProfile")]
        public virtual void ResetLinuxProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalAccountDisabled")]
        public virtual void ResetLocalAccountDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowAutoUpgrade")]
        public virtual void ResetMaintenanceWindowAutoUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowNodeOs")]
        public virtual void ResetMaintenanceWindowNodeOs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoftDefender")]
        public virtual void ResetMicrosoftDefender()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitorMetrics")]
        public virtual void ResetMonitorMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkProfile")]
        public virtual void ResetNetworkProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeOsUpgradeChannel")]
        public virtual void ResetNodeOsUpgradeChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeResourceGroup")]
        public virtual void ResetNodeResourceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcIssuerEnabled")]
        public virtual void ResetOidcIssuerEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOmsAgent")]
        public virtual void ResetOmsAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenServiceMeshEnabled")]
        public virtual void ResetOpenServiceMeshEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateClusterEnabled")]
        public virtual void ResetPrivateClusterEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateClusterPublicFqdnEnabled")]
        public virtual void ResetPrivateClusterPublicFqdnEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDnsZoneId")]
        public virtual void ResetPrivateDnsZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleBasedAccessControlEnabled")]
        public virtual void ResetRoleBasedAccessControlEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommandEnabled")]
        public virtual void ResetRunCommandEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceMeshProfile")]
        public virtual void ResetServiceMeshProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServicePrincipal")]
        public virtual void ResetServicePrincipal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkuTier")]
        public virtual void ResetSkuTier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageProfile")]
        public virtual void ResetStorageProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportPlan")]
        public virtual void ResetSupportPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebAppRouting")]
        public virtual void ResetWebAppRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindowsProfile")]
        public virtual void ResetWindowsProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkloadAutoscalerProfile")]
        public virtual void ResetWorkloadAutoscalerProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkloadIdentityEnabled")]
        public virtual void ResetWorkloadIdentityEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.KubernetesCluster.KubernetesCluster))!;

        [JsiiProperty(name: "aciConnectorLinux", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinuxOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterAciConnectorLinuxOutputReference AciConnectorLinux
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterAciConnectorLinuxOutputReference>()!;
        }

        [JsiiProperty(name: "apiServerAccessProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterApiServerAccessProfileOutputReference ApiServerAccessProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterApiServerAccessProfileOutputReference>()!;
        }

        [JsiiProperty(name: "autoScalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterAutoScalerProfileOutputReference AutoScalerProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterAutoScalerProfileOutputReference>()!;
        }

        [JsiiProperty(name: "azureActiveDirectoryRoleBasedAccessControl", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControlOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControlOutputReference AzureActiveDirectoryRoleBasedAccessControl
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControlOutputReference>()!;
        }

        [JsiiProperty(name: "confidentialComputing", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfidentialComputingOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterConfidentialComputingOutputReference ConfidentialComputing
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterConfidentialComputingOutputReference>()!;
        }

        [JsiiProperty(name: "currentKubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentKubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultNodePool", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolOutputReference DefaultNodePool
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolOutputReference>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpApplicationRoutingZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpApplicationRoutingZoneName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpProxyConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfigOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterHttpProxyConfigOutputReference HttpProxyConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterHttpProxyConfigOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIdentityOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "ingressApplicationGateway", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGatewayOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterIngressApplicationGatewayOutputReference IngressApplicationGateway
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterIngressApplicationGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "keyManagementService", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyManagementServiceOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterKeyManagementServiceOutputReference KeyManagementService
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterKeyManagementServiceOutputReference>()!;
        }

        [JsiiProperty(name: "keyVaultSecretsProvider", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProviderOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterKeyVaultSecretsProviderOutputReference KeyVaultSecretsProvider
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterKeyVaultSecretsProviderOutputReference>()!;
        }

        [JsiiProperty(name: "kubeAdminConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeAdminConfigList\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterKubeAdminConfigList KubeAdminConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterKubeAdminConfigList>()!;
        }

        [JsiiProperty(name: "kubeAdminConfigRaw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeAdminConfigRaw
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeConfigList\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterKubeConfigList KubeConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterKubeConfigList>()!;
        }

        [JsiiProperty(name: "kubeConfigRaw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeConfigRaw
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeletIdentity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeletIdentityOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterKubeletIdentityOutputReference KubeletIdentity
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterKubeletIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "linuxProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterLinuxProfileOutputReference LinuxProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterLinuxProfileOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindowAutoUpgrade", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgradeOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgradeOutputReference MaintenanceWindowAutoUpgrade
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgradeOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindowNodeOs", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOsOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowNodeOsOutputReference MaintenanceWindowNodeOs
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowNodeOsOutputReference>()!;
        }

        [JsiiProperty(name: "microsoftDefender", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMicrosoftDefenderOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMicrosoftDefenderOutputReference MicrosoftDefender
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMicrosoftDefenderOutputReference>()!;
        }

        [JsiiProperty(name: "monitorMetrics", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMonitorMetricsOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMonitorMetricsOutputReference MonitorMetrics
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMonitorMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterNetworkProfileOutputReference NetworkProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterNetworkProfileOutputReference>()!;
        }

        [JsiiProperty(name: "nodeResourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oidcIssuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OidcIssuerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "omsAgent", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterOmsAgentOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterOmsAgentOutputReference OmsAgent
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterOmsAgentOutputReference>()!;
        }

        [JsiiProperty(name: "portalFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceMeshProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterServiceMeshProfileOutputReference ServiceMeshProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterServiceMeshProfileOutputReference>()!;
        }

        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServicePrincipalOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterServicePrincipalOutputReference ServicePrincipal
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterServicePrincipalOutputReference>()!;
        }

        [JsiiProperty(name: "storageProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterStorageProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterStorageProfileOutputReference StorageProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterStorageProfileOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webAppRouting", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWebAppRoutingOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterWebAppRoutingOutputReference WebAppRouting
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterWebAppRoutingOutputReference>()!;
        }

        [JsiiProperty(name: "windowsProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterWindowsProfileOutputReference WindowsProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterWindowsProfileOutputReference>()!;
        }

        [JsiiProperty(name: "workloadAutoscalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterWorkloadAutoscalerProfileOutputReference WorkloadAutoscalerProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterWorkloadAutoscalerProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aciConnectorLinuxInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux? AciConnectorLinuxInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiServerAccessProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile? ApiServerAccessProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticUpgradeChannelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomaticUpgradeChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalerProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile? AutoScalerProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectoryRoleBasedAccessControlInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControl\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl? AzureActiveDirectoryRoleBasedAccessControlInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azurePolicyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AzurePolicyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confidentialComputingInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing? ConfidentialComputingInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costAnalysisEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CostAnalysisEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultNodePoolInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool? DefaultNodePoolInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiskEncryptionSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsPrefixPrivateClusterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsPrefixPrivateClusterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpApplicationRoutingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpApplicationRoutingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpProxyConfigInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig? HttpProxyConfigInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIdentity\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageCleanerEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ImageCleanerEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageCleanerIntervalHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ImageCleanerIntervalHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressApplicationGatewayInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGateway\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway? IngressApplicationGatewayInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyManagementServiceInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyManagementService\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService? KeyManagementServiceInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultSecretsProviderInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider? KeyVaultSecretsProviderInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubeletIdentityInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeletIdentity\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity? KubeletIdentityInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KubernetesVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linuxProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile? LinuxProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localAccountDisabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LocalAccountDisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowAutoUpgradeInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgrade\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade? MaintenanceWindowAutoUpgradeInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowNodeOsInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs? MaintenanceWindowNodeOsInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftDefenderInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMicrosoftDefender\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender? MicrosoftDefenderInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorMetricsInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics? MonitorMetricsInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile? NetworkProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeOsUpgradeChannelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeOsUpgradeChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeResourceGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeResourceGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcIssuerEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OidcIssuerEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "omsAgentInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterOmsAgent\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterOmsAgent? OmsAgentInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterOmsAgent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openServiceMeshEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OpenServiceMeshEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateClusterEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PrivateClusterEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateClusterPublicFqdnEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PrivateClusterPublicFqdnEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateDnsZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleBasedAccessControlEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RoleBasedAccessControlEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RunCommandEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceMeshProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile? ServiceMeshProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServicePrincipal\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal? ServicePrincipalInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterStorageProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterStorageProfile? StorageProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterStorageProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportPlanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SupportPlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAppRoutingInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWebAppRouting\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting? WebAppRoutingInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile? WindowsProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadAutoscalerProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile? WorkloadAutoscalerProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadIdentityEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WorkloadIdentityEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomaticUpgradeChannel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azurePolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AzurePolicyEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "costAnalysisEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CostAnalysisEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskEncryptionSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsPrefixPrivateCluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsPrefixPrivateCluster
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpApplicationRoutingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HttpApplicationRoutingEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageCleanerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ImageCleanerEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "imageCleanerIntervalHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImageCleanerIntervalHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localAccountDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LocalAccountDisabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeOsUpgradeChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeOsUpgradeChannel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oidcIssuerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object OidcIssuerEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "openServiceMeshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object OpenServiceMeshEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "privateClusterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PrivateClusterEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "privateClusterPublicFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PrivateClusterPublicFqdnEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDnsZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleBasedAccessControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RoleBasedAccessControlEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "runCommandEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RunCommandEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportPlan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportPlan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workloadIdentityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WorkloadIdentityEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
