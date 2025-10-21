using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageGallery
{
    [JsiiClass(nativeType: typeof(azurerm.SharedImageGallery.SharedImageGallerySharingCommunityGalleryOutputReference), fullyQualifiedName: "azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGalleryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SharedImageGallerySharingCommunityGalleryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SharedImageGallerySharingCommunityGalleryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SharedImageGallerySharingCommunityGalleryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SharedImageGallerySharingCommunityGalleryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eulaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EulaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publisherEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublisherEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publisherUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublisherUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "eula", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Eula
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publisherUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery\"}", isOptional: true)]
        public virtual azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery? InternalValue
        {
            get => GetInstanceProperty<azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery?>();
            set => SetInstanceProperty(value);
        }
    }
}
