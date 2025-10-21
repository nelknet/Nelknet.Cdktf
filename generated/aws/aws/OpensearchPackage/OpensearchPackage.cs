using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchPackage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package aws_opensearch_package}.</summary>
    [JsiiClass(nativeType: typeof(aws.OpensearchPackage.OpensearchPackage), fullyQualifiedName: "aws.opensearchPackage.OpensearchPackage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.opensearchPackage.OpensearchPackageConfig\"}}]")]
    public class OpensearchPackage : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package aws_opensearch_package} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpensearchPackage(Constructs.Construct scope, string id, aws.OpensearchPackage.IOpensearchPackageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OpensearchPackage.IOpensearchPackageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchPackage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchPackage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a OpensearchPackage resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OpensearchPackage to import.</param>
        /// <param name="importFromId">The id of the existing OpensearchPackage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OpensearchPackage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OpensearchPackage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OpensearchPackage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OpensearchPackage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.OpensearchPackage.OpensearchPackage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPackageSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchPackage.OpensearchPackagePackageSource\"}}]")]
        public virtual void PutPackageSource(aws.OpensearchPackage.IOpensearchPackagePackageSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchPackage.IOpensearchPackagePackageSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageDescription")]
        public virtual void ResetPackageDescription()
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
        = GetStaticProperty<string>(typeof(aws.OpensearchPackage.OpensearchPackage))!;

        [JsiiProperty(name: "availablePackageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailablePackageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageSource", typeJson: "{\"fqn\":\"aws.opensearchPackage.OpensearchPackagePackageSourceOutputReference\"}")]
        public virtual aws.OpensearchPackage.OpensearchPackagePackageSourceOutputReference PackageSource
        {
            get => GetInstanceProperty<aws.OpensearchPackage.OpensearchPackagePackageSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageSourceInput", typeJson: "{\"fqn\":\"aws.opensearchPackage.OpensearchPackagePackageSource\"}", isOptional: true)]
        public virtual aws.OpensearchPackage.IOpensearchPackagePackageSource? PackageSourceInput
        {
            get => GetInstanceProperty<aws.OpensearchPackage.IOpensearchPackagePackageSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
