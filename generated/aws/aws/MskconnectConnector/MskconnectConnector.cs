using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector aws_mskconnect_connector}.</summary>
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnector), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnector", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorConfig\"}}]")]
    public class MskconnectConnector : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector aws_mskconnect_connector} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MskconnectConnector(Constructs.Construct scope, string id, aws.MskconnectConnector.IMskconnectConnectorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.MskconnectConnector.IMskconnectConnectorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnector(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnector(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MskconnectConnector resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MskconnectConnector to import.</param>
        /// <param name="importFromId">The id of the existing MskconnectConnector that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MskconnectConnector to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MskconnectConnector to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MskconnectConnector that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MskconnectConnector to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.MskconnectConnector.MskconnectConnector), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacity\"}}]")]
        public virtual void PutCapacity(aws.MskconnectConnector.IMskconnectConnectorCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaCluster\"}}]")]
        public virtual void PutKafkaCluster(aws.MskconnectConnector.IMskconnectConnectorKafkaCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorKafkaCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaClusterClientAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterClientAuthentication\"}}]")]
        public virtual void PutKafkaClusterClientAuthentication(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterClientAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterClientAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaClusterEncryptionInTransit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransit\"}}]")]
        public virtual void PutKafkaClusterEncryptionInTransit(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterEncryptionInTransit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterEncryptionInTransit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogDelivery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDelivery\"}}]")]
        public virtual void PutLogDelivery(aws.MskconnectConnector.IMskconnectConnectorLogDelivery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorLogDelivery)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorPlugin\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPlugin(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.MskconnectConnector.IMskconnectConnectorPlugin[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskconnectConnector.IMskconnectConnectorPlugin).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MskconnectConnector.IMskconnectConnectorPlugin).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.MskconnectConnector.IMskconnectConnectorTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorWorkerConfiguration\"}}]")]
        public virtual void PutWorkerConfiguration(aws.MskconnectConnector.IMskconnectConnectorWorkerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorWorkerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogDelivery")]
        public virtual void ResetLogDelivery()
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

        [JsiiMethod(name: "resetWorkerConfiguration")]
        public virtual void ResetWorkerConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.MskconnectConnector.MskconnectConnector))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorCapacityOutputReference Capacity
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorCapacityOutputReference>()!;
        }

        [JsiiProperty(name: "kafkaCluster", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorKafkaClusterOutputReference KafkaCluster
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorKafkaClusterOutputReference>()!;
        }

        [JsiiProperty(name: "kafkaClusterClientAuthentication", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterClientAuthenticationOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorKafkaClusterClientAuthenticationOutputReference KafkaClusterClientAuthentication
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorKafkaClusterClientAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "kafkaClusterEncryptionInTransit", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransitOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransitOutputReference KafkaClusterEncryptionInTransit
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransitOutputReference>()!;
        }

        [JsiiProperty(name: "logDelivery", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorLogDeliveryOutputReference LogDelivery
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorLogDeliveryOutputReference>()!;
        }

        [JsiiProperty(name: "plugin", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorPluginList\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorPluginList Plugin
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorPluginList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorTimeoutsOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workerConfiguration", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorWorkerConfigurationOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorWorkerConfigurationOutputReference WorkerConfiguration
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorWorkerConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacity\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacity? CapacityInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConnectorConfigurationInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "kafkaClusterClientAuthenticationInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaClusterClientAuthentication? KafkaClusterClientAuthenticationInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaClusterClientAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaClusterEncryptionInTransitInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransit\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaClusterEncryptionInTransit? KafkaClusterEncryptionInTransitInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaClusterEncryptionInTransit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaClusterInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaCluster\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaCluster? KafkaClusterInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaconnectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KafkaconnectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDeliveryInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDelivery\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDelivery? LogDeliveryInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDelivery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorPlugin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PluginInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceExecutionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceExecutionRoleArnInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerConfigurationInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorWorkerConfiguration\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorWorkerConfiguration? WorkerConfigurationInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorWorkerConfiguration?>();
        }

        [JsiiProperty(name: "connectorConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConnectorConfiguration
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "kafkaconnectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaconnectVersion
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

        [JsiiProperty(name: "serviceExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceExecutionRoleArn
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
