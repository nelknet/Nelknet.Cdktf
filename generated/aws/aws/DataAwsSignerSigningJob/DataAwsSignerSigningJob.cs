using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSignerSigningJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_job aws_signer_signing_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob), fullyQualifiedName: "aws.dataAwsSignerSigningJob.DataAwsSignerSigningJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsSignerSigningJob.DataAwsSignerSigningJobConfig\"}}]")]
    public class DataAwsSignerSigningJob : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_job aws_signer_signing_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSignerSigningJob(Constructs.Construct scope, string id, aws.DataAwsSignerSigningJob.IDataAwsSignerSigningJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsSignerSigningJob.IDataAwsSignerSigningJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSignerSigningJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSignerSigningJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsSignerSigningJob resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsSignerSigningJob to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsSignerSigningJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsSignerSigningJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsSignerSigningJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsSignerSigningJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsSignerSigningJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob))!;

        [JsiiProperty(name: "completedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompletedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobInvoker", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobInvoker
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationRecord", typeJson: "{\"fqn\":\"aws.dataAwsSignerSigningJob.DataAwsSignerSigningJobRevocationRecordList\"}")]
        public virtual aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobRevocationRecordList RevocationRecord
        {
            get => GetInstanceProperty<aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobRevocationRecordList>()!;
        }

        [JsiiProperty(name: "signatureExpiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureExpiresAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signedObject", typeJson: "{\"fqn\":\"aws.dataAwsSignerSigningJob.DataAwsSignerSigningJobSignedObjectList\"}")]
        public virtual aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobSignedObjectList SignedObject
        {
            get => GetInstanceProperty<aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobSignedObjectList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.dataAwsSignerSigningJob.DataAwsSignerSigningJobSourceList\"}")]
        public virtual aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobSourceList Source
        {
            get => GetInstanceProperty<aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobSourceList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
