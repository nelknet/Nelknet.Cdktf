using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudService.SpringCloudServiceDefaultBuildServiceOutputReference), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceDefaultBuildServiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpringCloudServiceDefaultBuildServiceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpringCloudServiceDefaultBuildServiceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpringCloudServiceDefaultBuildServiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudServiceDefaultBuildServiceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContainerRegistryName")]
        public virtual void ResetContainerRegistryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRegistryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "containerRegistryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceDefaultBuildService\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService? InternalValue
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService?>();
            set => SetInstanceProperty(value);
        }
    }
}
