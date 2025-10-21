using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment azurerm_nginx_deployment}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment), fullyQualifiedName: "azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentConfig\"}}]")]
    public class DataAzurermNginxDeployment : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment azurerm_nginx_deployment} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermNginxDeployment(Constructs.Construct scope, string id, azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNginxDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNginxDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermNginxDeployment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermNginxDeployment to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermNginxDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermNginxDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermNginxDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermNginxDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermNginxDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment))!;

        [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomaticUpgradeChannel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoScaleProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentAutoScaleProfileList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentAutoScaleProfileList AutoScaleProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentAutoScaleProfileList>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "diagnoseSupportEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DiagnoseSupportEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendPrivate", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentFrontendPrivateList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentFrontendPrivateList FrontendPrivate
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentFrontendPrivateList>()!;
        }

        [JsiiProperty(name: "frontendPublic", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentFrontendPublicList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentFrontendPublicList FrontendPublic
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentFrontendPublicList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentIdentityList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentIdentityList>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingStorageAccount", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentLoggingStorageAccountList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentLoggingStorageAccountList LoggingStorageAccount
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentLoggingStorageAccountList>()!;
        }

        [JsiiProperty(name: "managedResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentNetworkInterfaceList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "nginxVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NginxVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeouts\"}]}}", isOptional: true)]
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
