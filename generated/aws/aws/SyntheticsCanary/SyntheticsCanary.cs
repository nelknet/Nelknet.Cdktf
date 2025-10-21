using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary aws_synthetics_canary}.</summary>
    [JsiiClass(nativeType: typeof(aws.SyntheticsCanary.SyntheticsCanary), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanary", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryConfig\"}}]")]
    public class SyntheticsCanary : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary aws_synthetics_canary} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SyntheticsCanary(Constructs.Construct scope, string id, aws.SyntheticsCanary.ISyntheticsCanaryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SyntheticsCanary.ISyntheticsCanaryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanary(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanary(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SyntheticsCanary resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SyntheticsCanary to import.</param>
        /// <param name="importFromId">The id of the existing SyntheticsCanary that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SyntheticsCanary to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SyntheticsCanary to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SyntheticsCanary that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SyntheticsCanary to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SyntheticsCanary.SyntheticsCanary), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putArtifactConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfig\"}}]")]
        public virtual void PutArtifactConfig(aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryRunConfig\"}}]")]
        public virtual void PutRunConfig(aws.SyntheticsCanary.ISyntheticsCanaryRunConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SyntheticsCanary.ISyntheticsCanaryRunConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanarySchedule\"}}]")]
        public virtual void PutSchedule(aws.SyntheticsCanary.ISyntheticsCanarySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SyntheticsCanary.ISyntheticsCanarySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.SyntheticsCanary.ISyntheticsCanaryVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SyntheticsCanary.ISyntheticsCanaryVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArtifactConfig")]
        public virtual void ResetArtifactConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteLambda")]
        public virtual void ResetDeleteLambda()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailureRetentionPeriod")]
        public virtual void ResetFailureRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunConfig")]
        public virtual void ResetRunConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Bucket")]
        public virtual void ResetS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Key")]
        public virtual void ResetS3Key()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Version")]
        public virtual void ResetS3Version()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartCanary")]
        public virtual void ResetStartCanary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessRetentionPeriod")]
        public virtual void ResetSuccessRetentionPeriod()
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

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZipFile")]
        public virtual void ResetZipFile()
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
        = GetStaticProperty<string>(typeof(aws.SyntheticsCanary.SyntheticsCanary))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactConfig", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigOutputReference\"}")]
        public virtual aws.SyntheticsCanary.SyntheticsCanaryArtifactConfigOutputReference ArtifactConfig
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.SyntheticsCanaryArtifactConfigOutputReference>()!;
        }

        [JsiiProperty(name: "engineArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runConfig", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryRunConfigOutputReference\"}")]
        public virtual aws.SyntheticsCanary.SyntheticsCanaryRunConfigOutputReference RunConfig
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.SyntheticsCanaryRunConfigOutputReference>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryScheduleOutputReference\"}")]
        public virtual aws.SyntheticsCanary.SyntheticsCanaryScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.SyntheticsCanaryScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "sourceLocationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceLocationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeline", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryTimelineList\"}")]
        public virtual aws.SyntheticsCanary.SyntheticsCanaryTimelineList Timeline
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.SyntheticsCanaryTimelineList>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryVpcConfigOutputReference\"}")]
        public virtual aws.SyntheticsCanary.SyntheticsCanaryVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.SyntheticsCanaryVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactConfigInput", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfig\"}", isOptional: true)]
        public virtual aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig? ArtifactConfigInput
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactS3LocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArtifactS3LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteLambdaInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteLambdaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureRetentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailureRetentionPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HandlerInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runConfigInput", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryRunConfig\"}", isOptional: true)]
        public virtual aws.SyntheticsCanary.ISyntheticsCanaryRunConfig? RunConfigInput
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanaryRunConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3VersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanarySchedule\"}", isOptional: true)]
        public virtual aws.SyntheticsCanary.ISyntheticsCanarySchedule? ScheduleInput
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanarySchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startCanaryInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StartCanaryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successRetentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SuccessRetentionPeriodInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryVpcConfig\"}", isOptional: true)]
        public virtual aws.SyntheticsCanary.ISyntheticsCanaryVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanaryVpcConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "artifactS3Location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactS3Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteLambda", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeleteLambda
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

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failureRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startCanary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StartCanary
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

        [JsiiProperty(name: "successRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuccessRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "zipFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
