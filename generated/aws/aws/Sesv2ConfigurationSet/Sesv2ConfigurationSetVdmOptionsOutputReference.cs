using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiClass(nativeType: typeof(aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsOutputReference), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Sesv2ConfigurationSetVdmOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Sesv2ConfigurationSetVdmOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Sesv2ConfigurationSetVdmOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Sesv2ConfigurationSetVdmOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDashboardOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptions\"}}]")]
        public virtual void PutDashboardOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGuardianOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions\"}}]")]
        public virtual void PutGuardianOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDashboardOptions")]
        public virtual void ResetDashboardOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuardianOptions")]
        public virtual void ResetGuardianOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dashboardOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptionsOutputReference DashboardOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "guardianOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference GuardianOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dashboardOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions? DashboardOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guardianOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions? GuardianOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
