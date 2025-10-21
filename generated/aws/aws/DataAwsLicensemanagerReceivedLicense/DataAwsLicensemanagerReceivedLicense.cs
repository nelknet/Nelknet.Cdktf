using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLicensemanagerReceivedLicense
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_license aws_licensemanager_received_license}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense), fullyQualifiedName: "aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseConfig\"}}]")]
    public class DataAwsLicensemanagerReceivedLicense : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_license aws_licensemanager_received_license} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLicensemanagerReceivedLicense(Constructs.Construct scope, string id, aws.DataAwsLicensemanagerReceivedLicense.IDataAwsLicensemanagerReceivedLicenseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsLicensemanagerReceivedLicense.IDataAwsLicensemanagerReceivedLicenseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLicensemanagerReceivedLicense(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLicensemanagerReceivedLicense(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsLicensemanagerReceivedLicense resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsLicensemanagerReceivedLicense to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsLicensemanagerReceivedLicense that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsLicensemanagerReceivedLicense to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsLicensemanagerReceivedLicense to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_received_license#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsLicensemanagerReceivedLicense that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsLicensemanagerReceivedLicense to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicense))!;

        [JsiiProperty(name: "beneficiary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Beneficiary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumptionConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseConsumptionConfigurationList\"}")]
        public virtual aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseConsumptionConfigurationList ConsumptionConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseConsumptionConfigurationList>()!;
        }

        [JsiiProperty(name: "createTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitlements", typeJson: "{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseEntitlementsList\"}")]
        public virtual aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseEntitlementsList Entitlements
        {
            get => GetInstanceProperty<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseEntitlementsList>()!;
        }

        [JsiiProperty(name: "homeRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseIssuerList\"}")]
        public virtual aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseIssuerList Issuer
        {
            get => GetInstanceProperty<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseIssuerList>()!;
        }

        [JsiiProperty(name: "licenseMetadata", typeJson: "{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseLicenseMetadataList\"}")]
        public virtual aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseLicenseMetadataList LicenseMetadata
        {
            get => GetInstanceProperty<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseLicenseMetadataList>()!;
        }

        [JsiiProperty(name: "licenseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receivedMetadata", typeJson: "{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseReceivedMetadataList\"}")]
        public virtual aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseReceivedMetadataList ReceivedMetadata
        {
            get => GetInstanceProperty<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseReceivedMetadataList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"aws.dataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseValidityList\"}")]
        public virtual aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseValidityList Validity
        {
            get => GetInstanceProperty<aws.DataAwsLicensemanagerReceivedLicense.DataAwsLicensemanagerReceivedLicenseValidityList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
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
        [JsiiProperty(name: "licenseArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenseArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
