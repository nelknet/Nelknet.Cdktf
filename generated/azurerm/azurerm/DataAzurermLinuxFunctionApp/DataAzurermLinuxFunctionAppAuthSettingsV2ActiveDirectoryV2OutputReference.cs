using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxFunctionApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2OutputReference), fullyQualifiedName: "azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedApplications
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedAudiences
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedIdentities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedIdentities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecretCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecretCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecretSettingName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtAllowedClientApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] JwtAllowedClientApplications
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "jwtAllowedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] JwtAllowedGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "loginParameters", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap LoginParameters
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "tenantAuthEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantAuthEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wwwAuthenticationDisabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable WwwAuthenticationDisabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2\"}", isOptional: true)]
        public virtual azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppAuthSettingsV2ActiveDirectoryV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
