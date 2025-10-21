using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    [JsiiClass(nativeType: typeof(azurerm.GalleryApplicationVersion.GalleryApplicationVersionManageActionOutputReference), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionManageActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GalleryApplicationVersionManageActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GalleryApplicationVersionManageActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GalleryApplicationVersionManageActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GalleryApplicationVersionManageActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetUpdate")]
        public virtual void ResetUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "installInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstallInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "removeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoveInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "install", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Install
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "remove", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Remove
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Update
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionManageAction\"}", isOptional: true)]
        public virtual azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction? InternalValue
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
