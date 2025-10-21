using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclDefaultActionBlockOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlockOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclDefaultActionBlockOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclDefaultActionBlockOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2WebAclDefaultActionBlockOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionBlockOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlockCustomResponse\"}}]")]
        public virtual void PutCustomResponse(aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlockCustomResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlockCustomResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomResponse")]
        public virtual void ResetCustomResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlockCustomResponseOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclDefaultActionBlockCustomResponseOutputReference CustomResponse
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclDefaultActionBlockCustomResponseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customResponseInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlockCustomResponse\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlockCustomResponse? CustomResponseInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlockCustomResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlock? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlock?>();
            set => SetInstanceProperty(value);
        }
    }
}
