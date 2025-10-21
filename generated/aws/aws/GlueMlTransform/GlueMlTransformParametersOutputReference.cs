using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueMlTransform
{
    [JsiiClass(nativeType: typeof(aws.GlueMlTransform.GlueMlTransformParametersOutputReference), fullyQualifiedName: "aws.glueMlTransform.GlueMlTransformParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueMlTransformParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueMlTransformParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueMlTransformParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueMlTransformParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFindMatchesParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters\"}}]")]
        public virtual void PutFindMatchesParameters(aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters)}, new object[]{@value});
        }

        [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParametersFindMatchesParametersOutputReference\"}")]
        public virtual aws.GlueMlTransform.GlueMlTransformParametersFindMatchesParametersOutputReference FindMatchesParameters
        {
            get => GetInstanceProperty<aws.GlueMlTransform.GlueMlTransformParametersFindMatchesParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "findMatchesParametersInput", typeJson: "{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters\"}", isOptional: true)]
        public virtual aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters? FindMatchesParametersInput
        {
            get => GetInstanceProperty<aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transformTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransformTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransformType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParameters\"}", isOptional: true)]
        public virtual aws.GlueMlTransform.IGlueMlTransformParameters? InternalValue
        {
            get => GetInstanceProperty<aws.GlueMlTransform.IGlueMlTransformParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
