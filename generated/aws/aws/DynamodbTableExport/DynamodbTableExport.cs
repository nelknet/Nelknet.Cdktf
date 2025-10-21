using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTableExport
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export aws_dynamodb_table_export}.</summary>
    [JsiiClass(nativeType: typeof(aws.DynamodbTableExport.DynamodbTableExport), fullyQualifiedName: "aws.dynamodbTableExport.DynamodbTableExport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportConfig\"}}]")]
    public class DynamodbTableExport : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export aws_dynamodb_table_export} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DynamodbTableExport(Constructs.Construct scope, string id, aws.DynamodbTableExport.IDynamodbTableExportConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DynamodbTableExport.IDynamodbTableExportConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableExport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableExport(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DynamodbTableExport resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DynamodbTableExport to import.</param>
        /// <param name="importFromId">The id of the existing DynamodbTableExport that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DynamodbTableExport to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DynamodbTableExport to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DynamodbTableExport that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DynamodbTableExport to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DynamodbTableExport.DynamodbTableExport), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIncrementalExportSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecification\"}}]")]
        public virtual void PutIncrementalExportSpecification(aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DynamodbTableExport.IDynamodbTableExportTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTableExport.IDynamodbTableExportTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExportFormat")]
        public virtual void ResetExportFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportTime")]
        public virtual void ResetExportTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportType")]
        public virtual void ResetExportType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncrementalExportSpecification")]
        public virtual void ResetIncrementalExportSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3BucketOwner")]
        public virtual void ResetS3BucketOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Prefix")]
        public virtual void ResetS3Prefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3SseAlgorithm")]
        public virtual void ResetS3SseAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3SseKmsKeyId")]
        public virtual void ResetS3SseKmsKeyId()
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
        = GetStaticProperty<string>(typeof(aws.DynamodbTableExport.DynamodbTableExport))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billedSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BilledSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exportStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "incrementalExportSpecification", typeJson: "{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecificationOutputReference\"}")]
        public virtual aws.DynamodbTableExport.DynamodbTableExportIncrementalExportSpecificationOutputReference IncrementalExportSpecification
        {
            get => GetInstanceProperty<aws.DynamodbTableExport.DynamodbTableExportIncrementalExportSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "itemCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ItemCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "manifestFilesS3Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManifestFilesS3Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportTimeoutsOutputReference\"}")]
        public virtual aws.DynamodbTableExport.DynamodbTableExportTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DynamodbTableExport.DynamodbTableExportTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportTypeInput
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
        [JsiiProperty(name: "incrementalExportSpecificationInput", typeJson: "{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecification\"}", isOptional: true)]
        public virtual aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification? IncrementalExportSpecificationInput
        {
            get => GetInstanceProperty<aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketOwnerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketOwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3PrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3SseAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3SseAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3SseKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3SseKmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "exportFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportType
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

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3BucketOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BucketOwner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3SseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3SseAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3SseKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3SseKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
