using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2OutputReference), fullyQualifiedName: "azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorisationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorisationEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificationUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificationUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientCredentialMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCredentialMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecretSettingName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameClaimType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameClaimType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openidConfigurationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenidConfigurationEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2\"}", isOptional: true)]
        public virtual azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppAuthSettingsV2CustomOidcV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
