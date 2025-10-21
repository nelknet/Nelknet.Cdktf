using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightKafkaClusterConfig), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterConfig")]
    public interface IHdinsightKafkaClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#cluster_version HdinsightKafkaCluster#cluster_version}.</summary>
        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterVersion
        {
            get;
        }

        /// <summary>component_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#component_version HdinsightKafkaCluster#component_version}
        /// </remarks>
        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion ComponentVersion
        {
            get;
        }

        /// <summary>gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#gateway HdinsightKafkaCluster#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterGateway\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway Gateway
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#location HdinsightKafkaCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#name HdinsightKafkaCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#resource_group_name HdinsightKafkaCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#roles HdinsightKafkaCluster#roles}
        /// </remarks>
        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles Roles
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tier HdinsightKafkaCluster#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        string Tier
        {
            get;
        }

        /// <summary>compute_isolation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#compute_isolation HdinsightKafkaCluster#compute_isolation}
        /// </remarks>
        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation? ComputeIsolation
        {
            get
            {
                return null;
            }
        }

        /// <summary>disk_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#disk_encryption HdinsightKafkaCluster#disk_encryption}
        /// </remarks>
        [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DiskEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#encryption_in_transit_enabled HdinsightKafkaCluster#encryption_in_transit_enabled}.</summary>
        [JsiiProperty(name: "encryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptionInTransitEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#extension HdinsightKafkaCluster#extension}
        /// </remarks>
        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterExtension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#id HdinsightKafkaCluster#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>metastores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#metastores HdinsightKafkaCluster#metastores}
        /// </remarks>
        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores? Metastores
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#monitor HdinsightKafkaCluster#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMonitor\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor? Monitor
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#network HdinsightKafkaCluster#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_link_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#private_link_configuration HdinsightKafkaCluster#private_link_configuration}
        /// </remarks>
        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration? PrivateLinkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>rest_proxy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#rest_proxy HdinsightKafkaCluster#rest_proxy}
        /// </remarks>
        [JsiiProperty(name: "restProxy", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy? RestProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_profile HdinsightKafkaCluster#security_profile}
        /// </remarks>
        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile? SecurityProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#storage_account HdinsightKafkaCluster#storage_account}
        /// </remarks>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account_gen2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#storage_account_gen2 HdinsightKafkaCluster#storage_account_gen2}
        /// </remarks>
        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2? StorageAccountGen2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tags HdinsightKafkaCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#timeouts HdinsightKafkaCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tls_min_version HdinsightKafkaCluster#tls_min_version}.</summary>
        [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsMinVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightKafkaClusterConfig), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#cluster_version HdinsightKafkaCluster#cluster_version}.</summary>
            [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>component_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#component_version HdinsightKafkaCluster#component_version}
            /// </remarks>
            [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion ComponentVersion
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion>()!;
            }

            /// <summary>gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#gateway HdinsightKafkaCluster#gateway}
            /// </remarks>
            [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterGateway\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway Gateway
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#location HdinsightKafkaCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#name HdinsightKafkaCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#resource_group_name HdinsightKafkaCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>roles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#roles HdinsightKafkaCluster#roles}
            /// </remarks>
            [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles Roles
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tier HdinsightKafkaCluster#tier}.</summary>
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
            public string Tier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>compute_isolation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#compute_isolation HdinsightKafkaCluster#compute_isolation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolation\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation? ComputeIsolation
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation?>();
            }

            /// <summary>disk_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#disk_encryption HdinsightKafkaCluster#disk_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DiskEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#encryption_in_transit_enabled HdinsightKafkaCluster#encryption_in_transit_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EncryptionInTransitEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#extension HdinsightKafkaCluster#extension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterExtension\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension? Extension
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#id HdinsightKafkaCluster#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metastores block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#metastores HdinsightKafkaCluster#metastores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores? Metastores
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores?>();
            }

            /// <summary>monitor block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#monitor HdinsightKafkaCluster#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMonitor\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor? Monitor
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor?>();
            }

            /// <summary>network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#network HdinsightKafkaCluster#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterNetwork\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork? Network
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork?>();
            }

            /// <summary>private_link_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#private_link_configuration HdinsightKafkaCluster#private_link_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration? PrivateLinkConfiguration
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration?>();
            }

            /// <summary>rest_proxy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#rest_proxy HdinsightKafkaCluster#rest_proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restProxy", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxy\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy? RestProxy
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy?>();
            }

            /// <summary>security_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_profile HdinsightKafkaCluster#security_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfile\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile? SecurityProfile
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile?>();
            }

            /// <summary>storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#storage_account HdinsightKafkaCluster#storage_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_account_gen2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#storage_account_gen2 HdinsightKafkaCluster#storage_account_gen2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2? StorageAccountGen2
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tags HdinsightKafkaCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#timeouts HdinsightKafkaCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterTimeouts\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tls_min_version HdinsightKafkaCluster#tls_min_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsMinVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
