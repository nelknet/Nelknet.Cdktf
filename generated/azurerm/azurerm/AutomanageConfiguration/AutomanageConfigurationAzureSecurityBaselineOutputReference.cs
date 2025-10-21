using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.AutomanageConfiguration.AutomanageConfigurationAzureSecurityBaselineOutputReference), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationAzureSecurityBaselineOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomanageConfigurationAzureSecurityBaselineOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomanageConfigurationAzureSecurityBaselineOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomanageConfigurationAzureSecurityBaselineOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomanageConfigurationAzureSecurityBaselineOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAssignmentType")]
        public virtual void ResetAssignmentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssignmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationAzureSecurityBaseline\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationAzureSecurityBaseline? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationAzureSecurityBaseline?>();
            set => SetInstanceProperty(value);
        }
    }
}
