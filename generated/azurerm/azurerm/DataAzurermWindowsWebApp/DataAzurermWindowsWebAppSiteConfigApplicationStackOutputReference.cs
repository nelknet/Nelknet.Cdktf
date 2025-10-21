using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigApplicationStackOutputReference), fullyQualifiedName: "azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigApplicationStackOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermWindowsWebAppSiteConfigApplicationStackOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermWindowsWebAppSiteConfigApplicationStackOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermWindowsWebAppSiteConfigApplicationStackOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebAppSiteConfigApplicationStackOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currentStack", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentStack
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerImageName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerRegistryPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerRegistryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerRegistryUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dotnetCoreVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DotnetCoreVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DotnetVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaContainer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaContainer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaContainerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaContainerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaEmbeddedServerEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable JavaEmbeddedServerEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhpVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "python", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Python
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PythonVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tomcatVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TomcatVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigApplicationStack\"}", isOptional: true)]
        public virtual azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppSiteConfigApplicationStack? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppSiteConfigApplicationStack?>();
            set => SetInstanceProperty(value);
        }
    }
}
