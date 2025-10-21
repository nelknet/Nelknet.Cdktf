using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiClass(nativeType: typeof(aws.TransferWorkflow.TransferWorkflowOnExceptionStepsOutputReference), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class TransferWorkflowOnExceptionStepsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public TransferWorkflowOnExceptionStepsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferWorkflowOnExceptionStepsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferWorkflowOnExceptionStepsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCopyStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetails\"}}]")]
        public virtual void PutCopyStepDetails(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetails\"}}]")]
        public virtual void PutCustomStepDetails(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDecryptStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails\"}}]")]
        public virtual void PutDecryptStepDetails(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeleteStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetails\"}}]")]
        public virtual void PutDeleteStepDetails(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTagStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetails\"}}]")]
        public virtual void PutTagStepDetails(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCopyStepDetails")]
        public virtual void ResetCopyStepDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomStepDetails")]
        public virtual void ResetCustomStepDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDecryptStepDetails")]
        public virtual void ResetDecryptStepDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteStepDetails")]
        public virtual void ResetDeleteStepDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagStepDetails")]
        public virtual void ResetTagStepDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetailsOutputReference CopyStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetailsOutputReference CustomStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference DecryptStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetailsOutputReference DeleteStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetailsOutputReference TagStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails? CopyStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails? CustomStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "decryptStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails? DecryptStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails? DeleteStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails? TagStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionSteps\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TransferWorkflow.ITransferWorkflowOnExceptionSteps cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionSteps).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
