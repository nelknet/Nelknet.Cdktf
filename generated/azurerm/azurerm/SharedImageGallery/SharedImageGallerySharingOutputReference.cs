using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageGallery
{
    [JsiiClass(nativeType: typeof(azurerm.SharedImageGallery.SharedImageGallerySharingOutputReference), fullyQualifiedName: "azurerm.sharedImageGallery.SharedImageGallerySharingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SharedImageGallerySharingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SharedImageGallerySharingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SharedImageGallerySharingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SharedImageGallerySharingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCommunityGallery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery\"}}]")]
        public virtual void PutCommunityGallery(azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCommunityGallery")]
        public virtual void ResetCommunityGallery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "communityGallery", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGalleryOutputReference\"}")]
        public virtual azurerm.SharedImageGallery.SharedImageGallerySharingCommunityGalleryOutputReference CommunityGallery
        {
            get => GetInstanceProperty<azurerm.SharedImageGallery.SharedImageGallerySharingCommunityGalleryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "communityGalleryInput", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery\"}", isOptional: true)]
        public virtual azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery? CommunityGalleryInput
        {
            get => GetInstanceProperty<azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PermissionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permission
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharing\"}", isOptional: true)]
        public virtual azurerm.SharedImageGallery.ISharedImageGallerySharing? InternalValue
        {
            get => GetInstanceProperty<azurerm.SharedImageGallery.ISharedImageGallerySharing?>();
            set => SetInstanceProperty(value);
        }
    }
}
