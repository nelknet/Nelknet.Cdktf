using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiClass(nativeType: typeof(azurerm.HpcCache.HpcCacheDirectoryFlatFileOutputReference), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryFlatFileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HpcCacheDirectoryFlatFileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HpcCacheDirectoryFlatFileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HpcCacheDirectoryFlatFileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HpcCacheDirectoryFlatFileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupFileUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupFileUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordFileUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordFileUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupFileUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupFileUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordFileUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordFileUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryFlatFile\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDirectoryFlatFile? InternalValue
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryFlatFile?>();
            set => SetInstanceProperty(value);
        }
    }
}
