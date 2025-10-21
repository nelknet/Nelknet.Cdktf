using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster aws_msk_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskCluster), fullyQualifiedName: "aws.mskCluster.MskCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterConfig\"}}]")]
    public class MskCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster aws_msk_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MskCluster(Constructs.Construct scope, string id, aws.MskCluster.IMskClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.MskCluster.IMskClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MskCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MskCluster to import.</param>
        /// <param name="importFromId">The id of the existing MskCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MskCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MskCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MskCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MskCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.MskCluster.MskCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBrokerNodeGroupInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfo\"}}]")]
        public virtual void PutBrokerNodeGroupInfo(aws.MskCluster.IMskClusterBrokerNodeGroupInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterBrokerNodeGroupInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterClientAuthentication\"}}]")]
        public virtual void PutClientAuthentication(aws.MskCluster.IMskClusterClientAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterClientAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfigurationInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterConfigurationInfo\"}}]")]
        public virtual void PutConfigurationInfo(aws.MskCluster.IMskClusterConfigurationInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterConfigurationInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfo\"}}]")]
        public virtual void PutEncryptionInfo(aws.MskCluster.IMskClusterEncryptionInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterEncryptionInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoggingInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfo\"}}]")]
        public virtual void PutLoggingInfo(aws.MskCluster.IMskClusterLoggingInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterLoggingInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenMonitoring", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoring\"}}]")]
        public virtual void PutOpenMonitoring(aws.MskCluster.IMskClusterOpenMonitoring @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterOpenMonitoring)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.MskCluster.IMskClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientAuthentication")]
        public virtual void ResetClientAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationInfo")]
        public virtual void ResetConfigurationInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionInfo")]
        public virtual void ResetEncryptionInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnhancedMonitoring")]
        public virtual void ResetEnhancedMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingInfo")]
        public virtual void ResetLoggingInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenMonitoring")]
        public virtual void ResetOpenMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageMode")]
        public virtual void ResetStorageMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.MskCluster.MskCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokers
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersPublicSaslIam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersPublicSaslIam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersPublicSaslScram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersPublicSaslScram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersPublicTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersPublicTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersSaslIam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersSaslIam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersSaslScram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersSaslScram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersVpcConnectivitySaslIam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersVpcConnectivitySaslIam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersVpcConnectivitySaslScram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersVpcConnectivitySaslScram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersVpcConnectivityTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersVpcConnectivityTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterBrokerNodeGroupInfoOutputReference BrokerNodeGroupInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterBrokerNodeGroupInfoOutputReference>()!;
        }

        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterClientAuthenticationOutputReference ClientAuthentication
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterClientAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "clusterUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterConfigurationInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterConfigurationInfoOutputReference ConfigurationInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterConfigurationInfoOutputReference>()!;
        }

        [JsiiProperty(name: "currentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterEncryptionInfoOutputReference EncryptionInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterEncryptionInfoOutputReference>()!;
        }

        [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterLoggingInfoOutputReference LoggingInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterLoggingInfoOutputReference>()!;
        }

        [JsiiProperty(name: "openMonitoring", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterOpenMonitoringOutputReference OpenMonitoring
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterOpenMonitoringOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterTimeoutsOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "zookeeperConnectString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZookeeperConnectString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zookeeperConnectStringTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZookeeperConnectStringTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerNodeGroupInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfo? BrokerNodeGroupInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAuthenticationInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterClientAuthentication? ClientAuthenticationInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterClientAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterConfigurationInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterConfigurationInfo? ConfigurationInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterConfigurationInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterEncryptionInfo? EncryptionInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterEncryptionInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnhancedMonitoringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KafkaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterLoggingInfo? LoggingInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfBrokerNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfBrokerNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openMonitoringInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoring\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterOpenMonitoring? OpenMonitoringInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoring?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.mskCluster.MskClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnhancedMonitoring
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBrokerNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageMode
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
