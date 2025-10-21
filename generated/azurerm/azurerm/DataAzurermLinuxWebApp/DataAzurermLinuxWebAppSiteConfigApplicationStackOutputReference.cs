using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigApplicationStackOutputReference), fullyQualifiedName: "azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigApplicationStackOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermLinuxWebAppSiteConfigApplicationStackOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermLinuxWebAppSiteConfigApplicationStackOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermLinuxWebAppSiteConfigApplicationStackOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermLinuxWebAppSiteConfigApplicationStackOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DotnetVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "goVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GoVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaServerVersion
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PythonVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rubyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RubyVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigApplicationStack\"}", isOptional: true)]
        public virtual azurerm.DataAzurermLinuxWebApp.IDataAzurermLinuxWebAppSiteConfigApplicationStack? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.IDataAzurermLinuxWebAppSiteConfigApplicationStack?>();
            set => SetInstanceProperty(value);
        }
    }
}
