using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiClass(nativeType: typeof(aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemOutputReference), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerSpaceSpaceSettingsCustomFileSystemOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerSpaceSpaceSettingsCustomFileSystemOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SagemakerSpaceSpaceSettingsCustomFileSystemOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerSpaceSpaceSettingsCustomFileSystemOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEfsFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem\"}}]")]
        public virtual void PutEfsFileSystem(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem)}, new object[]{@value});
        }

        [JsiiProperty(name: "efsFileSystem", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystemOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystemOutputReference EfsFileSystem
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "efsFileSystemInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystemInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystemEfsFileSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem\"}]}}", isOptional: true)]
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
                        case aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
