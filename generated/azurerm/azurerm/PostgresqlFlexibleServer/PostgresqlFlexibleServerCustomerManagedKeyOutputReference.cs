using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    [JsiiClass(nativeType: typeof(azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerCustomerManagedKeyOutputReference), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerCustomerManagedKeyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PostgresqlFlexibleServerCustomerManagedKeyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PostgresqlFlexibleServerCustomerManagedKeyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PostgresqlFlexibleServerCustomerManagedKeyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PostgresqlFlexibleServerCustomerManagedKeyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGeoBackupKeyVaultKeyId")]
        public virtual void ResetGeoBackupKeyVaultKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoBackupUserAssignedIdentityId")]
        public virtual void ResetGeoBackupUserAssignedIdentityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryUserAssignedIdentityId")]
        public virtual void ResetPrimaryUserAssignedIdentityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoBackupKeyVaultKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GeoBackupKeyVaultKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoBackupUserAssignedIdentityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GeoBackupUserAssignedIdentityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryUserAssignedIdentityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryUserAssignedIdentityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "geoBackupKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoBackupKeyVaultKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "geoBackupUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoBackupUserAssignedIdentityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryUserAssignedIdentityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerCustomerManagedKey\"}", isOptional: true)]
        public virtual azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerCustomerManagedKey? InternalValue
        {
            get => GetInstanceProperty<azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerCustomerManagedKey?>();
            set => SetInstanceProperty(value);
        }
    }
}
