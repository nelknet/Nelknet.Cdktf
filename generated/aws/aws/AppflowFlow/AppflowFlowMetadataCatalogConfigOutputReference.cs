using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowMetadataCatalogConfigOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowMetadataCatalogConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowMetadataCatalogConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowMetadataCatalogConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowMetadataCatalogConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowMetadataCatalogConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGlueDataCatalog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalog\"}}]")]
        public virtual void PutGlueDataCatalog(aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGlueDataCatalog")]
        public virtual void ResetGlueDataCatalog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "glueDataCatalog", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalogOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalogOutputReference GlueDataCatalog
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalogOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "glueDataCatalogInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowMetadataCatalogConfigGlueDataCatalog\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog? GlueDataCatalogInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowMetadataCatalogConfigGlueDataCatalog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowMetadataCatalogConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowMetadataCatalogConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowMetadataCatalogConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
