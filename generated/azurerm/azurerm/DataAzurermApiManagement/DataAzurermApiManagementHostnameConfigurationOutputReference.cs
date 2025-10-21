using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagement
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationOutputReference), fullyQualifiedName: "azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermApiManagementHostnameConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermApiManagementHostnameConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermApiManagementHostnameConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApiManagementHostnameConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "developerPortal", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationDeveloperPortalList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationDeveloperPortalList DeveloperPortal
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationDeveloperPortalList>()!;
        }

        [JsiiProperty(name: "management", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationManagementList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationManagementList Management
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationManagementList>()!;
        }

        [JsiiProperty(name: "portal", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationPortalList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationPortalList Portal
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationPortalList>()!;
        }

        [JsiiProperty(name: "proxy", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationProxyList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationProxyList Proxy
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationProxyList>()!;
        }

        [JsiiProperty(name: "scm", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationScmList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationScmList Scm
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationScmList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfiguration\"}", isOptional: true)]
        public virtual azurerm.DataAzurermApiManagement.IDataAzurermApiManagementHostnameConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.IDataAzurermApiManagementHostnameConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
