using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskOutputReference), fullyQualifiedName: "azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStartTaskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermBatchPoolStartTaskOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermBatchPoolStartTaskOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermBatchPoolStartTaskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermBatchPoolStartTaskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandLine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commonEnvironmentProperties", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap CommonEnvironmentProperties
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStartTaskContainerList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskContainerList Container
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskContainerList>()!;
        }

        [JsiiProperty(name: "resourceFile", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStartTaskResourceFileList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskResourceFileList ResourceFile
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskResourceFileList>()!;
        }

        [JsiiProperty(name: "taskRetryMaximum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskRetryMaximum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "userIdentity", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStartTaskUserIdentityList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskUserIdentityList UserIdentity
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskUserIdentityList>()!;
        }

        [JsiiProperty(name: "waitForSuccess", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable WaitForSuccess
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStartTask\"}", isOptional: true)]
        public virtual azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolStartTask? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolStartTask?>();
            set => SetInstanceProperty(value);
        }
    }
}
