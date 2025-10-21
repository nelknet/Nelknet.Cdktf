using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiClass(nativeType: typeof(aws.TransferWorkflow.TransferWorkflowStepsOutputReference), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class TransferWorkflowStepsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public TransferWorkflowStepsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected TransferWorkflowStepsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferWorkflowStepsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCopyStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetails\"}}]")]
        public virtual void PutCopyStepDetails(aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCustomStepDetails\"}}]")]
        public virtual void PutCustomStepDetails(aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDecryptStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetails\"}}]")]
        public virtual void PutDecryptStepDetails(aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeleteStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetails\"}}]")]
        public virtual void PutDeleteStepDetails(aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTagStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsTagStepDetails\"}}]")]
        public virtual void PutTagStepDetails(aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails)}, new object[]{@value});
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

        [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowStepsCopyStepDetailsOutputReference CopyStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowStepsCopyStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCustomStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowStepsCustomStepDetailsOutputReference CustomStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowStepsCustomStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowStepsDecryptStepDetailsOutputReference DecryptStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowStepsDecryptStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowStepsDeleteStepDetailsOutputReference DeleteStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowStepsDeleteStepDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsTagStepDetailsOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowStepsTagStepDetailsOutputReference TagStepDetails
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowStepsTagStepDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails? CopyStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCustomStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails? CustomStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "decryptStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails? DecryptStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails? DeleteStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagStepDetailsInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsTagStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails? TagStepDetailsInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.transferWorkflow.TransferWorkflowSteps\"}]}}", isOptional: true)]
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
                        case aws.TransferWorkflow.ITransferWorkflowSteps cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TransferWorkflow.ITransferWorkflowSteps).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
