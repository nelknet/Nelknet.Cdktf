using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiClass(nativeType: typeof(aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeConfigurationValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}}]")]
        public virtual void PutCodeConfigurationValues(aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeConfigurationValues")]
        public virtual void ResetCodeConfigurationValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeConfigurationValues", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValuesOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValuesOutputReference CodeConfigurationValues
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValuesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationValuesInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValuesInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configurationSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
