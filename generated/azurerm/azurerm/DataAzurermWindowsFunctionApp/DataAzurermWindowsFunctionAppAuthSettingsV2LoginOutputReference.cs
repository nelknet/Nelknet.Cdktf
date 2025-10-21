using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsFunctionApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2LoginOutputReference), fullyQualifiedName: "azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2LoginOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermWindowsFunctionAppAuthSettingsV2LoginOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermWindowsFunctionAppAuthSettingsV2LoginOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermWindowsFunctionAppAuthSettingsV2LoginOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsFunctionAppAuthSettingsV2LoginOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedExternalRedirectUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "cookieExpirationConvention", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieExpirationConvention
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cookieExpirationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieExpirationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonceExpirationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NonceExpirationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preserveUrlFragmentsForLogins", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PreserveUrlFragmentsForLogins
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "tokenRefreshExtensionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TokenRefreshExtensionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable TokenStoreEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "tokenStorePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenStorePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokenStoreSasSettingName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenStoreSasSettingName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validateNonce", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ValidateNonce
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2Login\"}", isOptional: true)]
        public virtual azurerm.DataAzurermWindowsFunctionApp.IDataAzurermWindowsFunctionAppAuthSettingsV2Login? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.IDataAzurermWindowsFunctionAppAuthSettingsV2Login?>();
            set => SetInstanceProperty(value);
        }
    }
}
