using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketVersioning
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning aws_s3_bucket_versioning}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3BucketVersioning.S3BucketVersioningA), fullyQualifiedName: "aws.s3BucketVersioning.S3BucketVersioningA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3BucketVersioning.S3BucketVersioningAConfig\"}}]")]
    public class S3BucketVersioningA : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning aws_s3_bucket_versioning} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketVersioningA(Constructs.Construct scope, string id, aws.S3BucketVersioning.IS3BucketVersioningAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.S3BucketVersioning.IS3BucketVersioningAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketVersioningA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketVersioningA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a S3BucketVersioningA resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the S3BucketVersioningA to import.</param>
        /// <param name="importFromId">The id of the existing S3BucketVersioningA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the S3BucketVersioningA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the S3BucketVersioningA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing S3BucketVersioningA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the S3BucketVersioningA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.S3BucketVersioning.S3BucketVersioningA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putVersioningConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketVersioning.S3BucketVersioningVersioningConfiguration\"}}]")]
        public virtual void PutVersioningConfiguration(aws.S3BucketVersioning.IS3BucketVersioningVersioningConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketVersioning.IS3BucketVersioningVersioningConfiguration)}, new object[]{@value});
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

        [JsiiMethod(name: "resetMfa")]
        public virtual void ResetMfa()
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
        = GetStaticProperty<string>(typeof(aws.S3BucketVersioning.S3BucketVersioningA))!;

        [JsiiProperty(name: "versioningConfiguration", typeJson: "{\"fqn\":\"aws.s3BucketVersioning.S3BucketVersioningVersioningConfigurationOutputReference\"}")]
        public virtual aws.S3BucketVersioning.S3BucketVersioningVersioningConfigurationOutputReference VersioningConfiguration
        {
            get => GetInstanceProperty<aws.S3BucketVersioning.S3BucketVersioningVersioningConfigurationOutputReference>()!;
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
        [JsiiProperty(name: "mfaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MfaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versioningConfigurationInput", typeJson: "{\"fqn\":\"aws.s3BucketVersioning.S3BucketVersioningVersioningConfiguration\"}", isOptional: true)]
        public virtual aws.S3BucketVersioning.IS3BucketVersioningVersioningConfiguration? VersioningConfigurationInput
        {
            get => GetInstanceProperty<aws.S3BucketVersioning.IS3BucketVersioningVersioningConfiguration?>();
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

        [JsiiProperty(name: "mfa", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mfa
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
