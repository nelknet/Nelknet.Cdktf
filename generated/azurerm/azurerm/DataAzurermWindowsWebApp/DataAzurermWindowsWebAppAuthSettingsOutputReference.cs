using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsOutputReference), fullyQualifiedName: "azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermWindowsWebAppAuthSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermWindowsWebAppAuthSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermWindowsWebAppAuthSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebAppAuthSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsActiveDirectoryList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsActiveDirectoryList ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsActiveDirectoryList>()!;
        }

        [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap AdditionalLoginParameters
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedExternalRedirectUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsFacebookList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsFacebookList Facebook
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsFacebookList>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsGithubList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsGithubList Github
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsGithubList>()!;
        }

        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsGoogleList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsGoogleList Google
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsGoogleList>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsMicrosoftList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsMicrosoftList Microsoft
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsMicrosoftList>()!;
        }

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TokenRefreshExtensionHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable TokenStoreEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsTwitterList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsTwitterList Twitter
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsTwitterList>()!;
        }

        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnauthenticatedClientAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettings\"}", isOptional: true)]
        public virtual azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppAuthSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppAuthSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
