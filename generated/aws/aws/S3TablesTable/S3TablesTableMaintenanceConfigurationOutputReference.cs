using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiClass(nativeType: typeof(aws.S3TablesTable.S3TablesTableMaintenanceConfigurationOutputReference), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3TablesTableMaintenanceConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3TablesTableMaintenanceConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3TablesTableMaintenanceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3TablesTableMaintenanceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcebergCompaction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction\"}}]")]
        public virtual void PutIcebergCompaction(aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIcebergSnapshotManagement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagement\"}}]")]
        public virtual void PutIcebergSnapshotManagement(aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIcebergCompaction")]
        public virtual void ResetIcebergCompaction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcebergSnapshotManagement")]
        public virtual void ResetIcebergSnapshotManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "icebergCompaction", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionOutputReference\"}")]
        public virtual aws.S3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionOutputReference IcebergCompaction
        {
            get => GetInstanceProperty<aws.S3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionOutputReference>()!;
        }

        [JsiiProperty(name: "icebergSnapshotManagement", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementOutputReference\"}")]
        public virtual aws.S3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementOutputReference IcebergSnapshotManagement
        {
            get => GetInstanceProperty<aws.S3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icebergCompactionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction\"}]}}", isOptional: true)]
        public virtual object? IcebergCompactionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icebergSnapshotManagementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagement\"}]}}", isOptional: true)]
        public virtual object? IcebergSnapshotManagementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfiguration\"}]}}", isOptional: true)]
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
                        case aws.S3TablesTable.IS3TablesTableMaintenanceConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3TablesTable.IS3TablesTableMaintenanceConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
