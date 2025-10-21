using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsKmsKey
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key aws_kms_key}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsKmsKey.DataAwsKmsKey), fullyQualifiedName: "aws.dataAwsKmsKey.DataAwsKmsKey", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsKmsKey.DataAwsKmsKeyConfig\"}}]")]
    public class DataAwsKmsKey : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key aws_kms_key} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsKmsKey(Constructs.Construct scope, string id, aws.DataAwsKmsKey.IDataAwsKmsKeyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsKmsKey.IDataAwsKmsKeyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsKey(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsKey(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsKmsKey resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsKmsKey to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsKmsKey that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsKmsKey to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsKmsKey to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_key#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsKmsKey that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsKmsKey to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsKmsKey.DataAwsKmsKey), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetGrantTokens")]
        public virtual void ResetGrantTokens()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.DataAwsKmsKey.DataAwsKmsKey))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudHsmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudHsmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerMasterKeySpec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerMasterKeySpec
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customKeyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomKeyStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletionDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeletionDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "expirationModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyManager", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyManager
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keySpec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeySpec
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyUsage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyUsage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multiRegion", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MultiRegion
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "multiRegionConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsKmsKey.DataAwsKmsKeyMultiRegionConfigurationList\"}")]
        public virtual aws.DataAwsKmsKey.DataAwsKmsKeyMultiRegionConfigurationList MultiRegionConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsKmsKey.DataAwsKmsKeyMultiRegionConfigurationList>()!;
        }

        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Origin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingDeletionWindowInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingDeletionWindowInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "validTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "xksKeyConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsKmsKey.DataAwsKmsKeyXksKeyConfigurationList\"}")]
        public virtual aws.DataAwsKmsKey.DataAwsKmsKeyXksKeyConfigurationList XksKeyConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsKmsKey.DataAwsKmsKeyXksKeyConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantTokensInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GrantTokensInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "grantTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GrantTokens
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
