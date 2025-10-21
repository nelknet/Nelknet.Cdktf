using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    [JsiiClass(nativeType: typeof(azurerm.GalleryApplicationVersion.GalleryApplicationVersionSourceOutputReference), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GalleryApplicationVersionSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GalleryApplicationVersionSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GalleryApplicationVersionSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GalleryApplicationVersionSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultConfigurationLink")]
        public virtual void ResetDefaultConfigurationLink()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultConfigurationLinkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultConfigurationLinkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediaLinkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediaLinkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultConfigurationLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultConfigurationLink
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mediaLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediaLink
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionSource\"}", isOptional: true)]
        public virtual azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource? InternalValue
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
