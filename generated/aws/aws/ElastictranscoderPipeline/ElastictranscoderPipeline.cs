using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPipeline
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline aws_elastictranscoder_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPipeline.ElastictranscoderPipeline), fullyQualifiedName: "aws.elastictranscoderPipeline.ElastictranscoderPipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineConfig\"}}]")]
    public class ElastictranscoderPipeline : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline aws_elastictranscoder_pipeline} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElastictranscoderPipeline(Constructs.Construct scope, string id, aws.ElastictranscoderPipeline.IElastictranscoderPipelineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ElastictranscoderPipeline.IElastictranscoderPipelineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipeline(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElastictranscoderPipeline resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElastictranscoderPipeline to import.</param>
        /// <param name="importFromId">The id of the existing ElastictranscoderPipeline that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElastictranscoderPipeline to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElastictranscoderPipeline to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElastictranscoderPipeline that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElastictranscoderPipeline to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ElastictranscoderPipeline.ElastictranscoderPipeline), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putContentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineContentConfig\"}}]")]
        public virtual void PutContentConfig(aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContentConfigPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContentConfigPermissions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfigPermissions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfigPermissions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfigPermissions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineNotifications\"}}]")]
        public virtual void PutNotifications(aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThumbnailConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfig\"}}]")]
        public virtual void PutThumbnailConfig(aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThumbnailConfigPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThumbnailConfigPermissions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfigPermissions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfigPermissions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfigPermissions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsKmsKeyArn")]
        public virtual void ResetAwsKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentConfig")]
        public virtual void ResetContentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentConfigPermissions")]
        public virtual void ResetContentConfigPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotifications")]
        public virtual void ResetNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputBucket")]
        public virtual void ResetOutputBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailConfig")]
        public virtual void ResetThumbnailConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailConfigPermissions")]
        public virtual void ResetThumbnailConfigPermissions()
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
        = GetStaticProperty<string>(typeof(aws.ElastictranscoderPipeline.ElastictranscoderPipeline))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentConfig", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineContentConfigOutputReference\"}")]
        public virtual aws.ElastictranscoderPipeline.ElastictranscoderPipelineContentConfigOutputReference ContentConfig
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.ElastictranscoderPipelineContentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineContentConfigPermissionsList\"}")]
        public virtual aws.ElastictranscoderPipeline.ElastictranscoderPipelineContentConfigPermissionsList ContentConfigPermissions
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.ElastictranscoderPipelineContentConfigPermissionsList>()!;
        }

        [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineNotificationsOutputReference\"}")]
        public virtual aws.ElastictranscoderPipeline.ElastictranscoderPipelineNotificationsOutputReference Notifications
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.ElastictranscoderPipelineNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigOutputReference\"}")]
        public virtual aws.ElastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigOutputReference ThumbnailConfig
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigOutputReference>()!;
        }

        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigPermissionsList\"}")]
        public virtual aws.ElastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigPermissionsList ThumbnailConfigPermissions
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigPermissionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsKmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsKmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentConfigInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineContentConfig\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfig? ContentConfigInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.IElastictranscoderPipelineContentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentConfigPermissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContentConfigPermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationsInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications? NotificationsInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfig\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfig? ThumbnailConfigInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.IElastictranscoderPipelineThumbnailConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigPermissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThumbnailConfigPermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsKmsKeyArn
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

        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputBucket
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

        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputBucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
