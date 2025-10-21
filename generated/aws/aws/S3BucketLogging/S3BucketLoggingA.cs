using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging aws_s3_bucket_logging}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3BucketLogging.S3BucketLoggingA), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingAConfig\"}}]")]
    public class S3BucketLoggingA : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging aws_s3_bucket_logging} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketLoggingA(Constructs.Construct scope, string id, aws.S3BucketLogging.IS3BucketLoggingAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.S3BucketLogging.IS3BucketLoggingAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketLoggingA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketLoggingA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a S3BucketLoggingA resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the S3BucketLoggingA to import.</param>
        /// <param name="importFromId">The id of the existing S3BucketLoggingA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the S3BucketLoggingA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the S3BucketLoggingA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing S3BucketLoggingA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the S3BucketLoggingA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.S3BucketLogging.S3BucketLoggingA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTargetGrant", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrant\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTargetGrant(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3BucketLogging.IS3BucketLoggingTargetGrant[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketLogging.IS3BucketLoggingTargetGrant).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketLogging.IS3BucketLoggingTargetGrant).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetObjectKeyFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormat\"}}]")]
        public virtual void PutTargetObjectKeyFormat(aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExpectedBucketOwner")]
        public virtual void ResetExpectedBucketOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGrant")]
        public virtual void ResetTargetGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetObjectKeyFormat")]
        public virtual void ResetTargetObjectKeyFormat()
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
        = GetStaticProperty<string>(typeof(aws.S3BucketLogging.S3BucketLoggingA))!;

        [JsiiProperty(name: "targetGrant", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantList\"}")]
        public virtual aws.S3BucketLogging.S3BucketLoggingTargetGrantList TargetGrant
        {
            get => GetInstanceProperty<aws.S3BucketLogging.S3BucketLoggingTargetGrantList>()!;
        }

        [JsiiProperty(name: "targetObjectKeyFormat", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatOutputReference\"}")]
        public virtual aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatOutputReference TargetObjectKeyFormat
        {
            get => GetInstanceProperty<aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expectedBucketOwnerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpectedBucketOwnerInput
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
        [JsiiProperty(name: "targetBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGrantInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetGrantInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetObjectKeyFormatInput", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormat\"}", isOptional: true)]
        public virtual aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat? TargetObjectKeyFormatInput
        {
            get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expectedBucketOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedBucketOwner
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

        [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetBucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
