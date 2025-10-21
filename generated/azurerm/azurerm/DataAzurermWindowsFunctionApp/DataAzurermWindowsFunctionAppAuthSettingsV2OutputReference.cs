using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsFunctionApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2OutputReference), fullyQualifiedName: "azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermWindowsFunctionAppAuthSettingsV2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermWindowsFunctionAppAuthSettingsV2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermWindowsFunctionAppAuthSettingsV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsFunctionAppAuthSettingsV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeDirectoryV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2ActiveDirectoryV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2ActiveDirectoryV2List ActiveDirectoryV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2ActiveDirectoryV2List>()!;
        }

        [JsiiProperty(name: "appleV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2AppleV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2AppleV2List AppleV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2AppleV2List>()!;
        }

        [JsiiProperty(name: "authEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AuthEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "azureStaticWebAppV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2AzureStaticWebAppV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2AzureStaticWebAppV2List AzureStaticWebAppV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2AzureStaticWebAppV2List>()!;
        }

        [JsiiProperty(name: "configFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigFilePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customOidcV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2CustomOidcV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2CustomOidcV2List CustomOidcV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2CustomOidcV2List>()!;
        }

        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "excludedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedPaths
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "facebookV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2FacebookV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2FacebookV2List FacebookV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2FacebookV2List>()!;
        }

        [JsiiProperty(name: "forwardProxyConvention", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProxyConvention
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forwardProxyCustomHostHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProxyCustomHostHeaderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forwardProxyCustomSchemeHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProxyCustomSchemeHeaderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "githubV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2GithubV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2GithubV2List GithubV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2GithubV2List>()!;
        }

        [JsiiProperty(name: "googleV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2GoogleV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2GoogleV2List GoogleV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2GoogleV2List>()!;
        }

        [JsiiProperty(name: "httpRouteApiPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpRouteApiPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "login", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2LoginList\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2LoginList Login
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2LoginList>()!;
        }

        [JsiiProperty(name: "microsoftV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2MicrosoftV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2MicrosoftV2List MicrosoftV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2MicrosoftV2List>()!;
        }

        [JsiiProperty(name: "requireAuthentication", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RequireAuthentication
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "requireHttps", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RequireHttps
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "twitterV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2TwitterV2List\"}")]
        public virtual azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2TwitterV2List TwitterV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2TwitterV2List>()!;
        }

        [JsiiProperty(name: "unauthenticatedAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnauthenticatedAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppAuthSettingsV2\"}", isOptional: true)]
        public virtual azurerm.DataAzurermWindowsFunctionApp.IDataAzurermWindowsFunctionAppAuthSettingsV2? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsFunctionApp.IDataAzurermWindowsFunctionAppAuthSettingsV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
