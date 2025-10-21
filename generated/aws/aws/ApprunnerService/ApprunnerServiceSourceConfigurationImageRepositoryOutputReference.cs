using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiClass(nativeType: typeof(aws.ApprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApprunnerServiceSourceConfigurationImageRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApprunnerServiceSourceConfigurationImageRepositoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApprunnerServiceSourceConfigurationImageRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationImageRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}}]")]
        public virtual void PutImageConfiguration(aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetImageConfiguration")]
        public virtual void ResetImageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference ImageConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? ImageConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageRepositoryTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageRepositoryTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageRepositoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageRepositoryType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository? InternalValue
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
