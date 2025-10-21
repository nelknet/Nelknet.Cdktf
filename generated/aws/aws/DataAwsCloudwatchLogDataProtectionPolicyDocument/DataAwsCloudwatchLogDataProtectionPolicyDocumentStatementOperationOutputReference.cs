using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCloudwatchLogDataProtectionPolicyDocument
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationOutputReference), fullyQualifiedName: "aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAudit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit\"}}]")]
        public virtual void PutAudit(aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeidentify", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify\"}}]")]
        public virtual void PutDeidentify(aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAudit")]
        public virtual void ResetAudit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeidentify")]
        public virtual void ResetDeidentify()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "audit", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditOutputReference\"}")]
        public virtual aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditOutputReference Audit
        {
            get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditOutputReference>()!;
        }

        [JsiiProperty(name: "deidentify", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentifyOutputReference\"}")]
        public virtual aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentifyOutputReference Deidentify
        {
            get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentifyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditInput", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit\"}", isOptional: true)]
        public virtual aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit? AuditInput
        {
            get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deidentifyInput", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify\"}", isOptional: true)]
        public virtual aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify? DeidentifyInput
        {
            get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperation\"}", isOptional: true)]
        public virtual aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperation? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperation?>();
            set => SetInstanceProperty(value);
        }
    }
}
