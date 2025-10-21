using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerProject
{
    [JsiiClass(nativeType: typeof(aws.SagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsOutputReference), fullyQualifiedName: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerProjectServiceCatalogProvisioningDetailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerProjectServiceCatalogProvisioningDetailsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerProjectServiceCatalogProvisioningDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerProjectServiceCatalogProvisioningDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProvisioningParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProvisioningParameter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPathId")]
        public virtual void ResetPathId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisioningArtifactId")]
        public virtual void ResetProvisioningArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisioningParameter")]
        public virtual void ResetProvisioningParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "provisioningParameter", typeJson: "{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameterList\"}")]
        public virtual aws.SagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameterList ProvisioningParameter
        {
            get => GetInstanceProperty<aws.SagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisioningArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProvisioningArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisioningParameterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProvisioningParameterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisioningArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetails\"}", isOptional: true)]
        public virtual aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetails? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
