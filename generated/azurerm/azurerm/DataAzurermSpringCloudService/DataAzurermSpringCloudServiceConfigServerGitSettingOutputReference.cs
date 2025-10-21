using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSpringCloudService
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingOutputReference), fullyQualifiedName: "azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermSpringCloudServiceConfigServerGitSettingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermSpringCloudServiceConfigServerGitSettingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermSpringCloudServiceConfigServerGitSettingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermSpringCloudServiceConfigServerGitSettingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingHttpBasicAuthList\"}")]
        public virtual azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingHttpBasicAuthList HttpBasicAuth
        {
            get => GetInstanceProperty<azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingHttpBasicAuthList>()!;
        }

        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Label
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingRepositoryList\"}")]
        public virtual azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingRepositoryList Repository
        {
            get => GetInstanceProperty<azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingRepositoryList>()!;
        }

        [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SearchPaths
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingSshAuthList\"}")]
        public virtual azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingSshAuthList SshAuth
        {
            get => GetInstanceProperty<azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSettingSshAuthList>()!;
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfigServerGitSetting\"}", isOptional: true)]
        public virtual azurerm.DataAzurermSpringCloudService.IDataAzurermSpringCloudServiceConfigServerGitSetting? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermSpringCloudService.IDataAzurermSpringCloudServiceConfigServerGitSetting?>();
            set => SetInstanceProperty(value);
        }
    }
}
