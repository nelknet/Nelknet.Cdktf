using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver aws_appsync_resolver}.</summary>
    [JsiiClass(nativeType: typeof(aws.AppsyncResolver.AppsyncResolver), fullyQualifiedName: "aws.appsyncResolver.AppsyncResolver", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appsyncResolver.AppsyncResolverConfig\"}}]")]
    public class AppsyncResolver : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver aws_appsync_resolver} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppsyncResolver(Constructs.Construct scope, string id, aws.AppsyncResolver.IAppsyncResolverConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.AppsyncResolver.IAppsyncResolverConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncResolver(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncResolver(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AppsyncResolver resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AppsyncResolver to import.</param>
        /// <param name="importFromId">The id of the existing AppsyncResolver that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AppsyncResolver to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AppsyncResolver to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AppsyncResolver that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AppsyncResolver to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.AppsyncResolver.AppsyncResolver), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCachingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncResolver.AppsyncResolverCachingConfig\"}}]")]
        public virtual void PutCachingConfig(aws.AppsyncResolver.IAppsyncResolverCachingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncResolver.IAppsyncResolverCachingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipelineConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncResolver.AppsyncResolverPipelineConfig\"}}]")]
        public virtual void PutPipelineConfig(aws.AppsyncResolver.IAppsyncResolverPipelineConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncResolver.IAppsyncResolverPipelineConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncResolver.AppsyncResolverRuntime\"}}]")]
        public virtual void PutRuntime(aws.AppsyncResolver.IAppsyncResolverRuntime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncResolver.IAppsyncResolverRuntime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSyncConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncResolver.AppsyncResolverSyncConfig\"}}]")]
        public virtual void PutSyncConfig(aws.AppsyncResolver.IAppsyncResolverSyncConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncResolver.IAppsyncResolverSyncConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCachingConfig")]
        public virtual void ResetCachingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCode")]
        public virtual void ResetCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSource")]
        public virtual void ResetDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKind")]
        public virtual void ResetKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxBatchSize")]
        public virtual void ResetMaxBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineConfig")]
        public virtual void ResetPipelineConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestTemplate")]
        public virtual void ResetRequestTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseTemplate")]
        public virtual void ResetResponseTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntime")]
        public virtual void ResetRuntime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSyncConfig")]
        public virtual void ResetSyncConfig()
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
        = GetStaticProperty<string>(typeof(aws.AppsyncResolver.AppsyncResolver))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cachingConfig", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverCachingConfigOutputReference\"}")]
        public virtual aws.AppsyncResolver.AppsyncResolverCachingConfigOutputReference CachingConfig
        {
            get => GetInstanceProperty<aws.AppsyncResolver.AppsyncResolverCachingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverPipelineConfigOutputReference\"}")]
        public virtual aws.AppsyncResolver.AppsyncResolverPipelineConfigOutputReference PipelineConfig
        {
            get => GetInstanceProperty<aws.AppsyncResolver.AppsyncResolverPipelineConfigOutputReference>()!;
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverRuntimeOutputReference\"}")]
        public virtual aws.AppsyncResolver.AppsyncResolverRuntimeOutputReference Runtime
        {
            get => GetInstanceProperty<aws.AppsyncResolver.AppsyncResolverRuntimeOutputReference>()!;
        }

        [JsiiProperty(name: "syncConfig", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverSyncConfigOutputReference\"}")]
        public virtual aws.AppsyncResolver.AppsyncResolverSyncConfigOutputReference SyncConfig
        {
            get => GetInstanceProperty<aws.AppsyncResolver.AppsyncResolverSyncConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingConfigInput", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverCachingConfig\"}", isOptional: true)]
        public virtual aws.AppsyncResolver.IAppsyncResolverCachingConfig? CachingConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncResolver.IAppsyncResolverCachingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldInput
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
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxBatchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxBatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineConfigInput", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverPipelineConfig\"}", isOptional: true)]
        public virtual aws.AppsyncResolver.IAppsyncResolverPipelineConfig? PipelineConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncResolver.IAppsyncResolverPipelineConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeInput", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverRuntime\"}", isOptional: true)]
        public virtual aws.AppsyncResolver.IAppsyncResolverRuntime? RuntimeInput
        {
            get => GetInstanceProperty<aws.AppsyncResolver.IAppsyncResolverRuntime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syncConfigInput", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverSyncConfig\"}", isOptional: true)]
        public virtual aws.AppsyncResolver.IAppsyncResolverSyncConfig? SyncConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncResolver.IAppsyncResolverSyncConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Field
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

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxBatchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
