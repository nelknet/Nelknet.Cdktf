using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServiceCertificateOrder
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order azurerm_app_service_certificate_order}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder), fullyQualifiedName: "azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderConfig\"}}]")]
    public class DataAzurermAppServiceCertificateOrder : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order azurerm_app_service_certificate_order} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermAppServiceCertificateOrder(Constructs.Construct scope, string id, azurerm.DataAzurermAppServiceCertificateOrder.IDataAzurermAppServiceCertificateOrderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermAppServiceCertificateOrder.IDataAzurermAppServiceCertificateOrderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAppServiceCertificateOrder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAppServiceCertificateOrder(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermAppServiceCertificateOrder resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermAppServiceCertificateOrder to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermAppServiceCertificateOrder that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermAppServiceCertificateOrder to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermAppServiceCertificateOrder to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermAppServiceCertificateOrder that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermAppServiceCertificateOrder to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermAppServiceCertificateOrder.IDataAzurermAppServiceCertificateOrderTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermAppServiceCertificateOrder.IDataAzurermAppServiceCertificateOrderTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder))!;

        [JsiiProperty(name: "appServiceCertificateNotRenewableReasons", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AppServiceCertificateNotRenewableReasons
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "autoRenew", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutoRenew
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "certificates", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderCertificatesList\"}")]
        public virtual azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderCertificatesList Certificates
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderCertificatesList>()!;
        }

        [JsiiProperty(name: "csr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Csr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "distinguishedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistinguishedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainVerificationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainVerificationToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expirationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "intermediateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntermediateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPrivateKeyExternal", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IsPrivateKeyExternal
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signedCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignedCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "validityInYears", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidityInYears
        {
            get => GetInstanceProperty<double>()!;
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
