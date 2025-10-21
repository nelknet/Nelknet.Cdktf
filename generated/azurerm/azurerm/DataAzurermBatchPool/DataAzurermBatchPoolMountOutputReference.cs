using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountOutputReference), fullyQualifiedName: "azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermBatchPoolMountOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermBatchPoolMountOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermBatchPoolMountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermBatchPoolMountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "azureBlobFileSystem", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMountAzureBlobFileSystemList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountAzureBlobFileSystemList AzureBlobFileSystem
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountAzureBlobFileSystemList>()!;
        }

        [JsiiProperty(name: "azureFileShare", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMountAzureFileShareList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountAzureFileShareList AzureFileShare
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountAzureFileShareList>()!;
        }

        [JsiiProperty(name: "cifsMount", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMountCifsMountList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountCifsMountList CifsMount
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountCifsMountList>()!;
        }

        [JsiiProperty(name: "nfsMount", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMountNfsMountList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountNfsMountList NfsMount
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountNfsMountList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMount\"}", isOptional: true)]
        public virtual azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolMount? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolMount?>();
            set => SetInstanceProperty(value);
        }
    }
}
