using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermElasticCloudElasticsearch
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch azurerm_elastic_cloud_elasticsearch}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch), fullyQualifiedName: "azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchConfig\"}}]")]
    public class DataAzurermElasticCloudElasticsearch : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch azurerm_elastic_cloud_elasticsearch} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermElasticCloudElasticsearch(Constructs.Construct scope, string id, azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermElasticCloudElasticsearch(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermElasticCloudElasticsearch(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermElasticCloudElasticsearch resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermElasticCloudElasticsearch to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermElasticCloudElasticsearch that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermElasticCloudElasticsearch to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermElasticCloudElasticsearch to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermElasticCloudElasticsearch that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermElasticCloudElasticsearch to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchLogs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchLogs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchLogs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchLogs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch))!;

        [JsiiProperty(name: "elasticCloudDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticCloudDeploymentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticCloudEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticCloudEmailAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticCloudSsoDefaultUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticCloudSsoDefaultUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticCloudUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticCloudUserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticsearchServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaSsoUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaSsoUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchLogsList\"}")]
        public virtual azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchLogsList Logs
        {
            get => GetInstanceProperty<azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchLogsList>()!;
        }

        [JsiiProperty(name: "monitoringEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MonitoringEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
