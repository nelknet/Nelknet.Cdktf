using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool.CognitoUserPoolSchemaOutputReference), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolSchemaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CognitoUserPoolSchemaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CognitoUserPoolSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNumberAttributeConstraints", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraints\"}}]")]
        public virtual void PutNumberAttributeConstraints(aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringAttributeConstraints", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraints\"}}]")]
        public virtual void PutStringAttributeConstraints(aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeveloperOnlyAttribute")]
        public virtual void ResetDeveloperOnlyAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMutable")]
        public virtual void ResetMutable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberAttributeConstraints")]
        public virtual void ResetNumberAttributeConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequired")]
        public virtual void ResetRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringAttributeConstraints")]
        public virtual void ResetStringAttributeConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference NumberAttributeConstraints
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference>()!;
        }

        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraintsOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraintsOutputReference StringAttributeConstraints
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraintsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeDataTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributeDataTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "developerOnlyAttributeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeveloperOnlyAttributeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mutableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MutableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberAttributeConstraintsInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraints\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints? NumberAttributeConstraintsInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringAttributeConstraintsInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraints\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints? StringAttributeConstraintsInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints?>();
        }

        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributeDataType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeveloperOnlyAttribute
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "mutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Mutable
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Required
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchema\"}]}}", isOptional: true)]
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
                        case aws.CognitoUserPool.ICognitoUserPoolSchema cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolSchema).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
